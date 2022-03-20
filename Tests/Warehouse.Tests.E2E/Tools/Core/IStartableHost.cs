namespace Warehouse.Tests.E2E.Tools.Core
{
    public interface IStartableHost : IHost
    {
        void Start();
        void Stop();
    }
}