// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ProjectArchitecture.Model;
    using static NUnitProject;

    public class NUnitModule : Module {

        public override string Name => "NUnit.Main";
        public override Namespace[] Namespaces => new Namespace[] {
            new Namespace(
                "NUnit",
                typeof( NUnit              .FrameworkPackageSettings )
            ),
            new Namespace(
                "NUnit.Annotations",
                typeof( NUnit.Framework    .NUnitAttribute                                ),
                typeof( NUnit.Framework    .NonTestAssemblyAttribute                      ),
                typeof( NUnit.Framework    .TestAssemblyDirectoryResolveAttribute         )
            ),
            new Namespace(
                "NUnit.Api",
                typeof( NUnit.Framework.Api.FrameworkController                           ),
                typeof( NUnit.Framework.Api.FrameworkController.FrameworkControllerAction ),
                typeof( NUnit.Framework.Api.FrameworkController.LoadTestsAction           ),
                typeof( NUnit.Framework.Api.FrameworkController.CountTestsAction          ),
                typeof( NUnit.Framework.Api.FrameworkController.ExploreTestsAction        ),
                typeof( NUnit.Framework.Api.FrameworkController.RunTestsAction            ),
                typeof( NUnit.Framework.Api.FrameworkController.RunAsyncAction            ),
                typeof( NUnit.Framework.Api.FrameworkController.StopRunAction             )
            ),
            new Namespace(
                "NUnit.Runner",
                typeof( NUnit.Framework.Api.ITestAssemblyRunner                           ),
                typeof( NUnit.Framework.Api.NUnitTestAssemblyRunner                       )
            ),
        };


    }
}
