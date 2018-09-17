using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace CVBuild
{
    public class IMPServices
    {
        public List<string> Services = new List<string>();

        public List<string> GetImpServices()
        {
            if (Services.Any())
                return Services;

            Services = ServiceController.GetServices().Where(x=> x.DisplayName.ToLower().StartsWith("imp.")).Select(a=> a.DisplayName).ToList();
            return Services;
        }

        public bool IsRunning(string serviceName)
        {
            var svc = ServiceController.GetServices().FirstOrDefault(x => x.ServiceName == serviceName);
            return svc != null && svc.Status == ServiceControllerStatus.Running;
        }
        public void StopServices (List<string> input)
        {
            var stoppedServices = new List<string>();
            var servicesToStop = ServiceController.GetServices().Where(x=> input.Contains(x.ServiceName)).ToList();
            foreach (var service in servicesToStop)
            {
                if (service.Status == ServiceControllerStatus.Running && service.CanStop)
                {
                    service.WaitForStatus(ServiceControllerStatus.Running);
                    service.Stop();
                }
            }

        }

        public void StartServices(List<string> input)
        {
            var startedServices = new List<string>();
            var servicesToStart = ServiceController.GetServices().Where(x => input.Contains(x.ServiceName)).ToList();
            foreach (ServiceController service in servicesToStart)
            {

                if (service.Status == ServiceControllerStatus.Stopped)
                {
                    service.Start();
                }
                
            }


        }
    }
}
