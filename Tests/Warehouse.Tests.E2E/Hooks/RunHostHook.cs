using TechTalk.SpecFlow;
using Warehouse.Tests.E2E.Tools;
using Warehouse.Tests.E2E.Tools.NetCoreHosting;

namespace Warehouse.Tests.E2E.Hooks
{
    [Binding]
    public sealed class RunHostHook
    {
        private static readonly DotNetCoreHost _host =
         new DotNetCoreHost(new DotNetCoreHostOptions
         {
             Port = HostConstants.Port,
             CsProjectPath = HostConstants.CsProjectPath
         });

        [BeforeFeature("api")]
        public static void StartHost()
        {
            _host.Start();
        }

        [AfterFeature("api")]
        public static void ShotdownHost()
        {
            _host.Stop();
        }
    }
}
