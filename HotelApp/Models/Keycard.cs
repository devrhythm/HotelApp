namespace HotelApp.Models
{
  internal class Keycard
  {
    public Guid KeycardId { get; }

    public Keycard()
    {
      KeycardId = Guid.NewGuid();
    }
  }
}