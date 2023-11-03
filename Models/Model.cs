using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace user_service.Models
{
    public partial class Model
    {
        public string RegName { get; set; }
        public string RegPhone { get; set; }
        public string RegDest { get; set; }
        public string Email { get; set; }
        public string  OTP { get; set; }

        public string emailforval { get; set; }
        public string emailforlogin { get; set; }
        public string enteredotp { get; set; }

    }
}