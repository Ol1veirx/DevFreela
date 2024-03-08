using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Core.Entities;
using DevFreela.Infraestructure.Persistence;

namespace DevFreela.Application.Services.Implemetations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Post(NewUserInputModel inputModel)
        {
            var user = new User(inputModel.Name, inputModel.Email, inputModel.BirthDate);
            
            _dbContext.Users.Add(user);

            return user.Id;
        }

        public int Login(LoginViewModel inputModel)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Email == inputModel.Email);
            if (user == null) return 0;
            return user.Id;
        }
    }
}
