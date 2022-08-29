namespace HotelApp.Models
{
  internal interface IRoom
  {
    Guid HotelId { get; }
    int FloorNumber { get; }
    Guid RoomId { get; }
    string RoomName { get; }
    RoomStatus RoomStatus { get; }
    RoomType RoomType { get; }
    ICollection<Guest> Guests { get; }
    ICollection<KeycardAllowCheckinRoom> KeycardAllowAccessRooms { get; }
  }
}
