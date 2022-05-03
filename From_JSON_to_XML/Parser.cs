using AngleSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace From_JSON_to_XML
{
    class Parser
    {
        AngleSharp.IConfiguration config;
        AngleSharp.Dom.IDocument document;

        public List<Post> Parse(string address)
        {
            Connect().Wait();

            var postsString = (document.QuerySelector("pre").InnerHtml);
            var posts = JsonConvert.DeserializeObject<List<Post>>(postsString);

            async Task Connect()
            {
                config = Configuration.Default.WithDefaultLoader();
                document = await BrowsingContext.New(config).OpenAsync(address);
            }

            return posts;
        }
    }
}
