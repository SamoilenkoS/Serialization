namespace Serialization
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
            => $"{nameof(FirstName)}={FirstName}, {nameof(LastName)}={LastName}";
    }
}