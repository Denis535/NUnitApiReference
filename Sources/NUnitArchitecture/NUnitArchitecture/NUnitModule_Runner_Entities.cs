// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ProjectArchitecture.Model;

    public class NUnitModule_Runner_Entities : Module {

        public override string Name => "NUnit.Runner.Entities";
        public override Namespace[] Namespaces => new INode[] {
            "NUnit.Runner.Entities".AsNamespace(),
            "Test".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Interfaces.ITest                                         ),
            (TypeItem) typeof( NUnit.Framework.Internal  .Test                                          ),
            (TypeItem) typeof( NUnit.Framework.Interfaces.RunState                                      ),
            "Test/Suite".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal  .TestSuite                                     ),
            "Test/Suite/Assembly".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal  .TestAssembly                                  ),
            "Test/Suite/Fixture".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Interfaces.IDisposableFixture                            ),
            (TypeItem) typeof( NUnit.Framework.Internal  .SetUpFixture                                  ),
            (TypeItem) typeof( NUnit.Framework.Internal  .TestFixture                                   ),
            (TypeItem) typeof( NUnit.Framework.Internal  .ParameterizedFixtureSuite                     ),
            "Test/Suite/Method".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal  .ParameterizedMethodSuite                      ),
            "Test/Method".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal  .TestMethod                                    ),

            "TestResult".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Interfaces.ITestResult                                   ),
            (TypeItem) typeof( NUnit.Framework.Internal  .TestResult                                    ),
            (TypeItem) typeof( NUnit.Framework.Interfaces.ResultState                                   ),
            (TypeItem) typeof( NUnit.Framework.Interfaces.TestStatus                                    ),
            (TypeItem) typeof( NUnit.Framework.Interfaces.FailureSite                                   ),
            (TypeItem) typeof( NUnit.Framework.Interfaces.AssertionResult                               ),
            (TypeItem) typeof( NUnit.Framework.Interfaces.AssertionStatus                               ),
            (TypeItem) typeof( NUnit.Framework.Interfaces.TestAttachment                                ),
            "TestResult/Suite".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal  .TestSuiteResult                               ),
            "TestResult/Case".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal  .TestCaseResult                                ),

            "TestData".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Interfaces.ITestData                                     ),
            (TypeItem) typeof( NUnit.Framework.Internal  .TestParameters                                ),
            "TestData/Fixture".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Interfaces.ITestFixtureData                              ),
            (TypeItem) typeof( NUnit.Framework.Internal  .TestFixtureParameters                         ),
            (TypeItem) typeof( NUnit.Framework           .TestFixtureData                               ),
            "TestData/Case".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Interfaces.ITestCaseData                                 ),
            (TypeItem) typeof( NUnit.Framework.Internal  .TestCaseParameters                            ),
            (TypeItem) typeof( NUnit.Framework           .TestCaseData                                  ),

            "NUnit.Infrastructure".AsNamespace(),
            "PropertyBag".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Interfaces.IPropertyBag                                  ),
            (TypeItem) typeof( NUnit.Framework.Internal  .PropertyBag                                   ),
            (TypeItem) typeof( NUnit.Framework.Internal  .PropertyNames                                 ),
        }.ToHierarchy();


    }
}
