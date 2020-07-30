# command-line-parser-cs

## Overview

**CommandLineParser** is a simple argument parsing code.  
It works with a single file, there is no license in the code, and it is free for anyone to use.

## Example

```cs
using CommandLineParser;

class Program
{
    class Options
    {
        [Option('s', "string", Required = false, HelpText = "String value")]
        public string Text { get; set; }
        [Option('i', "int", Required = false, HelpText = "Int value")]
        public int IntValue { get; set; }
        [Option('d', "double", Required = false, HelpText = "Double value")]
        public double DoubleValue { get; set; }
    }

    static void Main(string[] args)
    {
        var result = Parser.Parse<Options>(args);

        if (result.Tag == ParserResultType.Parsed)
        {
            System.Console.WriteLine("string value: {0}", result.Value.Text);
            System.Console.WriteLine("int value: {0}", result.Value.IntValue);
            System.Console.WriteLine("double value: {0}", result.Value.DoubleValue);
        }
    }
}
```

```shell
> sample.exe -s hello --int 100 -d 123.456
> string value: hello
> int value: 100
> double value: 123.456
```

## Where is the source code?

Download directly here\!  
https://raw.githubusercontent.com/wertrain/command-line-parser-cs/master/CommandLineParser/CommandLineParser.cs
