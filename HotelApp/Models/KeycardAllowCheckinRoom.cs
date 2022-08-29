namespace HotelApp.Models
{
  internal class KeycardAllowCheckinRoom : Keycard
  {
    public Guid RoomId { get; }

    public KeycardAllowCheckinRoom(Guid roomId) : base()
    {
      RoomId = roomId;
    }
  }
}