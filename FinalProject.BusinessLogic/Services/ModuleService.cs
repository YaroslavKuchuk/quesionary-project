using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using FinalProject.BusinessLogic.Extensions;

namespace FinalProject.BusinessLogic.Services
{
    public interface IModuleService
    {
        List<ModuleDto> moduleList();


    }
    internal class ModuleService : IModuleService
    {
        public List<ModuleDto> moduleList()
        {
            var moduleRespitory = new ModuleRepository();

            var moduleList = moduleRespitory.GetListOfModule();

            return moduleList.Select(x => x.ToModuleDto()).ToList();
        }
    }
}
