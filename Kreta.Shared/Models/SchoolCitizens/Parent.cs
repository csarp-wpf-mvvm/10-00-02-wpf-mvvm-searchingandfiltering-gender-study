
namespace Kreta.Shared.Models.SchoolCitizens
{
    public class Parent : IDbEntity<Parent>
    {
        public Parent()
        {
            Id = Guid.Empty;
            FirstName = string.Empty;
            LastName = string.Empty; 
            IsWoman = false;
            Address = string.Empty;
        }
        public Parent(Guid id, string firstName, string lastName, bool isWoman, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            IsWoman = isWoman;
            Address = address;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsWoman { get; set; }
        public string Address { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Salutaion => IsWoman ? "hölgy" : "úr";

        public override string ToString()
        {
            return $"{LastName} {FirstName} {Address}";
        }
    }
}
