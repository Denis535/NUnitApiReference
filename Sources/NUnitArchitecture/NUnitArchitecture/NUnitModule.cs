// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NUnit;
    using NUnit.Framework;
    using NUnit.Framework.Api;
    using ProjectArchitecture.Model;

    public class NUnitModule : Module {

        public override string Name => "NUnit.Main";
        public override Namespace[] Namespaces => new object[] {
            "NUnit".AsNamespace(),
            "".AsGroup(),
            typeof( FrameworkPackageSettings ),

            "NUnit.Annotations".AsNamespace(),
            "".AsGroup(),
            typeof( NUnitAttribute ),
            typeof( NonTestAssemblyAttribute ),
            typeof( TestAssemblyDirectoryResolveAttribute ),

            "NUnit.Api".AsNamespace(),
            "".AsGroup(),
            typeof( FrameworkController                           ),
            typeof( FrameworkController.FrameworkControllerAction ),
            typeof( FrameworkController.LoadTestsAction           ),
            typeof( FrameworkController.CountTestsAction          ),
            typeof( FrameworkController.ExploreTestsAction        ),
            typeof( FrameworkController.RunTestsAction            ),
            typeof( FrameworkController.RunAsyncAction            ),
            typeof( FrameworkController.StopRunAction             ),

            "NUnit.Runner".AsNamespace(),
            "".AsGroup(),
            typeof( ITestAssemblyRunner                           ),
            typeof( NUnitTestAssemblyRunner                       ),
        }.ToHierarchy();


    }
}
