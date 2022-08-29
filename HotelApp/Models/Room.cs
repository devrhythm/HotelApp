using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Models
{
  internal abstract class Room : IRoom
  {
    private readonly Guid _hotelId;
    private readonly int _floorNumber;
    private readonly Guid _roomId;
    private readonly string _roomName;
    private readonly RoomType _roomType;
    protected RoomStatus _roomStatus;

    public Room(Guid hotelId, int floorNumber, string roomName, RoomType roomType)
    {
      _roomId = Guid.NewGuid();
      _hotelId = hotelId;
      _floorNumber = floorNumber;
      _roomName = roomName;
      _roomType = roomType;
    }

    public Guid HotelId => _hotelId;

    public int FloorNumber => _floorNumber;

    public Guid RoomId => _roomId;

    public string RoomName => _roomName;

    public RoomStatus RoomStatus => _roomStatus;

    public RoomType RoomType => _roomType;

    public virtual ICollection<Guest> Guests => new HashSet<Guest>();

    public virtual ICollection<KeycardAllowCheckinRoom> KeycardAllowAccessRooms => new HashSet<KeycardAllowCheckinRoom>();
  }
}
