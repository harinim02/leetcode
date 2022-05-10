public class Codec
    {
        private readonly Dictionary<string, string> urlDictionary;
        public Codec()
        {
            urlDictionary = new Dictionary<string, string>();
        }
        
        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            var guid = Guid.NewGuid().ToString();
            urlDictionary.Add(guid, longUrl);
            return BuildUrl(guid).ToString();
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            var guid = GetGUID(shortUrl);
            urlDictionary.TryGetValue(guid, out var url);
            return url;
        }
        private Uri BuildUrl(string guid)
        {
            return new Uri("https://tinyurl/" + guid);
        }
        private string GetGUID(string url)
        {
            var uriBuilder = new UriBuilder(url);
            return uriBuilder.Path.Substring(1);
        }
    }

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));