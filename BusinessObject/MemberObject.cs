﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MemberObject
    {
        public int MemberId { get; set; }
        public string Email { get; set; } = null!;
        public string? CompanyName { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string Password { get; set; } = null!;
    }
}
