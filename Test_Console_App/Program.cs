// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Text.Json;
using BenchmarkDotNet.Running;
using Test_Console_App;
using Test_Console_App.Models;

var summary = BenchmarkRunner.Run<BenchmarkTestClass>();
Console.ReadLine();




