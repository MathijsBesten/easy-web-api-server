using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API2.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string name { get; set; }
        public Byte[] file { get; set; }
        public int byteCount { get; set; }
        public string hash { get; set; }
    }
}