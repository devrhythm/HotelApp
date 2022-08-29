namespace HotelApp.Models
{
  internal class RoomKeycardAccess : Keycard
  {
    public Guid RoomId { get; }

    public RoomKeycardAccess(Guid roomId) : base()
    {
      RoomId = roomId;
    }
  }
}