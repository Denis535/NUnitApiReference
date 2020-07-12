// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NUnitModule : Module {

        private const string X_Main = "# Main";

        private const string XX_Attributes     = "## Attributes";
        private const string XX_Utils          = "## Utils";
        private const string XX_Infrastructure = "## Infrastructure";
        private const string XX_Exceptions     = "## Exceptions";
        private const string XX_Delegates      = "## Delegates";

        private const string XXX_Api    = "### Api";
        private const string XXX_Runner = "### Runner";

        public static readonly Item[] AllItems =
            new NUnitModule().Items
            .Concat( new NUnitModule_Runner_Building().Items )
            .Concat( new NUnitModule_Runner_Execution().Items )
            .Concat( new NUnitModule_Entities().Items )
            .Concat( new NUnitModule_Assertion().Items )
            .Concat( new NUnitModule_Infrastructure().Items )
            .ToArray();

        public override Item[] Items => new Item[] {
            X_Main,

            XXX_Api,
            typeof( NUnit.Framework.Api       .FrameworkController                           ),
            typeof( NUnit.Framework.Api       .FrameworkController.FrameworkControllerAction ),
            typeof( NUnit.Framework.Api       .FrameworkController.LoadTestsAction           ),
            typeof( NUnit.Framework.Api       .FrameworkController.CountTestsAction          ),
            typeof( NUnit.Framework.Api       .FrameworkController.ExploreTestsAction        ),
            typeof( NUnit.Framework.Api       .FrameworkController.RunTestsAction            ),
            typeof( NUnit.Framework.Api       .FrameworkController.RunAsyncAction            ),
            typeof( NUnit.Framework.Api       .FrameworkController.StopRunAction             ),

            XXX_Runner,
            typeof( NUnit.Framework.Api       .ITestAssemblyRunner                           ),
            typeof( NUnit.Framework.Api       .NUnitTestAssemblyRunner                       ),
            typeof( NUnit.Framework.Interfaces.IPreFilter                                    ),
            typeof( NUnit.Framework.Interfaces.ITestFilter                                   ),
            typeof( NUnit.Framework.Internal  .TestFilter                                    ),

            XX_Attributes,
            typeof( NUnit.Framework           .NUnitAttribute                                ),
            "#### Assembly",
            typeof( NUnit.Framework           .NonTestAssemblyAttribute                      ),
            typeof( NUnit.Framework           .TestAssemblyDirectoryResolveAttribute         ),

            XX_Infrastructure,
            typeof( NUnit                     .FrameworkPackageSettings                      ),
            typeof( NUnit.Framework.Internal  .TestNameGenerator                             ),
            typeof( NUnit.Framework.Internal  .PlatformHelper                                ),
            typeof( NUnit.Framework.Internal  .CultureDetector                               ),

            XX_Exceptions,
            typeof( NUnit.Framework.Internal  .NUnitException                                 ),
            typeof( NUnit.Framework.Internal  .InvalidTestFixtureException                    ),
            typeof( NUnit.Framework.Internal  .InvalidDataSourceException                     ),
            typeof( NUnit.Framework.Internal  .TestCaseTimeoutException                       ),
        };


    }
}
