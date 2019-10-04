using System;
using System.Reflection;
#nullable enable

#pragma warning disable CA1050 // This is shared across the solution for Test projects to leverage. It is not strictly a 'type'

public class NetCore
{
    public static string GetNetCoreVersion()
    {
        Assembly assembly = typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly;
        string[] assemblyPath = assembly.CodeBase!.Split(new[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries);
        int netCoreAppIndex = Array.IndexOf(assemblyPath, "Microsoft.NETCore.App");
        if (netCoreAppIndex > 0 && netCoreAppIndex < assemblyPath.Length - 2)
            return assemblyPath[netCoreAppIndex + 1];
        throw new Exception("Unable to determine .NET Core version.");
    }
}

#pragma warning restore CA1050 // This is shared across the solution for Test projects to leverage. It is not strictly a 'type'
