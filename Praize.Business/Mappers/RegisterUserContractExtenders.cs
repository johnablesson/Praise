using Praize.Contracts;
using Praize.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praize.Business.Mappers
{
    public static class RegisterUserContractExtenders
    {
        public static User AsUserEntity(this RegisterUserContract usr)
        {
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
    }
}
