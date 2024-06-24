using Entitas;

namespace CodeBase.Infrastructure.Systems
{
    public interface ISystemFactory
    {
        TSystem Create<TSystem>() where TSystem : ISystem;
        TSystem Create<TSystem>(params object[] args) where TSystem : ISystem;
    }
}