namespace HotelApp.Models
{
  internal interface IRoom
  {
    Guid HotelId { get; }
    int FloorNumber { get; }
    Guid RoomId { get; }
    string RoomName { get; }
    bool IsRoomAvailable { get; }
    RoomType RoomType { get; }
    ICollection<Guest> Guests { get; }
    ICollection<RoomKeycardAccess> RoomKeycardAccesses { get; }
  }
}
