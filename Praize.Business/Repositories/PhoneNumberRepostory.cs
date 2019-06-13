using Praize.Business.Repositories.Interfaces;
using Praize.DataAccess;
using Praize.DataAccess.Entities;

namespace Praize.Business.Repositories
{
    public class PhoneNumberRepository : Repository<PhoneNumber>, IPhoneNumberRepository
    {
        public PhoneNumberRepository(PraizeDBContext dbContext) : base(dbContext)
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
