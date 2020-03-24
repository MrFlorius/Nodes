using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Nodes.Library.Nodes;

namespace Nodes.PerformanceBenchmark
{
    public class Benchmark
    {
        public static int Iterations = 10_000_000;
        
        public static void Test()
        {
            Stopwatch nodes = Stopwatch.StartNew();
            {
                Add5Node add5Node = new Add5Node();
                ValueNode input = new ValueNode(10);
                input.Link(add5Node);
                for (int i = 0; i < Iterations; i++)
                {
                    input.Call();
                }
            } nodes.Stop();
            
            Console.WriteLine($"Nodes: {nodes.ElapsedMilliseconds}ms * {Iterations}");
            
            Stopwatch simple = Stopwatch.StartNew();
            {
                for (int i = 0; i < Iterations; i++)
                {
                    int a;
                    a = 10 + 5;
                }
            } simple.Stop();
            
            Console.WriteLine($"Simple: {simple.ElapsedMilliseconds}ms * {Iterations}");
        }
    }
}