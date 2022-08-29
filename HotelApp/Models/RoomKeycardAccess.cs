namespace HotelApp.Models
{
  internal class RoomKeycardAccess : Keycard
  {
    public Guid RoomId { get; }

    public RoomKeycardAccess(Guid keycardId, Guid roomId) : base(keycardId)
    {
      RoomId = roomId;
    }

    public RoomKeycardAccess(Keycard keycard, Guid roomId) : this(keycard.KeycardId, roomId)
    {

    }
  }
}