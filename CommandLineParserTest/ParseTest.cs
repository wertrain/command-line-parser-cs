using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CommandLineParser;

namespace CommandLineParserTest
{

    [TestClass]
    public class ParseTest
    {
        class Options
        {
            [Option('t', "string", Required = false, HelpText = "String Value")]
            public string Text { get; set; }
            [Option('l', "long", Required = false, HelpText = "Long Value")]
            public long LongValue { get; set; }
            [Option('i', "int", Required = false, HelpText = "Int Value")]
            public int IntValue { get; set; }
        }

        [TestMethod]
        public void TestParse_ErrorParamOverflow()
        {
            var args = new List<string>();
            args.Add("--int");
            args.Add(long.MaxValue.ToString());
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.NotParsed);
            Assert.AreEqual(0, result.Value.IntValue);
        }

        [TestMethod]
        public void TestParse_ErrorNotExistsOption()
        {
            var args = new List<string>();
            args.Add("--t");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreNotEqual("TestText", result.Value.Text);
        }

        [TestMethod]
        public void TestParse_ErrorWrongParam()
        {
            var args = new List<string>();
            args.Add("--int");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.NotParsed);
            Assert.AreNotEqual("int", result.Value.IntValue);
        }
    }
}
