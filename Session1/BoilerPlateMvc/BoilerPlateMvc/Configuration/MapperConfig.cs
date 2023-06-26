using AutoMapper;
using BoilerPlateMvc.Context;
using BoilerPlateMvc.Models;
using System.Runtime;

namespace BoilerPlateMvc.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Employee, EmployeeVM>();
        }
    }
}
