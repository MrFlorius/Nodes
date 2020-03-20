using System;

namespace Nodes.Catalog
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