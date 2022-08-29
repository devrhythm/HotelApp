namespace HotelApp.Models
{
  internal class InRoomFacility : HotelFacility
  {
    public Guid RoomId { get; }

    public InRoomFacility(Guid hotelId, string facilityName, int facilityAmount) : base(hotelId, facilityName, facilityAmount)
    {
    }

    public InRoomFacility(string facilityName, int facilityAmount, Guid hotelId, Guid roomId) : this(hotelId, facilityName, facilityAmount)
    {
      RoomId = roomId;
    }
  }
}
