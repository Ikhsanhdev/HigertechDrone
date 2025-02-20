using HigertechDrone.Services;

namespace HigertechDrone.Interfaces
{
  public interface IUnitOfWorkService
  {
    IAuthService Auths { get; }
  }
}
