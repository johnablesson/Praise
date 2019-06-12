using Microsoft.EntityFrameworkCore;
using Praize.Business.Repositories.Interfaces;
using Praize.DataAccess;
using Praize.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praize.Business.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(PraizeDBContext dbContext) : base(dbContext)
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
