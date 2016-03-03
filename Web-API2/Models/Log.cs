using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB_API2.Models
{
    public class Log
    {
        public int Id { get; set; }
        [Required]
        public string titel { get; set; }
        public string auteur { get; set; }
        public DateTime gemaakt { get; set; }
        public string verhaal { get;  set; }
        public bool verwijderd { get; set; }
    }
}