namespace Nodes.Catalog
{
    public class Add5Node: Node
    {
        protected override object Compute()
        {
            return (int)Input + 5;
        }
    }
}