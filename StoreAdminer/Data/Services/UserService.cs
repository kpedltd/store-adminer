﻿using StoreAdminer.Data.Models;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace StoreAdminer.Data.Services {
    public class UserService {

        private static readonly string REFRESH_TOKEN_COOKIE = "refreshToken";

        private static UserService _instance;

        private readonly CallFactoryProvider callFactory = CallFactoryProvider.GetInstance();

        private JwtToken _accessToken;
        public JwtToken AccessToken {
            set {
                _accessToken = value;
                AuthenticationHeaderValue header = null;
                if (value != null) {
                    header = new AuthenticationHeaderValue("Bearer", value.Token);
                }
                callFactory.Headers.Authorization = header;
            }
            get {
                return _accessToken;
            }
        }

        private readonly Hashtable _cachedUsers = new Hashtable();
        private readonly Hashtable _cachedTokens = new Hashtable();

        public static UserService GetInstance() {
            return _instance ?? (_instance = new UserService());
        }

        private UserService() {
            callFactory.RequestInterceptor = Intercept;
        }

        private async Task<HttpResponseMessage> Intercept(Request request) {

            if (AccessToken != null && AccessToken.IsExpired()) {
                AccessToken = null;
                await RefreshToken();
            }
            return await request.Invoke();
        }

        public async Task<bool> IsLoggedIn() {
            if (AccessToken != null) {
                return true;
            }

            var cookies = callFactory.GetCookies();
            if (!cookies.ContainsKey(REFRESH_TOKEN_COOKIE)) {
                return false;
            }

            try {
                await RefreshToken();
            } catch (RefreshTokenExpiredException) {
                return false;
            }

            return true;
        }

        public async Task RefreshToken() {
            try {
                AccessToken  = await callFactory.PostRequestAsync<JwtToken>(Endpoints.REFRESH_TOKEN);
            } catch (HttpError) {
                RemoveRefreshToken();
                throw new RefreshTokenExpiredException();
            }
        }

        public async Task RevokeRefreshToken() {
            await callFactory.PostRequestAsync(Endpoints.REVOKE_TOKEN);
            RemoveRefreshToken();
        }

        public async Task RevokeRefreshToken(RefreshToken token) {
            await callFactory.PostRequestAsync(Endpoints.REVOKE_TOKEN, token.ToJsonContent());
        }

        public async Task Login(string login, string password) {
            var query = new NameValueCollection() {
                { "isAdmin", "true" }
            };
            var body = new NameValueCollection() {
                { "login", login },
                { "password", password }
            };

            AccessToken  = await callFactory.PostRequestAsync<JwtToken>(Endpoints.LOGIN, query, body);
        }

        public async Task Logout() {
            await RevokeRefreshToken();
            AccessToken = null;
        }

        public async Task<User> GetProfile() {
            return await callFactory.GetRequestAsync<User>(Endpoints.PROFILE);
        }

        public async Task<List<User>> GetUsers() {
            var users = await callFactory.GetRequestAsync<List<User>>(Endpoints.USERS);
            foreach (User user in users) {
                _cachedUsers[user.Id] = user;
            }
            return users;
        }

        public User GetUser(int id) {
            return (User) _cachedUsers[id];
        }

        public async Task<List<RefreshToken>> GetTokens(int userId, bool isDirty = false) {
            if (!_cachedTokens.Contains(userId) || isDirty) {
                var query = new NameValueCollection() {
                    { "userId", userId.ToString() }
                };
                _cachedTokens[userId] = await callFactory.GetRequestAsync<List<RefreshToken>>(Endpoints.TOKENS, query);
            }
            return (List<RefreshToken>) _cachedTokens[userId];
        }

        public async Task BlockUser(int userId) {
                var query = new NameValueCollection() {
                    { "userId", userId.ToString() }
                };
                await callFactory.PostRequestAsync(Endpoints.BLOCK_USER, query);
        }

        public async Task UnblockUser(int userId) {
                var query = new NameValueCollection() {
                    { "userId", userId.ToString() }
                };
                await callFactory.PostRequestAsync(Endpoints.UNBLOCK_USER, query);
        }

        private void RemoveRefreshToken() {
            var cookies = callFactory.GetCookies();
            if (cookies.TryGetValue(REFRESH_TOKEN_COOKIE, out Cookie tokenCookie)) {
                tokenCookie.Expired = true;
            }
        }
    }
}
