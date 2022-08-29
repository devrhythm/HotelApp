namespace HotelApp.Models
{
  internal class Keycard
  {
    public Guid KeycardId { get; }

    public Keycard(Guid keycardId)
    {
      KeycardId = keycardId;
    }

    public Keycard() : this(Guid.NewGuid())
    {

    }
  }
}