using System;
using System.Collections.Generic;
using System.Linq;

namespace Nodes
{
    public class DictNode
    {
        protected class FromTo
        {
            public string From;
            public string To;

            public FromTo(string from, string to)
            {
                From = from;
                To = to;
            }
        }
        
        protected Dictionary<string, object> Inputs = new Dictionary<string, object>();
        protected Dictionary<string, object> Outputs = new Dictionary<string, object>();
        
        protected Dictionary<DictNode, FromTo> Links = new Dictionary<DictNode,FromTo>();

        public void Link(DictNode other, string from, string to)
        {
            Links[other] = new FromTo(from, to);
        }

        protected virtual void Compute()
        {
            
        }

        public void Call()
        {
            Compute();
            foreach (var lp in Links)
                lp.Key.Inputs[lp.Value.To] = Outputs[lp.Value.From];

            foreach (var linkedNode in Links.Keys.Distinct())
                linkedNode.Call();
        }
    }
}