namespace Library
{
    public class LongestNameVisitor : Visitor <Person>
    {
        public string longestName {get; set;} = "";

        public override void Visit(Node<Person> nodeToVisit)
        {
            if (nodeToVisit.t.name.Length > longestName.Length)
            {
                longestName = nodeToVisit.t.name;
            }
            foreach (Node<Person> childNode in nodeToVisit.Children)
            {
                childNode.Accept(this);
            }
        }
    }
}