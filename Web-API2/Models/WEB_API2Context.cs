﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WEB_API2.Models
{
    public class WEB_API2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WEB_API2Context() : base("name=WEB_API2Context")
        {
        }

        public System.Data.Entity.DbSet<WEB_API2.Models.Game> Games { get; set; }

        public System.Data.Entity.DbSet<WEB_API2.Models.Log> Logs { get; set; }

        public System.Data.Entity.DbSet<Web_API2.Models.Image> Images { get; set; }
    }
}
