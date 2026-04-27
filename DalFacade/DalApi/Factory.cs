namespace DalApi;
using static DalApi.DalConfig;
using System.Reflection;
using System.IO;
using System.Linq;

public static class Factory
{
    public static IDal Get
    {
        get
        {
            string dalType = s_dalName ?? throw new DalConfigException($"DAL name is not extracted from the configuration");
            string dal = s_dalPackages[dalType] ?? throw new DalConfigException($"Package for {dalType} is not found in packages list in dal-config.xml");

                Assembly asm = null;
            string assemblyFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dal + ".dll");

            try
            {
                // Try load by assembly name first (when referenced)
                asm = Assembly.Load(dal);
            }
            catch
            {
                // If that fails, try load from file path next
                if (File.Exists(assemblyFile))
                {
                    try
                    {
                        asm = Assembly.LoadFrom(assemblyFile);
                    }
                    catch (Exception ex)
                    {
                        throw new DalConfigException($"Failed to load assembly from path '{assemblyFile}'", ex);
                    }
                }
                else
                {
                    throw new DalConfigException($"Failed to load {dal}.dll package. The assembly was not found at '{assemblyFile}'. Make sure '{dal}.dll' is copied to the application output folder or add a project/reference to it.");
                }
            }

            if (asm == null)
                throw new DalConfigException($"Failed to load {dal}.dll package");

            // First try to find a type that implements IDal and exposes a public static Instance property
            var dalTypeCandidates = asm.GetTypes()
                .Where(t => typeof(IDal).IsAssignableFrom(t) && t.IsClass)
                .ToList();

            foreach (var candidate in dalTypeCandidates)
            {
                var prop = candidate.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static);
                if (prop != null && typeof(IDal).IsAssignableFrom(prop.PropertyType))
                {
                    var instance = prop.GetValue(null) as IDal;
                    if (instance != null) return instance;
                }
            }

            // Fallback: try the original expected name "Dal.{dal}"
            var explicitType = asm.GetType($"Dal.{dal}") ?? Type.GetType($"Dal.{dal}, {dal}");
            if (explicitType != null)
            {
                var prop = explicitType.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static);
                if (prop != null)
                {
                    return prop.GetValue(null) as IDal
                        ?? throw new DalConfigException($"Class {dal} is not a singleton or wrong property name for Instance");
                }
            }

            throw new DalConfigException($"No compatible IDal implementation with a public static 'Instance' property was found in assembly '{dal}'.");
        }
    }
}
