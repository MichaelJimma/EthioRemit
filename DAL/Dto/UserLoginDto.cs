﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Dto
{
    public class UserLoginDto
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
