// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class NUnitModule_Runner_Building : Module {

        private static readonly HeaderItem X_Runner_Building                = HeaderItem.H1( "Runner.Building" );
        private static readonly HeaderItem XX_Runner_Building               = HeaderItem.H2( "Runner.Building" );
        private static readonly HeaderItem XX_Runner_Building_Extensibility = HeaderItem.H2( "Runner.Building.Extensibility" );
        private static readonly HeaderItem XX_Infrastructure                = HeaderItem.H2( "Infrastructure" );


        public override Item[] Items => new Item[] {
            X_Runner_Building,

            XX_Runner_Building,
            "AssemblyBuilder",
            typeof( NUnit.Framework.Api              .ITestAssemblyBuilder                          ),
            typeof( NUnit.Framework.Api              .DefaultTestAssemblyBuilder                    ),
            "TypeBuilder",
            typeof( NUnit.Framework.Interfaces       .ISuiteBuilder                                 ),
            typeof( NUnit.Framework.Internal.Builders.DefaultSuiteBuilder                           ),
            "TypeBuilder/Fixture",
            typeof( NUnit.Framework.Interfaces       .IFixtureBuilder                               ),
            typeof( NUnit.Framework.Interfaces       .IFixtureBuilder2                              ),
            typeof( NUnit.Framework                  .SetUpFixtureAttribute                         ),
            typeof( NUnit.Framework                  .TestFixtureAttribute                          ),
            typeof( NUnit.Framework                  .TestFixtureSourceAttribute                    ),
            "MethodBuilder",
            typeof( NUnit.Framework.Interfaces       .ITestCaseBuilder                              ),
            typeof( NUnit.Framework.Internal.Builders.DefaultTestCaseBuilder                        ),
            "MethodBuilder/Test",
            typeof( NUnit.Framework.Interfaces       .ITestBuilder                                  ),
            typeof( NUnit.Framework.Interfaces       .ISimpleTestBuilder                            ),
            typeof( NUnit.Framework.Interfaces       .IImplyFixture                                 ),
            typeof( NUnit.Framework                  .TestAttribute                                 ),
            typeof( NUnit.Framework                  .TestCaseAttribute                             ),
            typeof( NUnit.Framework                  .TestCaseSourceAttribute                       ),
            "MethodBuilder/CombiningStrategy",
            typeof( NUnit.Framework                  .CombiningStrategyAttribute                    ),
            typeof( NUnit.Framework                  .SequentialAttribute                           ),
            typeof( NUnit.Framework                  .PairwiseAttribute                             ),
            typeof( NUnit.Framework                  .CombinatorialAttribute                        ),
            typeof( NUnit.Framework                  .TheoryAttribute                               ),

            "SetUp",
            typeof( NUnit.Framework                  .OneTimeSetUpAttribute                         ),
            typeof( NUnit.Framework                  .SetUpAttribute                                ),
            "TearDown",
            typeof( NUnit.Framework                  .OneTimeTearDownAttribute                      ),
            typeof( NUnit.Framework                  .TearDownAttribute                             ),
            "DataSource",
            typeof( NUnit.Framework.Interfaces       .IParameterDataSource                          ),
            typeof( NUnit.Framework                  .ValuesAttribute                               ),
            typeof( NUnit.Framework                  .ValueSourceAttribute                          ),
            typeof( NUnit.Framework                  .RandomAttribute                               ),
            typeof( NUnit.Framework                  .RangeAttribute                                ),
            "DataPoint",
            typeof( NUnit.Framework                  .DatapointAttribute                            ),
            typeof( NUnit.Framework                  .DatapointSourceAttribute                      ),
            typeof( NUnit.Framework                  .DatapointsAttribute                           ),

            XX_Runner_Building_Extensibility,
            "TestApplier",
            typeof( NUnit.Framework.Interfaces       .IApplyToTest                                  ),
            typeof( NUnit.Framework                  .CategoryAttribute                             ),
            typeof( NUnit.Framework                  .OrderAttribute                                ),
            typeof( NUnit.Framework                  .ExplicitAttribute                             ),
            typeof( NUnit.Framework                  .IgnoreAttribute                               ),
            typeof( NUnit.Framework                  .IncludeExcludeAttribute                       ),
            typeof( NUnit.Framework                  .PlatformAttribute                             ),
            typeof( NUnit.Framework                  .CultureAttribute                              ),
            "TestApplier/Property",
            typeof( NUnit.Framework                  .PropertyAttribute                             ),
            typeof( NUnit.Framework                  .DescriptionAttribute                          ),
            typeof( NUnit.Framework                  .AuthorAttribute                               ),
            typeof( NUnit.Framework                  .TestOfAttribute                               ),
            typeof( NUnit.Framework                  .ApartmentAttribute                            ),
            typeof( NUnit.Framework                  .RequiresThreadAttribute                       ),
            typeof( NUnit.Framework                  .LevelOfParallelismAttribute                   ),

            XX_Infrastructure,
            typeof( NUnit.Framework.Internal         .PlatformHelper                                ),
            typeof( NUnit.Framework.Internal         .CultureDetector                               ),
            "Builders",
            typeof( NUnit.Framework.Internal.Builders.NamespaceTreeBuilder                          ),
            typeof( NUnit.Framework.Internal.Builders.NUnitTestFixtureBuilder                       ),
            typeof( NUnit.Framework.Internal.Builders.NUnitTestCaseBuilder                          ),
            typeof( NUnit.Framework.Internal         .TestNameGenerator                             ),
            "DataProvider",
            typeof( NUnit.Framework.Interfaces       .IParameterDataProvider                        ),
            typeof( NUnit.Framework.Internal.Builders.ParameterDataProvider                         ),
            typeof( NUnit.Framework.Internal.Builders.ParameterDataSourceProvider                   ),
            typeof( NUnit.Framework.Internal.Builders.DatapointProvider                             ),
            "DataCombiner",
            typeof( NUnit.Framework.Interfaces       .ICombiningStrategy                            ),
            typeof( NUnit.Framework.Internal.Builders.CombinatorialStrategy                         ),
            typeof( NUnit.Framework.Internal.Builders.SequentialStrategy                            ),
            typeof( NUnit.Framework.Internal.Builders.PairwiseStrategy                              ),
        };


    }
}
