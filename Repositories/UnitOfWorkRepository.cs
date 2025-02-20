using HigertechDrone.Interfaces;

namespace HigertechDrone.Repositories
{
  public class UnitOfWorkRepository : IUnitOfWorkRepository
  {
    public UnitOfWorkRepository(
      IUserRepository userRepository
    )
    {
      User = userRepository;
    }

    public IUserRepository User { get; }
  }
}
