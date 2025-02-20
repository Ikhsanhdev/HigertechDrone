using HigertechDrone.Interfaces;
using HigertechDrone.Repositories;
using HigertechDrone.Services;

namespace HigertechDrone
{
  public static class ServiceCollectionteExtension
  {
    public static void RegisterServices(this IServiceCollection services)
    {
      #region ========== [ Register Unit Of Works ] ==========
      services.AddScoped<IUnitOfWorkRepository, UnitOfWorkRepository>();
      services.AddScoped<IUnitOfWorkService, UnitOfWorkService>();
      #endregion

      #region ========== [ Register Services ] ==========
      services.AddScoped<IAuthService, AuthService>();
      #endregion

      #region ========== [ Register Repositories ] ==========
      services.AddScoped<IUserRepository, UserRepository>();
      #endregion
    }
  }
}