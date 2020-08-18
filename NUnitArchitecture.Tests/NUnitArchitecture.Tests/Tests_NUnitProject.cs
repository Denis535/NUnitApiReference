// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitArchitecture.Tests {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using NUnit.Framework;
    using ProjectArchitecture.Utils;

    public class Tests_NUnitProject {


        [Test]
        public void Test_NUnitProject() {
            var actual = new NUnitProject();
            var expected = Assembly.Load( "nunit.framework" );

            actual.Compare( expected, out var common, out var missing, out var extra );
            if (missing.Any() || extra.Any()) {
                var builder = new StringBuilder();
                builder.AppendLine( "NUnitProject is invalid" );
                if (missing.Any()) {
                    builder.AppendLine( $"Missing ({missing.Count}):" );
                    foreach (var item in missing) builder.AppendLine( item.FullName );
                }
                if (extra.Any()) {
                    builder.AppendLine( $"Extra ({extra.Count}):" );
                    foreach (var item in extra) builder.AppendLine( item.FullName );
                }
                Assert.Fail( builder.ToString() );
            }
        }


    }
}
