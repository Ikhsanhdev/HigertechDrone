using HigertechDrone.Repositories;

namespace HigertechDrone.Interfaces
{
  public interface IUnitOfWorkRepository
  {
    IUserRepository User { get; }
  }
}
