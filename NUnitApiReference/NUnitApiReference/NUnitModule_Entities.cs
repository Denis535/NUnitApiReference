// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class NUnitModule_Entities : Module {

        private const string X_Entities = "# Entities";

        private const string XX_Attributes     = "## Attributes";
        private const string XX_Utils          = "## Utils";
        private const string XX_Infrastructure = "## Infrastructure";
        private const string XX_Exceptions     = "## Exceptions";
        private const string XX_Delegates      = "## Delegates";


        public override Item[] Items => new Item[] {
            X_Entities,

            "#### Test",
            typeof( NUnit.Framework.Interfaces        .ITest                                         ),
            typeof( NUnit.Framework.Internal          .Test                                          ),
            typeof( NUnit.Framework.Interfaces        .RunState                                      ),
            "#### Test/Suite",
            typeof( NUnit.Framework.Internal          .TestSuite                                     ),
            "#### Test/Assembly",
            typeof( NUnit.Framework.Internal          .TestAssembly                                  ),
            "#### Test/Fixture",
            typeof( NUnit.Framework.Internal          .SetUpFixture                                  ),
            typeof( NUnit.Framework.Internal          .TestFixture                                   ),
            typeof( NUnit.Framework.Internal          .ParameterizedFixtureSuite                     ),
            "#### Test/Method",
            typeof( NUnit.Framework.Internal          .TestMethod                                    ),
            typeof( NUnit.Framework.Internal          .ParameterizedMethodSuite                      ),

            "#### TestData",
            typeof( NUnit.Framework.Interfaces        .ITestData                                     ),
            typeof( NUnit.Framework.Internal          .TestParameters                                ),
            "#### TestData/Fixture",
            typeof( NUnit.Framework.Interfaces        .ITestFixtureData                              ),
            typeof( NUnit.Framework.Internal          .TestFixtureParameters                         ),
            typeof( NUnit.Framework                   .TestFixtureData                               ),
            "#### TestData/Case",
            typeof( NUnit.Framework.Interfaces        .ITestCaseData                                 ),
            typeof( NUnit.Framework.Internal          .TestCaseParameters                            ),
            typeof( NUnit.Framework                   .TestCaseData                                  ),

            "#### TestResult",
            typeof( NUnit.Framework.Interfaces        .ITestResult                                   ),
            typeof( NUnit.Framework.Internal          .TestResult                                    ),
            typeof( NUnit.Framework.Interfaces        .ResultState                                   ),
            typeof( NUnit.Framework.Interfaces        .TestStatus                                    ),
            typeof( NUnit.Framework.Interfaces        .FailureSite                                   ),
            typeof( NUnit.Framework.Interfaces        .AssertionResult                               ),
            typeof( NUnit.Framework.Interfaces        .AssertionStatus                               ),
            typeof( NUnit.Framework.Interfaces        .TestAttachment                                ),
            "#### TestResult/Suite",
            typeof( NUnit.Framework.Internal          .TestSuiteResult                               ),
            "#### TestResult/Case",
            typeof( NUnit.Framework.Internal          .TestCaseResult                                ),

            XX_Infrastructure,
            "#### PropertyBag",
            typeof( NUnit.Framework.Interfaces        .IPropertyBag                                  ),
            typeof( NUnit.Framework.Internal          .PropertyBag                                   ),
            typeof( NUnit.Framework.Internal          .PropertyNames                                 ),
        };


    }
}
