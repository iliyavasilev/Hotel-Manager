using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel_Reservation_Manager.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public double PriceAdults { get; set; }
        public double PriceKids { get; set; }

        public string[] Types => new string[] {"Две единични легла", "Апартамент", "Стая с двойно легло",
        "Пентхаус", "Мезонет"};

        //[NotMapped]
        //public virtual List<Room> Rooms => new ApplicationDbContext().Rooms.ToList();

        public virtual List<RoomUsage> Usages => 
            new ApplicationDbContext().RoomUsages.ToList().Where(x => x.RoomId == Id).ToList();

    }
}