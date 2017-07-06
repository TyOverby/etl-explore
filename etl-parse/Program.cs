using System;
using Microsoft.Diagnostics.Tracing.Parsers;
using Microsoft.Diagnostics.Tracing;

namespace etl_explore
{
    class Program
    {
        static void Main(string[] args)
        {
            var location = "";
            using(var source = new ETWTraceEventSource(location)) {
                var parser = new DynamicTraceEventParser(source);
                parser.All += data => {
                    Console.WriteLine($"{data.EventName}");
                };
            }
        }
    }
}
