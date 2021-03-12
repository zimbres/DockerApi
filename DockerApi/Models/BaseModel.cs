using System;

namespace DockerApi.Models
{
    public class BaseModel
    {
        public string Hostname { get; set; }
        public DateTime DateTime { get; set; }
        public double Version { get; set; }
    }
}
