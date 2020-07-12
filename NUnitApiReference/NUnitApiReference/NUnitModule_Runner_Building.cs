// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class NUnitModule_Runner_Building : Module {

        private const string X_Runner_Building = "# Runner/Building";

        private const string XX_Attributes     = "## Attributes";
        private const string XX_Utils          = "## Utils";
        private const string XX_Infrastructure = "## Infrastructure";
        private const string XX_Exceptions     = "## Exceptions";
        private const string XX_Delegates      = "## Delegates";


        public override Item[] Items => new Item[] {
            X_Runner_Building,

            "#### Builders/Assembly",
            typeof( NUnit.Framework.Api              .ITestAssemblyBuilder                          ),
            typeof( NUnit.Framework.Api              .DefaultTestAssemblyBuilder                    ),
            "#### Builders/Type",
            typeof( NUnit.Framework.Interfaces       .ISuiteBuilder                                 ),
            typeof( NUnit.Framework.Internal.Builders.DefaultSuiteBuilder                           ),
            "#### Builders/Type",
            typeof( NUnit.Framework.Interfaces       .IFixtureBuilder                               ),
            typeof( NUnit.Framework.Interfaces       .IFixtureBuilder2                              ),
            "#### Builders/Method",
            typeof( NUnit.Framework.Interfaces       .ITestCaseBuilder                              ),
            typeof( NUnit.Framework.Internal.Builders.DefaultTestCaseBuilder                        ),
            "#### Builders/Method",
            typeof( NUnit.Framework.Interfaces       .ITestBuilder                                  ),
            typeof( NUnit.Framework.Interfaces       .ISimpleTestBuilder                            ),
            typeof( NUnit.Framework.Interfaces       .IImplyFixture                                 ),
            "#### Extensibility/ApplyToTest",
            typeof( NUnit.Framework.Interfaces       .IApplyToTest                                  ),

            XX_Attributes,
            "#### Builders/Type",
            typeof( NUnit.Framework                  .SetUpFixtureAttribute                         ),
            typeof( NUnit.Framework                  .TestFixtureAttribute                          ),
            typeof( NUnit.Framework                  .TestFixtureSourceAttribute                    ),
            "#### Builders/Method",
            typeof( NUnit.Framework                  .TestAttribute                                 ),
            typeof( NUnit.Framework                  .TestCaseAttribute                             ),
            typeof( NUnit.Framework                  .TestCaseSourceAttribute                       ),
            "#### Builders/Method/CombiningStrategy",
            typeof( NUnit.Framework                  .CombiningStrategyAttribute                    ),
            typeof( NUnit.Framework                  .SequentialAttribute                           ),
            typeof( NUnit.Framework                  .PairwiseAttribute                             ),
            typeof( NUnit.Framework                  .CombinatorialAttribute                        ),
            typeof( NUnit.Framework                  .TheoryAttribute                               ),
            "### SetUp",
            typeof( NUnit.Framework                  .OneTimeSetUpAttribute                         ),
            typeof( NUnit.Framework                  .SetUpAttribute                                ),
            "### TearDown",
            typeof( NUnit.Framework                  .OneTimeTearDownAttribute                      ),
            typeof( NUnit.Framework                  .TearDownAttribute                             ),
            "### ParameterDataSources",
            typeof( NUnit.Framework.Interfaces       .IParameterDataSource                          ),
            typeof( NUnit.Framework                  .ValuesAttribute                               ),
            typeof( NUnit.Framework                  .ValueSourceAttribute                          ),
            typeof( NUnit.Framework                  .RandomAttribute                               ),
            typeof( NUnit.Framework                  .RangeAttribute                                ),
            "### Datapoints",
            typeof( NUnit.Framework                  .DatapointAttribute                            ),
            typeof( NUnit.Framework                  .DatapointSourceAttribute                      ),
            typeof( NUnit.Framework                  .DatapointsAttribute                           ),
            "#### Extensibility/ApplyToTest",
            typeof( NUnit.Framework                  .CategoryAttribute                             ),
            typeof( NUnit.Framework                  .OrderAttribute                                ),
            typeof( NUnit.Framework                  .ExplicitAttribute                             ),
            typeof( NUnit.Framework                  .IgnoreAttribute                               ),
            typeof( NUnit.Framework                  .IncludeExcludeAttribute                       ),
            typeof( NUnit.Framework                  .PlatformAttribute                             ),
            typeof( NUnit.Framework                  .CultureAttribute                              ),
            "#### Extensibility/ApplyToTest/Property",
            typeof( NUnit.Framework                  .PropertyAttribute                             ),
            typeof( NUnit.Framework                  .DescriptionAttribute                          ),
            typeof( NUnit.Framework                  .AuthorAttribute                               ),
            typeof( NUnit.Framework                  .TestOfAttribute                               ),
            typeof( NUnit.Framework                  .ApartmentAttribute                            ),
            typeof( NUnit.Framework                  .RequiresThreadAttribute                       ),
            typeof( NUnit.Framework                  .LevelOfParallelismAttribute                   ),

            XX_Infrastructure,
            "#### Builders",
            typeof( NUnit.Framework.Internal.Builders.NamespaceTreeBuilder                          ),
            typeof( NUnit.Framework.Internal.Builders.NUnitTestFixtureBuilder                       ),
            typeof( NUnit.Framework.Internal.Builders.NUnitTestCaseBuilder                          ),
            "#### ParameterDataProviders",
            typeof( NUnit.Framework.Interfaces       .IParameterDataProvider                         ),
            typeof( NUnit.Framework.Internal.Builders.ParameterDataProvider                          ),
            typeof( NUnit.Framework.Internal.Builders.ParameterDataSourceProvider                    ),
            typeof( NUnit.Framework.Internal.Builders.DatapointProvider                              ),
            "#### CombiningStrategies",
            typeof( NUnit.Framework.Interfaces       .ICombiningStrategy                             ),
            typeof( NUnit.Framework.Internal.Builders.CombinatorialStrategy                          ),
            typeof( NUnit.Framework.Internal.Builders.SequentialStrategy                             ),
            typeof( NUnit.Framework.Internal.Builders.PairwiseStrategy                               ),
        };


    }
}
