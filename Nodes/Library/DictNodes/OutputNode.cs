using System;

namespace Nodes.Library.DictNodes
{
    public class OutputNode: DictNode
    {
        protected override void Compute()
        {
            Console.WriteLine(Inputs["Input"]);
        }
    }
}