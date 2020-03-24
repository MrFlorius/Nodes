using System;

namespace Nodes.Library.DictNodes
{
    public class InputNode: DictNode
    {
        protected override void Compute()
        {
            Outputs["Output"] = Console.ReadLine();
        }
    }
}