using NUnit.Framework;
using ReproRefLibMismatch;
using System;
using System.Linq;
using System.Security.Principal;

namespace Tests
{
    [TestFixture]
    internal sealed class Fixture
    {
        [Test] public void TestNotAdmin()
        {
            Assert.IsFalse(WindowsIdentity.GetCurrent().IsAdministrator());
        }
        [Test] public void TestNoAssemblyMismatch()
        {
            var refVersion = typeof(Fixture).Assembly.GetReferencedAssemblies().Single(n => n.Name == "System.Security.Principal.Windows").Version;
            var binVersion = typeof(WindowsBuiltInRole).Assembly.GetName().Version;
            Assert.AreEqual(refVersion, binVersion);
        }
    }
}
