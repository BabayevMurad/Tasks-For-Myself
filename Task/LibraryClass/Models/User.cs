namespace LibraryClass
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surnname { get; set; }

        public int Age { get; set; }

        public User()
        {
            Name = string.Empty;

            Surnname = string.Empty;

            Age = 0;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Surnname} {Age}";
        }
    }
}
