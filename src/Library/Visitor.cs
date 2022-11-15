using System;
using System.Text;

namespace Library
{
    public abstract class Visitor <T>
    {
        
        

        public abstract void Visit(Node<T> nodeToVisit);

        
        //public abstract void VisitPerson(Person personToVisit);
        
    }
}