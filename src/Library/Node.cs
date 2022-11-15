using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        private List<Node<T>> children = new List<Node<T>>();

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T t)
        {
            this.t = t;
        }

        public T t {get;}

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        
        public void Accept(Visitor<T> visitor)
        {
            visitor.Visit(this);
        }
    }
}
