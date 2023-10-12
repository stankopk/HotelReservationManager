using System.ComponentModel.DataAnnotations;

namespace HotelReservationManager.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }
        public bool IsAvaliable { get; set; }

        public Room()
        {

        }
    }
}
