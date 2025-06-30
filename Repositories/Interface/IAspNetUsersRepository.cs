using almacen.api.Models;
using almacen.api.Models.DTO.Admin.Auth;

namespace almacen.api.Repositories.Interface
{
    public interface IAspNetUsersRepository
    {
        Task<ResponseModel> GetUserById(Guid id);
        Task<ResponseModel> ForgotPassword(ForgotPasswordRequestDto model, string token);
    }
}
