using HigertechDrone.Interfaces;

namespace HigertechDrone.Services
{
  public class UnitOfWorkService : IUnitOfWorkService
  {
    public UnitOfWorkService(
      IAuthService authService
    )
    {
      Auths = authService;
    }

    public IAuthService Auths { get; }
  }
}
