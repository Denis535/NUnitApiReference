// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference.Tests {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using NUnit.Framework;
    using NUnitApiReference.Assemblies;

    public class Tests_ApiReference {


        [Test]
        public void Test_00() {
            var actual = NUnitAssembly.Types.Concat( NUnitAssembly_Assertion.Types ).Concat( NUnitAssembly_Infrastructure.Types ).Select( i => i.Type ).Where( i => i != null ).ToArray();
            var expected = Assembly.Load( "nunit.framework" ).ExportedTypes.Where( IsNotObsolete ).ToArray();
            Assert.That( actual, Is.EquivalentTo( expected ) );
        }


        // Helpers/Type
        private static bool IsNotObsolete(Type type) {
            return !type.IsDefined( typeof( ObsoleteAttribute ) );
        }
        // Helpers/Print
        private static void Print(IEnumerable<Type> types) {
            foreach (var item in types) TestContext.WriteLine( item );
        }


    }
}
