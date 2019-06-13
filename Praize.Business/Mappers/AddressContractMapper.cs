using Praize.Business.Enumerations;
using Praize.Contracts;
using Praize.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praize.Business.Mappers
{
    public static class AddressContractMapper
    {
        public static Address AsAddressEntity(this AddressContract addr, Guid userId)
        {
            if (addr == null)
            {
                return null;
            }

            return new Address()
            {
                AddressTypeId = (int)((EAddressType)Enum.Parse(typeof(EAddressType), addr.AddressType)),
                City = addr.City,
                State = addr.State,
                Country = addr.Country,
                Zip = addr.Zip,
                HouseNo = addr.HouseNo,
                Street = addr.Street,
                UserId = userId,
            };
        }
    }
}
