namespace HotelApp.Models
{
  internal static class HotelSystem
  {
    public static RoomKeycardAccess AssignRoom(this Keycard keycard, Guid roomId)
    {
      return new RoomKeycardAccess(keycard, roomId);
    }
  }
}
