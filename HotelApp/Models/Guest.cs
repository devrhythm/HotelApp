namespace HotelApp.Models
{
  internal class Guest
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsContactPerson { get; protected set; }
    public ICollection<string> PhoneNumbers { get; } = new HashSet<string>();

    public Guest(string name, int age, List<string> phoneNumbers)
    {
      Id = Guid.NewGuid();
      Name = name;
      Age = age;
      IsContactPerson = false;
      phoneNumbers.ForEach(phoneNumber => PhoneNumbers.Add(phoneNumber));
    }

    public Guest(string name, int age, string phoneNumber) : this(name, age, new List<string> { phoneNumber })
    {

    }
  }
}