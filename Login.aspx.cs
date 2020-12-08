using IdentitySample;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using Tercera;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void NewLogin_Page_Load(object sender, EventArgs e)
    {
        ApplicationUser AppUser = null;
        string AppUserId = string.Empty;
      
        try
        {
            AppUser = IdentityManager.UserManager.FindByName(Login1.UserName);
            if (AppUser != null)
            {
                AppUserId = AppUser.Id;

                SignInStatus Status = IdentityManager.SignInManager.PasswordSignIn(AppUser.UserName, Login1.Password, false, false);
                switch (Status)
                {
                    case SignInStatus.Success:
                        {
                            msg.Text = "login successful";
                            return;
                        }
                    case SignInStatus.LockedOut:
                    case SignInStatus.Failure:
                    default:
                        {
                            msg.Text = "login failure";
                            return;
                        }

                }
            }
        }
        catch (Exception ex)
        {
            msg.Text = ex.Message;
        }
    }
}