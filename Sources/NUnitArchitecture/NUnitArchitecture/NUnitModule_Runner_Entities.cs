// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using NUnit.Framework.Internal;
    using ProjectArchitecture.Model;

    public class NUnitModule_Runner_Entities : Module {

        public override string Name => "NUnit.Runner.Entities";
        public override Namespace[] Namespaces => new INode[] {
            "NUnit.Runner.Entities".AsNamespace(),
            "Test".AsGroup(),
            (TypeItem) typeof( ITest                                         ),
            (TypeItem) typeof( Test                                          ),
            (TypeItem) typeof( RunState                                      ),
            "Test/Suite".AsGroup(),
            (TypeItem) typeof( TestSuite                                     ),
            "Test/Suite/Assembly".AsGroup(),
            (TypeItem) typeof( TestAssembly                                  ),
            "Test/Suite/Fixture".AsGroup(),
            (TypeItem) typeof( IDisposableFixture                            ),
            (TypeItem) typeof( SetUpFixture                                  ),
            (TypeItem) typeof( TestFixture                                   ),
            (TypeItem) typeof( ParameterizedFixtureSuite                     ),
            "Test/Suite/Method".AsGroup(),
            (TypeItem) typeof( ParameterizedMethodSuite                      ),
            "Test/Method".AsGroup(),
            (TypeItem) typeof( TestMethod                                    ),

            "TestResult".AsGroup(),
            (TypeItem) typeof( ITestResult                                   ),
            (TypeItem) typeof( TestResult                                    ),
            (TypeItem) typeof( ResultState                                   ),
            (TypeItem) typeof( TestStatus                                    ),
            (TypeItem) typeof( FailureSite                                   ),
            (TypeItem) typeof( AssertionResult                               ),
            (TypeItem) typeof( AssertionStatus                               ),
            (TypeItem) typeof( TestAttachment                                ),
            "TestResult/Suite".AsGroup(),
            (TypeItem) typeof( TestSuiteResult                               ),
            "TestResult/Case".AsGroup(),
            (TypeItem) typeof( TestCaseResult                                ),

            "TestData".AsGroup(),
            (TypeItem) typeof( ITestData                                     ),
            (TypeItem) typeof( NUnit.Framework.Internal.TestParameters       ),
            "TestData/Fixture".AsGroup(),
            (TypeItem) typeof( ITestFixtureData                              ),
            (TypeItem) typeof( TestFixtureParameters                         ),
            (TypeItem) typeof( TestFixtureData                               ),
            "TestData/Case".AsGroup(),
            (TypeItem) typeof( ITestCaseData                                 ),
            (TypeItem) typeof( TestCaseParameters                            ),
            (TypeItem) typeof( TestCaseData                                  ),

            "NUnit.Infrastructure".AsNamespace(),
            "PropertyBag".AsGroup(),
            (TypeItem) typeof( IPropertyBag                                  ),
            (TypeItem) typeof( PropertyBag                                   ),
            (TypeItem) typeof( PropertyNames                                 ),
        }.ToHierarchy();


    }
}
