namespace HotelApp.Models
{
  internal class ContactPerson : Guest
  {
    public ContactPerson(string name, int age, List<string> phoneNumbers) : base(name, age, phoneNumbers)
    {
      IsContactPerson = true;
    }
    public ContactPerson(string name, int age, string phone) : this(name, age, new List<string>() { name })
    {

    }
  }
}