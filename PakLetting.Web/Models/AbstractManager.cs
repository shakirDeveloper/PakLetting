using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PakLetting.Model.AccountModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using PakLetting.Model.Interfaces;
using System.Web.Security;

namespace PakLetting.Web.Models
{
    public class AbstractManager : IAccountInterface
    {
        #region Public/Private variables

        private string registerUserRole = string.Empty;
        private bool isSignedIn = false;
        private RegisterViewModel _registerModel;
        private LoginViewModel _loginModel;
        private ApplicationUser _userModel;
        private bool _createPersistent;

        #endregion

        #region Properties

        public string UserRole
        {
            set
            {
                registerUserRole = value;
            }
        }

        public bool IsUserAuthenticate { get; protected set; }

        #endregion

        bool IAccountInterface.RegisterUser()
        {
            try
            {
                MembershipUser newUser = Membership.CreateUser(_registerModel.Email, _registerModel.Password, _registerModel.Email);
                if (Roles.RoleExists(registerUserRole))
                {
                    Roles.AddUserToRole(newUser.UserName, registerUserRole);
                    IsUserAuthenticate = true;
                }
            }
            catch (Exception ex)
            {
            }

            return IsUserAuthenticate;
        }
        bool IAccountInterface.LoginUser()
        {
            if (Membership.ValidateUser(_loginModel.Email, _loginModel.Password))
            {
                MembershipUser userInfo = Membership.GetUser(_loginModel.Email);
                if (userInfo != null && userInfo.IsApproved)
                {
                    IsUserAuthenticate = true;
                }

            }
            return IsUserAuthenticate;
        }
        bool IAccountInterface.SignInUser()
        {
            if (String.IsNullOrEmpty(_userModel.UserName))
            {
                return isSignedIn;
                throw new ArgumentException("Value cannot be null or empty.", "userName");

            }
            FormsAuthentication.SetAuthCookie(_userModel.UserName, _createPersistent);
            return true;
        }
        bool IAccountInterface.SignOutUser()
        {
            FormsAuthentication.SignOut();
            return true;
        }

        public AbstractManager(RegisterViewModel registerModel)
        {
            // TODO: Complete member initialization
            _registerModel = registerModel;
        }
        public AbstractManager(LoginViewModel loginModel)
        {
            // TODO: Complete member initialization
            _loginModel = loginModel;
        }
        public AbstractManager(ApplicationUser userModel, bool createPersistentCookie)
        {
            // TODO: Complete member initialization
            _userModel = userModel;
            _createPersistent = createPersistentCookie;
        }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("PakLettingCS", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}