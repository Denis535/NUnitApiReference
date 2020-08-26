// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

#pragma warning disable SA1118 // ParameterMustNotSpanMultipleLines
namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ProjectArchitecture.Model;
    using static NUnitProject;

    public class NUnitModule : Module {

        public override string Name => "NUnit.Main";
        public override Namespace[] Namespaces => new Namespace[] {
            "NUnit".AsNamespace(
                "".AsGroup()
                * typeof( NUnit              .FrameworkPackageSettings                  )
            ),
            "NUnit.Annotations".AsNamespace(
                "".AsGroup()
                * typeof( NUnit.Framework    .NUnitAttribute                                )
                * typeof( NUnit.Framework    .NonTestAssemblyAttribute                      )
                * typeof( NUnit.Framework    .TestAssemblyDirectoryResolveAttribute         )
            ),
            "NUnit.Api".AsNamespace(
                "".AsGroup()
                * typeof( NUnit.Framework.Api.FrameworkController                           )
                * typeof( NUnit.Framework.Api.FrameworkController.FrameworkControllerAction )
                * typeof( NUnit.Framework.Api.FrameworkController.LoadTestsAction           )
                * typeof( NUnit.Framework.Api.FrameworkController.CountTestsAction          )
                * typeof( NUnit.Framework.Api.FrameworkController.ExploreTestsAction        )
                * typeof( NUnit.Framework.Api.FrameworkController.RunTestsAction            )
                * typeof( NUnit.Framework.Api.FrameworkController.RunAsyncAction            )
                * typeof( NUnit.Framework.Api.FrameworkController.StopRunAction             )
            ),
            "NUnit.Runner".AsNamespace(
                "".AsGroup()
                * typeof( NUnit.Framework.Api.ITestAssemblyRunner                           )
                * typeof( NUnit.Framework.Api.NUnitTestAssemblyRunner                       )
            ),
        };


    }
}
