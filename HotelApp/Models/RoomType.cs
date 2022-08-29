namespace HotelApp.Models
{
  internal class RoomType
  {
    public string Name { get; }
    public int MaxGuestAMount { get; }
    public ICollection<InRoomFacility> Commudities { get; private set; }

    public RoomType(string typeName, int maxGuestAMount, ICollection<InRoomFacility> commudities)
    {
      Name = typeName;
      MaxGuestAMount = maxGuestAMount;
      Commudities = new HashSet<InRoomFacility>(commudities);
    }
  }
}
