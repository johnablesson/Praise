﻿using Praize.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Praize.Business.Repositories
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IAddressRepository Adresses { get; }
        IPhoneNumberRepository PhoneNumbers { get; }
        Task<int> CompleteAsync();
    }
}
