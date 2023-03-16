namespace ViewAllDockerContainers.Models
{
    public class ContainerViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Hostname { get; set; }
        public string InternalIP { get; set; }
        public string ExternalIP { get; set; }
        public long Cpu { get; set; }
        public long Memory { get; set; }
        public string Networks { get; set; }
    }
}
