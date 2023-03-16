using Docker.DotNet;
using Docker.DotNet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewAllDockerContainers.Models;

namespace ViewAllDockerContainers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly DockerClientConfiguration _dockerConfig;
        //private readonly DockerClient _dockerClient;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_dockerConfig = new DockerClientConfiguration(new Uri("npipe://./pipe/docker_engine"));
            //_dockerClient = _dockerConfig.CreateClient();
        }

        public async Task<IActionResult> Index()
        {
            //var containers = await _dockerClient.Containers.ListContainersAsync(new ContainersListParameters { All = true });
            //var model = new List<ContainerViewModel>();

            //var dockerConfig = new DockerClientConfiguration(new Uri("npipe://./pipe/docker_engine"));
            //var dockerClient = dockerConfig.CreateClient();

            //var containers = await dockerClient.Containers.ListContainersAsync(
            //    new ContainersListParameters()
            //    {
            //        Limit = 10,
            //    });

            //foreach (var container in containers)
            //{
            //    var containerDetails = await dockerClient.Containers.InspectContainerAsync(container.ID);
            //    var networks = string.Join(",", containerDetails.NetworkSettings.Networks.Keys);

            //    model.Add(new ContainerViewModel
            //    {
            //        Id = container.ID,
            //        Name = container.Names.FirstOrDefault()?.Substring(1),
            //        Hostname = containerDetails.Config.Hostname,
            //        InternalIP = containerDetails.NetworkSettings.Networks.Values.First().IPAddress,
            //        ExternalIP = containerDetails.NetworkSettings.Networks.Values.First().GlobalIPv6Address,
            //        Cpu = containerDetails.HostConfig.CPUShares,
            //        Memory = containerDetails.HostConfig.Memory,
            //        Networks = networks
            //    });
            //}

            //return View(model);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}