using System;
using System.Collections.Generic;

namespace LinkedListImplementation
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // Declare an indexer
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
        // Indexer instead of setter and getter methods
        // Like the following
        public void SetItem(string key, string value)
        {
            _dictionary[key] = value;
        }
        public string GetItem(string key)
        {
            return _dictionary[key];
        }
    }
}
