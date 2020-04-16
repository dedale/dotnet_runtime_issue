using System.Security.Principal;

namespace ReproRefLibMismatch
{
    public static class WindowsIdentityExtensions
    {
        public static bool IsAdministrator(this WindowsIdentity id)
        {
            return new WindowsPrincipal(id).IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
