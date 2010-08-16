
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AppInfo
{
    public static class AssemblyExtensions
    {
        public static ApplicationInformation GetInfo(this Assembly assembly)
        {
            var attributes = assembly.GetCustomAttributes(false);

            var info = new ApplicationInformation();

            info.Title = PickOrNull<AssemblyTitleAttribute>(
                attributes, a => a.Title);

            info.Description = PickOrNull<AssemblyDescriptionAttribute>(
                attributes, a => a.Description);

            info.Copyright = PickOrNull<AssemblyCopyrightAttribute>(
                attributes, a => a.Copyright);

            Version assemblyVersion = assembly.GetName().Version;
            info.VersionString = assemblyVersion.Major + "." + assemblyVersion.Minor;

            return info;
        }

        private static string PickOrNull<T>(IEnumerable<object> attributes, Func<T, string> func)
            where T : Attribute
        {
            var attr = attributes.OfType<T>()
                .SingleOrDefault();

            if (attr != null)
                return func(attr);

            return null;
        }
    }
}
