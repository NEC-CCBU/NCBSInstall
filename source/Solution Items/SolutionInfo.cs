using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyDescription("NCBSInstall deploy agent.")]
[assembly: AssemblyCompany("NCBSInstall Pty. Ltd.")]
[assembly: AssemblyProduct("NCBSInstall")]
[assembly: AssemblyCopyright("Copyright © NEC. Ltd. 2016")]
[assembly: AssemblyCulture("")]
#if DEBUG

[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: ComVisible(false)]