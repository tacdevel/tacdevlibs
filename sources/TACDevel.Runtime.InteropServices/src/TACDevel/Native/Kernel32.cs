/***********************************************************************************************************************
 * FileName:            Kernel32.cs
 * Copyright/License:   https://github.com/tom-corwin/tacdevlibs/blob/master/LICENSE.md
***********************************************************************************************************************/

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TACDevel.Native
{
    [SuppressUnmanagedCodeSecurity]
    internal static class Kernel32
    {
        private const string AssemblyRef = "kernel32";

        [DllImport(AssemblyRef)]
        internal static extern IntPtr LoadLibrary(string fileName);

        [DllImport(AssemblyRef)]
        internal static extern IntPtr GetProcAddress(IntPtr module, string procName);

        [DllImport(AssemblyRef)]
        internal static extern int FreeLibrary(IntPtr module);
    }
}