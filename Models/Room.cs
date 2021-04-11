using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel_Reservation_Manager.Models
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public double PriceAdults { get; set; }
        [Required]
        public double PriceKids { get; set; }
        [Required, StringLength(3)]
        public string Number { get; set; }

        public string[] Types => new string[] {"Две единични легла", "Апартамент", "Стая с двойно легло",
        "Пентхаус", "Мезонет"};

        //[NotMapped]
        //public virtual List<Room> Rooms => new ApplicationDbContext().Rooms.ToList();

       //public virtual List<Reservations> Usages => 
       //    new ApplicationDbContext().RoomUsages.ToList().Where(x => x.RoomId == Id).ToList();

    }
}