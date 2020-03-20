namespace Nodes
{
    public class Node
    {
        protected object Input = new object();
        protected object Output = new object();
        private Node _linked;
        
        public object Call()
        {
            Output = Compute();
            _linked?.Call(Output);
            return Output;
        }

        public void Call(object input)
        {
            Input = input;
            Call();
        }

        protected virtual object Compute()
        {
            return null;
        }
        
        /// <summary>
        /// links this Output to n Input if is note already linked
        /// </summary>
        public bool Link(Node n)
        {
            if (_linked != null)
                return false;
            
            _linked = n;
            return true;
        }

        public void ForcedLink(Node n)
        {
            _linked = n;
        }
    }
}