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
        public override Namespace[] Namespaces => new INode[] {
            "NUnit".AsNamespace(),
            (TypeItem) typeof( FrameworkPackageSettings ),

            "NUnit.Annotations".AsNamespace(),
            (TypeItem) typeof( NUnitAttribute ),
            (TypeItem) typeof( NonTestAssemblyAttribute ),
            (TypeItem) typeof( TestAssemblyDirectoryResolveAttribute ),

            "NUnit.Api".AsNamespace(),
            (TypeItem) typeof( FrameworkController                           ),
            (TypeItem) typeof( FrameworkController.FrameworkControllerAction ),
            (TypeItem) typeof( FrameworkController.LoadTestsAction           ),
            (TypeItem) typeof( FrameworkController.CountTestsAction          ),
            (TypeItem) typeof( FrameworkController.ExploreTestsAction        ),
            (TypeItem) typeof( FrameworkController.RunTestsAction            ),
            (TypeItem) typeof( FrameworkController.RunAsyncAction            ),
            (TypeItem) typeof( FrameworkController.StopRunAction             ),

            "NUnit.Runner".AsNamespace(),
            (TypeItem) typeof( ITestAssemblyRunner                           ),
            (TypeItem) typeof( NUnitTestAssemblyRunner                       ),
        }.ToHierarchy();


    }
}
