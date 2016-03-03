using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WEB_API2.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }
        public string description { get; set; }
    }
}