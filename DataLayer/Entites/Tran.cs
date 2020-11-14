
using System;
using System.ComponentModel.DataAnnotations;
namespace DataLayer.Entites {
    public class Tran {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Amount { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

    }
}