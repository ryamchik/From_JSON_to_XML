namespace From_JSON_to_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = "https://jsonplaceholder.typicode.com/posts";
            Parser parser = new Parser();
            var posts = parser.Parse(address);
            Converter.ConvertToXML(posts);
        }
    }
}
