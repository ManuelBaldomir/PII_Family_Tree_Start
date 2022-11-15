namespace Library
{
    public class AgeSumVisitor : Visitor <Person>
    {
        public int ageTotal {get; set;} = 0;

        public override void Visit(Node<Person> nodeToVisit)
        {
            ageTotal += nodeToVisit.t.age;
            foreach (Node<Person> childNode in nodeToVisit.Children)
            {
                childNode.Accept(this);
            }
            //System.Console.WriteLine($"Suma de edades actual = {ageTotal}");
            
        }
    }
}