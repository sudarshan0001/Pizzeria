﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Entities
{
    public class Role : IdentityRole<int>
    {
        // TO DO:
        public string Description { get; set; }
    }
}
