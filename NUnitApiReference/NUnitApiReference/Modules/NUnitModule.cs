// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NUnitModule : Module {

        private static readonly HeaderItem X_Main        = HeaderItem.H1( "Main" );
        private static readonly HeaderItem XX_Api        = HeaderItem.H2( "Api" );
        private static readonly HeaderItem XX_Runner     = HeaderItem.H2( "Runner" );
        private static readonly HeaderItem XX_Exceptions = HeaderItem.H2( "Exceptions" );


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

            typeof( NUnit.Framework           .NUnitAttribute                                ),
            typeof( NUnit.Framework           .NonTestAssemblyAttribute                      ),
            typeof( NUnit.Framework           .TestAssemblyDirectoryResolveAttribute         ),

            XX_Api,
            typeof( NUnit.Framework.Api       .FrameworkController                           ),
            typeof( NUnit.Framework.Api       .FrameworkController.FrameworkControllerAction ),
            typeof( NUnit.Framework.Api       .FrameworkController.LoadTestsAction           ),
            typeof( NUnit.Framework.Api       .FrameworkController.CountTestsAction          ),
            typeof( NUnit.Framework.Api       .FrameworkController.ExploreTestsAction        ),
            typeof( NUnit.Framework.Api       .FrameworkController.RunTestsAction            ),
            typeof( NUnit.Framework.Api       .FrameworkController.RunAsyncAction            ),
            typeof( NUnit.Framework.Api       .FrameworkController.StopRunAction             ),

            XX_Runner,
            typeof( NUnit.Framework.Api       .ITestAssemblyRunner                           ),
            typeof( NUnit.Framework.Api       .NUnitTestAssemblyRunner                       ),
            typeof( NUnit.Framework.Interfaces.IPreFilter                                    ),
            typeof( NUnit.Framework.Interfaces.ITestFilter                                   ),
            typeof( NUnit.Framework.Internal  .TestFilter                                    ),

            XX_Exceptions,
            typeof( NUnit.Framework.Internal  .NUnitException                                ),
            typeof( NUnit.Framework.Internal  .InvalidTestFixtureException                   ),
            typeof( NUnit.Framework.Internal  .InvalidDataSourceException                    ),
            typeof( NUnit.Framework.Internal  .TestCaseTimeoutException                      ),
        };


    }
}
