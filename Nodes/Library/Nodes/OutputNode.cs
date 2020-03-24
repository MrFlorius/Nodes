using System;

namespace Nodes.Library.Nodes
{
    public class OutputNode: Node
    {
        protected override object Compute()
        {
            Console.WriteLine(Input);
            return base.Compute();
        }
    }
}