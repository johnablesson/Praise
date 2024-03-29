﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Praize.Contracts
{
    public class RegisterUserContract
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }


        public string Password { get; set; }


        public string FirstName { get; set; }


        public string MiddleName { get; set; }


        public string LastName { get; set; }


        public int RoleId { get; set; }

        public string Email { get; set; }

        public AddressContract CurrentAddress { get; set; }
        public AddressContract PermanentAddress { get; set; }

        public string PhoneNumber { get; set; }

        public DateTimeOffset? CreatedDate { get; set; }
    }
}
