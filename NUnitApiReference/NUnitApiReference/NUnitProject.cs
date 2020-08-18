// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ProjectArchitecture.Model;

    public class NUnitProject : Project {

        public override string Name => "NUnit";
        public override Module[] Modules => new Module[] {
            new NUnitModule(),
            new NUnitModule_Runner_Building(),
            new NUnitModule_Runner_Execution(),
            new NUnitModule_Entities(),
            new NUnitModule_Assertion(),
            new NUnitModule_Infrastructure(),
        };


        internal static Type TypeOf(string name) {
            return typeof( NUnit.FrameworkPackageSettings ).Assembly.GetType( name.Replace( " ", "" ), true );
        }


    }
}
