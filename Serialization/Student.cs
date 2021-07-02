namespace Serialization
{
    public class Student
    {
        private int _age;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get => _age;//
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        public override string ToString()
            => $"{nameof(FirstName)}={FirstName}, {nameof(LastName)}={LastName}, {nameof(Age)}={Age}";
    }
}