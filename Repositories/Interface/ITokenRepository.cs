using Microsoft.AspNetCore.Identity;
using almacen.api.Models;

namespace almacen.api.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreateJwtToken(ApplicationUser user, List<string> roles);
        string CreateRestoreToken(ApplicationUser user);
    }
}
