// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ArchitectureModel;
    using static NUnitProject;

    public class NUnitModule_Runner_Building : Module {

        public override string Name => "NUnit.Runner.Building";
        public override Namespace[] Namespaces => new Namespace[] {
            new Namespace(
                "NUnit.Runner.Building",
                // AssemblyBuilder
                typeof( NUnit.Framework.Api               .ITestAssemblyBuilder                          ), // Builds assembly
                typeof( NUnit.Framework.Api               .DefaultTestAssemblyBuilder                    ),
                // TypeBuilder
                typeof( NUnit.Framework.Interfaces        .ISuiteBuilder                                 ), // Builds type (all fixtures of type)
                typeof( NUnit.Framework.Internal.Builders .DefaultSuiteBuilder                           ),
                // MethodBuilder
                typeof( NUnit.Framework.Interfaces        .ITestCaseBuilder                              ), // Builds method (all tests of method)
                typeof( NUnit.Framework.Internal.Builders .DefaultTestCaseBuilder                        )
            ),
            new Namespace(
                "NUnit.Runner.Building.Annotations",
                // FixtureBuilder
                typeof( NUnit.Framework.Interfaces        .IFixtureBuilder                               ), // Builds fixture
                typeof( NUnit.Framework.Interfaces        .IFixtureBuilder2                              ),
                typeof( NUnit.Framework                   .SetUpFixtureAttribute                         ),
                typeof( NUnit.Framework                   .TestFixtureAttribute                          ),
                typeof( NUnit.Framework                   .TestFixtureSourceAttribute                    ),
                typeof( NUnit.Framework.Interfaces        .IPreFilter                                    ),
                TypeOf( "NUnit.Framework.Internal         .PreFilter"                                    ),
                // FixtureBuilder/SetUp
                typeof( NUnit.Framework                   .OneTimeSetUpAttribute                         ),
                typeof( NUnit.Framework                   .SetUpAttribute                                ),
                // FixtureBuilder/TearDown
                typeof( NUnit.Framework                   .OneTimeTearDownAttribute                      ),
                typeof( NUnit.Framework                   .TearDownAttribute                             ),
                // TestBuilder
                typeof( NUnit.Framework.Interfaces        .ITestBuilder                                  ), // Builds test
                typeof( NUnit.Framework.Interfaces        .ISimpleTestBuilder                            ),
                typeof( NUnit.Framework.Interfaces        .IImplyFixture                                 ),
                typeof( NUnit.Framework                   .TestAttribute                                 ),
                typeof( NUnit.Framework                   .TestCaseAttribute                             ),
                typeof( NUnit.Framework                   .TestCaseSourceAttribute                       ),
                // TestBuilder/CombiningStrategy
                typeof( NUnit.Framework                   .CombiningStrategyAttribute                    ),
                typeof( NUnit.Framework                   .SequentialAttribute                           ),
                typeof( NUnit.Framework                   .PairwiseAttribute                             ),
                typeof( NUnit.Framework                   .CombinatorialAttribute                        ),
                typeof( NUnit.Framework                   .TheoryAttribute                               ),

                // Extensibility/TestApplier
                typeof( NUnit.Framework.Interfaces        .IApplyToTest                                  ),
                typeof( NUnit.Framework                   .CategoryAttribute                             ),
                typeof( NUnit.Framework                   .OrderAttribute                                ),
                typeof( NUnit.Framework                   .ExplicitAttribute                             ),
                typeof( NUnit.Framework                   .IgnoreAttribute                               ),
                typeof( NUnit.Framework                   .IncludeExcludeAttribute                       ),
                typeof( NUnit.Framework                   .PlatformAttribute                             ),
                typeof( NUnit.Framework                   .CultureAttribute                              ),
                // Extensibility/TestApplier/Property
                typeof( NUnit.Framework                   .PropertyAttribute                             ),
                typeof( NUnit.Framework                   .DescriptionAttribute                          ),
                typeof( NUnit.Framework                   .AuthorAttribute                               ),
                typeof( NUnit.Framework                   .TestOfAttribute                               ),
                typeof( NUnit.Framework                   .ApartmentAttribute                            ),
                typeof( NUnit.Framework                   .RequiresThreadAttribute                       ),
                typeof( NUnit.Framework                   .LevelOfParallelismAttribute                   ),

                // Data/DataSource
                typeof( NUnit.Framework.Interfaces        .IParameterDataSource                          ),
                typeof( NUnit.Framework                   .ValuesAttribute                               ),
                typeof( NUnit.Framework                   .ValueSourceAttribute                          ),
                typeof( NUnit.Framework                   .RandomAttribute                               ),
                typeof( NUnit.Framework                   .RangeAttribute                                ),
                // Data/DataPoint
                typeof( NUnit.Framework                   .DatapointAttribute                            ),
                typeof( NUnit.Framework                   .DatapointSourceAttribute                      ),
                typeof( NUnit.Framework                   .DatapointsAttribute                           )
            ),
            new Namespace(
                "NUnit.Infrastructure",
                // Builders
                typeof( NUnit.Framework.Internal.Builders .NamespaceTreeBuilder                          ),
                typeof( NUnit.Framework.Internal.Builders .NUnitTestFixtureBuilder                       ),
                typeof( NUnit.Framework.Internal.Builders .NUnitTestCaseBuilder                          ),
                // DataProvider
                typeof( NUnit.Framework.Interfaces        .IParameterDataProvider                        ),
                typeof( NUnit.Framework.Internal.Builders .ParameterDataProvider                         ),
                typeof( NUnit.Framework.Internal.Builders .ParameterDataSourceProvider                   ),
                typeof( NUnit.Framework.Internal.Builders .DatapointProvider                             ),
                // DataCombiner
                typeof( NUnit.Framework.Interfaces        .ICombiningStrategy                            ),
                typeof( NUnit.Framework.Internal.Builders .CombinatorialStrategy                         ),
                typeof( NUnit.Framework.Internal.Builders .SequentialStrategy                            ),
                typeof( NUnit.Framework.Internal.Builders .PairwiseStrategy                              ),
                TypeOf( "NUnit.Framework.Internal.Builders.PairwiseStrategy+FleaRand"                   ),
                TypeOf( "NUnit.Framework.Internal.Builders.PairwiseStrategy+FeatureInfo"                ),
                TypeOf( "NUnit.Framework.Internal.Builders.PairwiseStrategy+FeatureTuple"               ),
                TypeOf( "NUnit.Framework.Internal.Builders.PairwiseStrategy+TestCaseInfo"               ),
                TypeOf( "NUnit.Framework.Internal.Builders.PairwiseStrategy+PairwiseTestCaseGenerator"  ),
                // Utils
                typeof( NUnit.Framework.Internal          .PlatformHelper                               ),
                typeof( NUnit.Framework.Internal          .CultureDetector                              ),
                TypeOf( "NUnit.Framework.Internal.Builders.ProviderCache"                               ),
                TypeOf( "NUnit.Framework.Internal         .ParamAttributeTypeConversions"               ),
                // Utils/TestNameGenerator
                typeof( NUnit.Framework.Internal          .TestNameGenerator                             ),
                // Utils/ValueGenerator
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator"                               ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator`1"                             ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+Step"                          ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator`1+Step"                        ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator`1+ComparableStep`1"            )
            ),
        };


    }
}
