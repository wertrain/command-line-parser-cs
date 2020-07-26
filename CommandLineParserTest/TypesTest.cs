using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CommandLineParser;

namespace CommandLineParserTest
{
    [TestClass]
    public class TypesTest
    {
        class Options
        {
            [Option('t', "string", Required = false, HelpText = "String Value")]
            public string Text { get; set; }
            [Option('l', "long", Required = false, HelpText = "Long Value")]
            public long LongValue { get; set; }
            [Option('i', "int", Required = false, HelpText = "Int Value")]
            public int IntValue { get; set; }
            [Option('s', "short", Required = false, HelpText = "Short Value")]
            public short ShortValue { get; set; }
            [Option('b', "byte", Required = false, HelpText = "Byte Value")]
            public byte ByteValue { get; set; }
            [Option('c', "char", Required = false, HelpText = "Char Value")]
            public char CharValue { get; set; }
            [Option('o', "sbyte", Required = false, HelpText = "SByte Value")]
            public sbyte SByteValue { get; set; }
            [Option('p', "ulong", Required = false, HelpText = "ULong Value")]
            public ulong ULongValue { get; set; }
            [Option('q', "uint", Required = false, HelpText = "UInt Value")]
            public uint UIntValue { get; set; }
            [Option('r', "ushort", Required = false, HelpText = "UShort Value")]
            public ushort UShortValue { get; set; }
            [Option('f', "float", Required = false, HelpText = "Float Value")]
            public float FloatValue { get; set; }
            [Option('d', "double", Required = false, HelpText = "Double Value")]
            public double DoubleValue { get; set; }
            [Option('m', "decimal", Required = false, HelpText = "Decimal Value")]
            public decimal DecimalValue { get; set; }
            [Option('w', "bool", Required = false, HelpText = "Boolean Value")]
            public bool BooleanValue { get; set; }

        }

        [TestMethod]
        public void TestLongName_TypeString()
        {
            var args = new List<string>();
            args.Add("--string");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual("TestText", result.Value.Text);
        }

        [TestMethod]
        public void TestLongName_TypeLong()
        {
            var args = new List<string>();
            args.Add("--long");
            args.Add("1234567890123456789");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(1234567890123456789, result.Value.LongValue);
        }

        [TestMethod]
        public void TestLongName_TypeInt()
        {
            var args = new List<string>();
            args.Add("--int");
            args.Add("123456789");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(123456789, result.Value.IntValue);
        }

        [TestMethod]
        public void TestLongName_TypeShort()
        {
            var args = new List<string>();
            args.Add("--short");
            args.Add("12345");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(12345, result.Value.ShortValue);
        }

        [TestMethod]
        public void TestLongName_TypeByte()
        {
            var args = new List<string>();
            args.Add("--byte");
            args.Add("123");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(123, result.Value.ByteValue);
        }

        [TestMethod]
        public void TestLongName_TypeChar()
        {
            var args = new List<string>();
            args.Add("--char");
            args.Add("a");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual('a', result.Value.CharValue);
        }

        [TestMethod]
        public void TestLongName_TypeSByte()
        {
            var args = new List<string>();
            args.Add("--sbyte");
            args.Add("12");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(12, result.Value.SByteValue);
        }

        [TestMethod]
        public void TestLongName_TypeULong()
        {
            var args = new List<string>();
            args.Add("--ulong");
            args.Add("1234567890123456789");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(1234567890123456789u, result.Value.ULongValue);
        }

        [TestMethod]
        public void TestLongName_TypeUInt()
        {
            var args = new List<string>();
            args.Add("--uint");
            args.Add("123456789");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(123456789u, result.Value.UIntValue);
        }

        [TestMethod]
        public void TestLongName_TypeUShort()
        {
            var args = new List<string>();
            args.Add("--ushort");
            args.Add("12345");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(12345u, result.Value.UShortValue);
        }

        [TestMethod]
        public void TestLongName_TypeFloat()
        {
            var args = new List<string>();
            args.Add("--float");
            args.Add("1.23456");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(1.23456f, result.Value.FloatValue);
        }

