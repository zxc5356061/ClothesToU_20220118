﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesToU.Site.Models.Entities
{
    public class RegisterEntity
    {
        public string Account { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public string ConfirmCode { get; set; }
        
    }
}