using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using FinalProject.BusinessLogic.Extensions;

namespace FinalProject.BusinessLogic.Services
{
    public interface IThemeService
    {
        List<ThemeDto> GetThemeList();
    }
    internal class ThemeService : IThemeService
    {
        public List<ThemeDto> GetThemeList()
        {
            var themeRepository = new ThemeRepository();

            var themeList = themeRepository.GetListOfTheme();

            return themeList.Select(x => x.ToThemeDto()).ToList();
        }
    }
}
