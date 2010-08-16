
using System;
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

            info.Title = attributes.OfType<AssemblyTitleAttribute>()
                .Single().Title;

            info.Description = attributes.OfType<AssemblyDescriptionAttribute>()
                .Single().Description;

            info.Copyright = attributes.OfType<AssemblyCopyrightAttribute>()
                .Single().Copyright;

            Version assemblyVersion = assembly.GetName().Version;
            info.VersionString = assemblyVersion.Major + "." + assemblyVersion.Minor;
            return info;
        }
    }
}
