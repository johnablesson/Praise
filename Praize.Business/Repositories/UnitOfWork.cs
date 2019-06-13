using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Praize.Business.Repositories.Interfaces;
using Praize.DataAccess;

namespace Praize.Business.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PraizeDBContext _context;

        public UnitOfWork(PraizeDBContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Adresses = new AddressRepository(_context);
            PhoneNumbers = new PhoneNumberRepository(_context);
        }
        public IUserRepository Users { get; private set; }
        public IAddressRepository Adresses { get; private set; }
        public IPhoneNumberRepository PhoneNumbers { get; private set; }


        public Task<int> CompleteAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
