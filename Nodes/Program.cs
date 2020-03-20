using System;
using System.Collections.Generic;
using Nodes.Catalog;

namespace Nodes
{
    static class Program
    {
        static void SimpleNodes()
        {
            InputNode inputNode = new InputNode();
            OutputNode outputNode = new OutputNode();

            inputNode.Link(outputNode);
            inputNode.Call();
        }

        static void Main(string[] args)
        {
            // SimpleNodes();
            PerformanceBenchmark.Benchmark.Test();
        }
    }
}