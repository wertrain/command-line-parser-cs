namespace CommandLineParser
{
    class Program
    {
        class Options
        {
            [Option('t', "text", Required = false, HelpText = "Sample text")]
            public string Text { get; set; }
        }

        static void Main(string[] args)
        {
            var result = Parser.Parse<Options>(args);

            if (result.Tag == ParserResultType.Parsed)
            {
                System.Console.WriteLine("text: {0}", result.Value.Text);
            }
        }
    }
}
