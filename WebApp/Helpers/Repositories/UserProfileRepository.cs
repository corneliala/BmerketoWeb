using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Repositories
{
    public class UserProfileRepository : Repo<UserProfileEntity>
    {
        public UserProfileRepository(IdentityContext context) : base(context)
        {
        }
    }
}
