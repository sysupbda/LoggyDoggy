// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Serilog;



var logger = new LoggerConfiguration()
   .WriteTo.Console(outputTemplate: "[{ElasticApmTraceId} {ElasticApmTransactionId} {Message:lj} {NewLine}{Exception}")
   .CreateLogger();



Console.WriteLine("Hello, World!");
var src = new ActivitySource("Test");
using var activity1 = src.StartActivity(nameof(Sample), ActivityKind.Server);
logger.Information("Hello, World!");



Thread.Sleep(100);

internal class Sample
{
}