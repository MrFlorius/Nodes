using System;
using System.Collections.Generic;
using Nodes.Library.DictNodes;

namespace Nodes
{
    static class Program
    {
        // static void SimpleNodes()
        // {
        //     InputNode inputNode = new InputNode();
        //     OutputNode outputNode = new OutputNode();
        //
        //     inputNode.Link(outputNode);
        //     inputNode.Call();
        // }

        static void DictionaryNodes()
        {
            InputNode inputNode = new InputNode();
            OutputNode outputNode = new OutputNode();
            
            inputNode.Link(outputNode, "Output", "Input");
            inputNode.Call();
        }

        static void Main(string[] args)
        {
            DictionaryNodes();
            // SimpleNodes();
            // PerformanceBenchmark.Benchmark.Test();
        }
    }
}