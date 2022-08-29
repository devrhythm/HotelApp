using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Models
{
  internal class HotelFacility
  {
    public Guid HotelId { get; }
    public string FacilityName { get; }
    public int FacilityAmount { get; }

    public HotelFacility(Guid hotelId, string facilityName, int facilityAmount)
    {
      HotelId = hotelId;
      FacilityName = facilityName;
      FacilityAmount = facilityAmount;
    }


  }
}
