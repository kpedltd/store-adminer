using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace StoreAdminer.Data
{
    public class CookieProvider
    {
        private static readonly string COOKIES_FILE = "cookies";

        private CookieContainer _cookieContainer;

        private static CookieProvider _instance;

        public static CookieProvider GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CookieProvider();
            }
            return _instance;
        }

        private CookieProvider()
        {
        }

        public Dictionary<string, Cookie> GetCookies()
        {
            return GetCookies(GetCookieContainer());
        }

        public CookieContainer GetCookieContainer()
        {
            if (_cookieContainer == null)
            {
                _cookieContainer = ReadCookiesFromDisk(COOKIES_FILE);
            }
            return _cookieContainer;
        }

        public void SaveCookieContainer()
        {
            WriteCookiesToDisk(COOKIES_FILE, GetCookieContainer());
        }

        private Dictionary<string, Cookie> GetCookies(CookieContainer container)
        {
            var cookies = new Dictionary<string, Cookie>();

            var table = (Hashtable)container.GetType().InvokeMember("m_domainTable",
                                                                    BindingFlags.NonPublic |
                                                                    BindingFlags.GetField |
                                                                    BindingFlags.Instance,
                                                                    null,
                                                                    container,
                                                                    new object[] { });

            foreach (var key in table.Keys)
            {
                string domain = key as string;

                if (domain == null)
                    continue;

                if (domain.StartsWith("."))
                    domain = domain.Substring(1);

                var address = string.Format("http://{0}/", domain);

                if (Uri.TryCreate(address, UriKind.RelativeOrAbsolute, out Uri uri) == false)
                    continue;

                foreach (Cookie cookie in container.GetCookies(uri))
                {
                    cookies.Add(cookie.Name, cookie);
                }
            }

            return cookies;
        }

        private static void WriteCookiesToDisk(string file, CookieContainer cookieJar)
        {
            using (Stream stream = File.Create(file))
            {
                try
                {
                    Console.Out.Write("Writing cookies to disk... ");
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, cookieJar);
                    Console.Out.WriteLine("Done.");
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine("Problem writing cookies to disk: " + e.GetType());
                }
            }
        }

        private static CookieContainer ReadCookiesFromDisk(string file)
        {
            try
            {
                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    Console.Out.Write("Reading cookies from disk... ");
                    BinaryFormatter formatter = new BinaryFormatter();
                    Console.Out.WriteLine("Done.");
                    return (CookieContainer)formatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Problem reading cookies from disk: " + e.GetType());
                return new CookieContainer();
            }
        }
    }
}