namespace Nodes
{
    public class ValueNode: Node
    {
        public ValueNode(object val)
        {
            Output = val;
        }

        protected override object Compute()
        {
            return Output;
        }
    }
}