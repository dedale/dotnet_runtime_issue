using ReproRefLibMismatch;
using System;
using System.Linq;
using System.Security.Principal;

namespace ConsoleNET48
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(WindowsIdentity.GetCurrent().IsAdministrator() ? "admin" : "not admin");

            var refVersion = typeof(WindowsIdentityExtensions).Assembly.GetReferencedAssemblies().Single(n => n.Name == "System.Security.Principal.Windows").Version;
            var binVersion = typeof(WindowsBuiltInRole).Assembly.GetName().Version;
            Console.WriteLine($"ref: {refVersion} bin: {binVersion}");
        }
    }
}
