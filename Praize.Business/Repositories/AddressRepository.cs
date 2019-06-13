using Praize.Business.Repositories.Interfaces;
using Praize.DataAccess;
using Praize.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praize.Business.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(PraizeDBContext dbContext) : base(dbContext)
        {
            context = dbContext;
        }

        public PraizeDBContext PraizeDBContext
        {
            get
            {
                return context as PraizeDBContext;
            }
        }
    }
}
