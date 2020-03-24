using System;

namespace Nodes.Library.Nodes
{
    public class InputNode: Node
    {
        protected override object Compute()
        {
            return Console.ReadLine();
        }
    }
}