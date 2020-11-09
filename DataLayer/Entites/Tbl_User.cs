using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entites {
    public class Tbl_User {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Address { get; set; }
        public string Codemeli { get; set; }
        public string image { get; set; }
        public string FileName { get; set; }
        public string VideoName { get; set; }
    }
}