using PakLetting.Model.AccountModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.Model.Interfaces
{
    public interface IAccountInterface
    {
        bool RegisterUser();
        bool LoginUser();
        bool SignInUser();
        bool SignOutUser();
        string UserRole;
    }
}
