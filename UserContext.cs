using System.Security.Claims;
using System.Web;
using Microsoft.AspNet.Identity;

namespace DevTeam.UserContext
{
    public static partial class UserContext
    {
        public static bool IsAuthenticated => HttpContext.Current.User.Identity.IsAuthenticated;

        public static ClaimsIdentity User => HttpContext.Current.User.Identity as ClaimsIdentity;

        public static int UserId
        {
            get
            {
                var userId = 0;
                int.TryParse(User.GetUserId(), out userId);
                return userId;
            }
        }
    }
}
