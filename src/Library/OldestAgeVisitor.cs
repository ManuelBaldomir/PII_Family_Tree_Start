namespace Library
{
    public class OldestAgeVisitor : Visitor <Person>
    {
        public int oldestAge {get; set;} = 0;

        public override void Visit(Node<Person> nodeToVisit)
        {
            if (nodeToVisit.t.age > oldestAge)
            {
                oldestAge = nodeToVisit.t.age;
            }
            foreach (Node<Person> childNode in nodeToVisit.Children)
            {
                childNode.Accept(this);
            }
        }
    }
}