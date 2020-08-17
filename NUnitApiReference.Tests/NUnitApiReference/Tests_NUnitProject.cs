// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using NUnit.Framework;

    public class Tests_NUnitProject {


        [Test]
        public void Test_NUnitProject() {
            var actual = new NUnitProject().Flatten().OfType<Type>().ToArray();
            var expected = Assembly.Load( "nunit.framework" ).DefinedTypes.Where( i => !IsObsolete( i ) ).Where( i => !IsCompilerGenerated( i ) ).ToArray();
            Assert.That( actual, Is.EquivalentTo( expected ) );
        }


        // Helpers
        private static bool IsObsolete(Type? type) {
            while (type != null) {
                if (type.IsDefined( typeof( ObsoleteAttribute ) )) return true;
                type = type.DeclaringType;
            }
            return false;
        }
        private static bool IsCompilerGenerated(Type? type) {
            while (type != null) {
                if (type.IsDefined( typeof( CompilerGeneratedAttribute ) )) return true;
                type = type.DeclaringType;
            }
            return false;
        }


    }
}
