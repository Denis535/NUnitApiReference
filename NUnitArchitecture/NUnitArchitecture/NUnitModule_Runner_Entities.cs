// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ProjectArchitecture.Model;
    using static NUnitProject;

    public class NUnitModule_Runner_Entities : Module {

        public override string Name => "NUnit.Runner.Entities";
        public override Namespace[] Namespaces => new Namespace[] {
            new Namespace(
                "NUnit.Runner.Entities",
                new Group(
                    "Test",
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
                    typeof( NUnit.Framework.Internal  .TestMethod                                    )
                ),
                new Group(
                    "TestResult",
                    // TestResult
                    typeof( NUnit.Framework.Interfaces.ITestResult                                   ),
                    typeof( NUnit.Framework.Internal  .TestResult                                    ),
                    typeof( NUnit.Framework.Interfaces.ResultState                                   ),
                    typeof( NUnit.Framework.Interfaces.TestStatus                                    ),
                    typeof( NUnit.Framework.Interfaces.FailureSite                                   ),
                    typeof( NUnit.Framework.Interfaces.AssertionResult                               ),
                    typeof( NUnit.Framework.Interfaces.AssertionStatus                               ),
                    typeof( NUnit.Framework.Interfaces.TestAttachment                                ),
                    // TestResult/Suite
                    typeof( NUnit.Framework.Internal  .TestSuiteResult                               ),
                    // TestResult/Case
                    typeof( NUnit.Framework.Internal  .TestCaseResult                                )
                ),
                new Group(
                    "TestData",
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
                )
            ),
            new Namespace(
                "NUnit.Infrastructure",
                new Group(
                    "PropertyBag",
                    typeof( NUnit.Framework.Interfaces.IPropertyBag                                  ),
                    typeof( NUnit.Framework.Internal  .PropertyBag                                   ),
                    typeof( NUnit.Framework.Internal  .PropertyNames                                 )
                )
            ),
        };


    }
}
