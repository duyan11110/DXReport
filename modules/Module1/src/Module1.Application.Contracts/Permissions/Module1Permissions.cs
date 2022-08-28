using Volo.Abp.Reflection;

namespace Module1.Permissions;

public class Module1Permissions
{
    public const string GroupName = "Module1";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(Module1Permissions));
    }
}
