using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DanielPadua.ProtobufExampleCsharp.Contracts;
using McMaster.Extensions.CommandLineUtils;

namespace DanielPadua.ProtobufExampleCsharp
{
    [Command(Name = "DanielPadua.ProtobufExampleCsharp", Description = "Protobuf example application by danielpadua")]
    [HelpOption("-h|--help")]
    public class Program
    {
        public static void Main(string[] args) => CommandLineApplication.Execute<Program>(args);

        [Option("-i|--inputPath", Description = "Input directory path of protobuf file generated by protobuf-example-java WITHOUT file name")]
        [Required]
        private string InputPath { get; }

        private void OnExecute()
        {
            var fullpath = string.Concat(InputPath, Path.DirectorySeparatorChar, "protobuf-customer");
            using var inputStream = File.OpenRead(fullpath);
            Customer c = Customer.Parser.ParseFrom(inputStream);
            Console.WriteLine("Customer from protobuf-example-java:");
            Console.WriteLine(c.ToString());
        }
    }
}