        [TestMethod]
        public void TestLongName_TypeDouble()
        {
            var args = new List<string>();
            args.Add("--double");
            args.Add("123456.789");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(123456.789, result.Value.DoubleValue);
        }

        [TestMethod]
        public void TestLongName_TypeDecimal()
        {
            var args = new List<string>();
            args.Add("--decimal");
            args.Add("123456");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(123456, result.Value.DecimalValue);
        }

        [TestMethod]
        public void TestLongName_TypeBoolean()
        {
            var args = new List<string>();
            args.Add("--bool");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.IsTrue(result.Value.BooleanValue);
        }

        [TestMethod]
        public void TestLongName_TypeBooleanFalse()
        {
            var args = new List<string>();
            args.Add("--bool");
            args.Add("false");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.IsFalse(result.Value.BooleanValue);
        }

        [TestMethod]
        public void TestShortName_TypeString()
        {
            var args = new List<string>();
            args.Add("-t");
            args.Add("TestText");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual("TestText", result.Value.Text);
        }

        [TestMethod]
        public void TestShortName_TypeLong()
        {
            var args = new List<string>();
            args.Add("-l");
            args.Add("1234567890123456789");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(1234567890123456789, result.Value.LongValue);
        }

        [TestMethod]
        public void TestShortName_TypeInt()
        {
            var args = new List<string>();
            args.Add("-i");
            args.Add("123456789");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(123456789, result.Value.IntValue);
        }

        [TestMethod]
        public void TestShortName_TypeShort()
        {
            var args = new List<string>();
            args.Add("-s");
            args.Add("12345");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(12345, result.Value.ShortValue);
        }

        [TestMethod]
        public void TestShortName_TypeByte()
        {
            var args = new List<string>();
            args.Add("-b");
            args.Add("123");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(123, result.Value.ByteValue);
        }

        [TestMethod]
        public void TestShortName_TypeChar()
        {
            var args = new List<string>();
            args.Add("-c");
            args.Add("a");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual('a', result.Value.CharValue);
        }

        [TestMethod]
        public void TestShortName_TypeSByte()
        {
            var args = new List<string>();
            args.Add("-o");
            args.Add("12");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(12, result.Value.SByteValue);
        }

        [TestMethod]
        public void TestShortName_TypeULong()
        {
            var args = new List<string>();
            args.Add("-p");
            args.Add("1234567890123456789");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(1234567890123456789u, result.Value.ULongValue);
        }

        [TestMethod]
        public void TestShortName_TypeUInt()
        {
            var args = new List<string>();
            args.Add("-q");
            args.Add("123456789");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(123456789u, result.Value.UIntValue);
        }

        [TestMethod]
        public void TestShortName_TypeUShort()
        {
            var args = new List<string>();
            args.Add("-r");
            args.Add("12345");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(12345u, result.Value.UShortValue);
        }

        [TestMethod]
        public void TestShortName_TypeFloat()
        {
            var args = new List<string>();
            args.Add("-f");
            args.Add("1.23456");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(1.23456f, result.Value.FloatValue);
        }

        [TestMethod]
        public void TestShortName_TypeDouble()
        {
            var args = new List<string>();
            args.Add("-d");
            args.Add("123456.789");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(123456.789, result.Value.DoubleValue);
        }

        [TestMethod]
        public void TestShortName_TypeDecimal()
        {
            var args = new List<string>();
            args.Add("-m");
            args.Add("123456");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.AreEqual(123456, result.Value.DecimalValue);
        }

        [TestMethod]
        public void TestShortName_TypeBoolean()
        {
            var args = new List<string>();
            args.Add("-w");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.IsTrue(result.Value.BooleanValue);
        }

        [TestMethod]
        public void TestShortName_TypeBooleanFalse()
        {
            var args = new List<string>();
            args.Add("-w");
            args.Add("false");
            var result = Parser.Parse<Options>(args);
            Assert.IsTrue(result.Tag == ParserResultType.Parsed);
            Assert.IsFalse(result.Value.BooleanValue);
        }
    }
}
