using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Praize.Business.Repositories.Interfaces;
using Praize.DataAccess;

namespace Praize.Business.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PraizeDBContext _context;

        public UnitOfWork(PraizeDBContext context)
        {
            _context = context;
            Users = new UserRepository(_context);

        }
        public IUserRepository Users { get; private set; }


        public Task<int> Complete()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
