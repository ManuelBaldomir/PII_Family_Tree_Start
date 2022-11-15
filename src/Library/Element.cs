namespace Library
{
    public abstract class Element
    {
        public abstract void Accept(Visitor<Person> visitor);
    }
}