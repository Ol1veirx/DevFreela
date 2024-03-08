using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Application.InputModels;
using DevFreela.Core.Entities;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IUserService
    {
        int Post(NewUserInputModel inputModel);
        int Login(LoginViewModel inputModel);
    }
}
