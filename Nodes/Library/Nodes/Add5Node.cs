namespace Nodes.Library.Nodes
{
    public class Add5Node: Node
    {
        protected override object Compute()
        {
            return (int)Input + 5;
        }
    }
}