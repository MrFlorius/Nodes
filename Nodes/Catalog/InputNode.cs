using System;

namespace Nodes.Catalog
{
    public class InputNode: Node
    {
        protected override object Compute()
        {
            return Console.ReadLine();
        }
    }
}