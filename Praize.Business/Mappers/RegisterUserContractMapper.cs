using Praize.Contracts;
using Praize.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praize.Business.Mappers
{
    public static class RegisterUserContractMapper
    {
        public static User AsUserEntity(this RegisterUserContract usr)
        {
            if(usr == null)
            {
                return null;
            }

            return new User() {
                UserName = usr.UserName,
                Email = usr.Email,
                FirstName = usr.FirstName,
                LastName = usr.LastName,
                MiddleName = usr.MiddleName,
                Password = usr.Password,
                RoleId = usr.RoleId,
            };
        }

        public static PhoneNumber AsPhoneNumberEntity(this RegisterUserContract usr, Guid userId)
        {
            if (usr == null)
            {
                return null;
            }

            return new PhoneNumber()
            {
               Number = usr.PhoneNumber,
               Extension = null,
               UserId = userId
            };
        }


    }
}
