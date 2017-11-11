using System;
using System.Linq;
using System.Reflection;

namespace LiskovSamples
{
    public class Locator
    {
        private static Boolean ShouldUseSubClass { get; } = true;

        public static T GetInstance<T>() where T : class
        {
            Type descendantType = Assembly.GetAssembly(typeof(T))
                                          .GetTypes()
                                          .FirstOrDefault(t => t.IsSubclassOf(typeof(T)));

            if (ShouldUseSubClass && descendantType != null)
                return (T)Activator.CreateInstance(descendantType);
            
            return Activator.CreateInstance<T>();
        }
    }
}
