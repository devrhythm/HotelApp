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
    protected bool _isRoomAvailable;

    public Room(Guid hotelId, int floorNumber, string roomName, RoomType roomType)
    {
      _roomId = Guid.NewGuid();
      _hotelId = hotelId;
      _floorNumber = floorNumber;
      _roomName = roomName;
      _roomType = roomType;
      _isRoomAvailable = true;
    }

    public Guid HotelId => _hotelId;

    public int FloorNumber => _floorNumber;

    public Guid RoomId => _roomId;

    public string RoomName => _roomName;

    public bool IsRoomAvailable => _isRoomAvailable;

    public RoomType RoomType => _roomType;

    public virtual ICollection<Guest> Guests => new HashSet<Guest>();

    public virtual ICollection<RoomKeycardAccess> RoomKeycardAccesses => new HashSet<RoomKeycardAccess>();
  }
}
