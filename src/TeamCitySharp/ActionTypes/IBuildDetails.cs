using TeamCitySharp.DomainEntities;
using TeamCitySharp.Locators;

namespace TeamCitySharp.ActionTypes
{
    public interface IBuildDetails
    {
        Build ByBuildLocator(BuildLocator locator);
        Build ByBuildId(string buildId);
    }
}