// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ArchitectureModel;
    using static NUnitProject;

    public class NUnitModule_Entities : Module {

        public override string Name => "NUnit.Entities";
        public override Namespace[] Namespaces => new Namespace[] {
            new Namespace(
                "NUnit.Entities.Test",
                // Test
                typeof( NUnit.Framework.Interfaces.ITest                                         ),
                typeof( NUnit.Framework.Internal  .Test                                          ),
                typeof( NUnit.Framework.Interfaces.RunState                                      ),
                // Test/Suite
                typeof( NUnit.Framework.Internal  .TestSuite                                     ),
                // Test/Suite/Assembly
                typeof( NUnit.Framework.Internal  .TestAssembly                                  ),
                // Test/Suite/Fixture
                TypeOf( "NUnit.Framework.Interfaces.IDisposableFixture"                          ),
                typeof( NUnit.Framework.Internal  .SetUpFixture                                  ),
                typeof( NUnit.Framework.Internal  .TestFixture                                   ),
                typeof( NUnit.Framework.Internal  .ParameterizedFixtureSuite                     ),
                // Test/Suite/Method
                typeof( NUnit.Framework.Internal  .ParameterizedMethodSuite                      ),
                // Test/Method
                typeof( NUnit.Framework.Internal  .TestMethod                                    ),

                // TestResult
                typeof( NUnit.Framework.Interfaces.ITestResult                                   ),
                typeof( NUnit.Framework.Internal  .TestResult                                    ),
                //TypeOf( "NUnit.Framework.Internal.TestResult+ExceptionResult"                    ),
                typeof( NUnit.Framework.Interfaces.ResultState                                   ),
                typeof( NUnit.Framework.Interfaces.TestStatus                                    ),
                typeof( NUnit.Framework.Interfaces.FailureSite                                   ),
                typeof( NUnit.Framework.Interfaces.AssertionResult                               ),
                typeof( NUnit.Framework.Interfaces.AssertionStatus                               ),
                typeof( NUnit.Framework.Interfaces.TestAttachment                                ),
                // TestResult/Suite
                typeof( NUnit.Framework.Internal  .TestSuiteResult                               ),
                // TestResult/Case
                typeof( NUnit.Framework.Internal  .TestCaseResult                                ),

                // TestData
                typeof( NUnit.Framework.Interfaces.ITestData                                     ),
                typeof( NUnit.Framework.Internal  .TestParameters                                ),
                // TestData/Fixture
                typeof( NUnit.Framework.Interfaces.ITestFixtureData                              ),
                typeof( NUnit.Framework.Internal  .TestFixtureParameters                         ),
                typeof( NUnit.Framework           .TestFixtureData                               ),
                // TestData/Case
                typeof( NUnit.Framework.Interfaces.ITestCaseData                                 ),
                typeof( NUnit.Framework.Internal  .TestCaseParameters                            ),
                typeof( NUnit.Framework           .TestCaseData                                  )
            ),
            new Namespace(
                "NUnit.Infrastructure",
                // PropertyBag
                typeof( NUnit.Framework.Interfaces.IPropertyBag                                  ),
                typeof( NUnit.Framework.Internal  .PropertyBag                                   ),
                typeof( NUnit.Framework.Internal  .PropertyNames                                 )
            ),
        };


    }
}
