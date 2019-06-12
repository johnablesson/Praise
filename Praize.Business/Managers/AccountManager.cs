using Microsoft.EntityFrameworkCore;
using Praize.Business.Mappers;
using Praize.Business.Repositories;
using Praize.Business.Repositories.Interfaces;
using Praize.Contracts;
using Praize.DataAccess;
using Praize.DataAccess.Entities;
using Praize.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praize.Business.Managers
{
    public class AccountManager : IAccountManager
    {
        private IUnitOfWork _unitOfWork;

        public AccountManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateUser(RegisterUserContract registerUserContract)
        {
            List<ApiError> errors = new List<ApiError>();

            if (string.IsNullOrWhiteSpace(registerUserContract.UserName))
            {
                errors.Add(new ApiError() { Field = nameof(registerUserContract.UserName), Message = "User Name is required" });
            }

            if (!string.IsNullOrWhiteSpace(registerUserContract.UserName) && registerUserContract.UserName.Length > 50)
            {
                errors.Add(new ApiError() { Field = nameof(registerUserContract.UserName), Message = "User Name cannot exceed 50 characters" });
            }

            var user = registerUserContract.AsUserEntity();

            _unitOfWork.Users.Add(user);
            _unitOfWork.Complete().GetAwaiter().GetResult();



        }
    }
}
