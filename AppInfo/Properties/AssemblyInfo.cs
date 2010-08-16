using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("AppInfo")]
[assembly: AssemblyDescription("Extracts information from an applications AssemblyInfo attributes.")]
[assembly: AssemblyCompany("lcorneliussen.de")]
[assembly: AssemblyProduct("AppInfo")]
[assembly: AssemblyCopyright("Copyright © Lars Corneliussen 2010")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("d5462283-5819-44cc-82ef-9646bd1455c3")]

[assembly: AssemblyVersion("0.2.0.0")]
[assembly: AssemblyFileVersion("0.2.0.0")]
