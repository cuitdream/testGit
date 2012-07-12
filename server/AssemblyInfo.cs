using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

#if NET_40
[assembly: AssemblyConfiguration("net-4.0.win32; Release")]
#else
[assembly: AssemblyConfiguration("net-3.5.win32; Release")]
#endif

[assembly: AssemblyProduct("Quarz.NET Server 2.0.1")]
[assembly: AssemblyDescription("Quartz Scheduling Server for .NET")]
[assembly : AssemblyCompany("http://quartznet.sourceforge.net/")]
[assembly : AssemblyCopyright("Copyright 2007-2012 Marko Lahma")]
[assembly:  AssemblyTrademark("Apache License, Version 2.0")]
[assembly : AssemblyCulture("")]
//[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]


[assembly: AssemblyVersion("2.0.1.100")]


#if STRONG
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyFile("Quartz.Net.snk")]
[assembly:AllowPartiallyTrustedCallers]
#endif
