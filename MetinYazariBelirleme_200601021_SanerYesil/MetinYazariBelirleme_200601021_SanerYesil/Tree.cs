using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme_200601021_SanerYesil
{
    internal class Tree
    {
        delegate void TreeVisitor<T>(T nodeData);

        class NTree<T>
        {
            private T data;
            private LinkedList<NTree<T>> children;

            public NTree(T data)
            {
                this.data = data;
                children = new LinkedList<NTree<T>>();
            }

            public void AddChild(T data)
            {
                children.AddFirst(new NTree<T>(data));
            }

            public NTree<T> GetChild(int i)
            {
                foreach (NTree<T> n in children)
                    if (--i == 0)
                        return n;
                return null;
            }

            public void Traverse(NTree<T> node, TreeVisitor<T> visitor)
            {
                visitor(node.data);
                foreach (NTree<T> kid in node.children)
                    Traverse(kid, visitor);
            }
        }
    }
}
