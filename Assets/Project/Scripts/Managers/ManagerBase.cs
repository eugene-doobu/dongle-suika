using JetBrains.Annotations;

namespace DongleSuika
{
    public abstract class ManagerBase
    {
        [UsedImplicitly]
        protected ManagerBase()
        {
        }

        public virtual void Initialize()
        {
        }
        
        public virtual void PostInitialize()
        {
        }

        public virtual void Tick()
        {
        }

        public virtual void LateTick()
        {
        }
    }
}