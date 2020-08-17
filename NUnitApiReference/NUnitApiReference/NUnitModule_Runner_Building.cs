// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ApiReference;
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
                TypeOf( "NUnit.Framework.Internal         .PreFilter+FilterElementType"                  ),
                TypeOf( "NUnit.Framework.Internal         .PreFilter+FilterElement"                      ),
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
                TypeOf( "NUnit.Framework                  .RandomAttribute+RandomDataSource"             ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+RandomDataSource`1"           ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+RandomDataConverter"          ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+IntDataSource"                ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+UIntDataSource"               ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+LongDataSource"               ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+ULongDataSource"              ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+ShortDataSource"              ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+UShortDataSource"             ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+DoubleDataSource"             ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+FloatDataSource"              ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+ByteDataSource"               ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+SByteDataSource"              ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+EnumDataSource"               ),
                TypeOf( "NUnit.Framework                  .RandomAttribute+DecimalDataSource"            ),
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
                TypeOf( "NUnit.Framework.Internal.Builders.ProviderCache+CacheEntry"                    ),
                TypeOf( "NUnit.Framework.Internal         .ParamAttributeTypeConversions"               ),
                // Utils/TestNameGenerator
                typeof( NUnit.Framework.Internal          .TestNameGenerator                             ),
                TypeOf( "NUnit.Framework.Internal         .TestNameGenerator+NameFragment"               ),
                TypeOf( "NUnit.Framework.Internal         .TestNameGenerator+TestIDFragment"             ),
                TypeOf( "NUnit.Framework.Internal         .TestNameGenerator+FixedTextFragment"          ),
                TypeOf( "NUnit.Framework.Internal         .TestNameGenerator+MethodNameFragment"         ),
                TypeOf( "NUnit.Framework.Internal         .TestNameGenerator+NamespaceFragment"          ),
                TypeOf( "NUnit.Framework.Internal         .TestNameGenerator+MethodFullNameFragment"     ),
                TypeOf( "NUnit.Framework.Internal         .TestNameGenerator+ClassNameFragment"          ),
                TypeOf( "NUnit.Framework.Internal         .TestNameGenerator+ClassFullNameFragment"      ),
                TypeOf( "NUnit.Framework.Internal         .TestNameGenerator+ArgListFragment"            ),
                TypeOf( "NUnit.Framework.Internal         .TestNameGenerator+ArgumentFragment"           ),
                // Utils/ValueGenerator
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator"                               ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator`1"                             ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+ByteValueGenerator"            ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+Step"                          ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+DecimalValueGenerator"         ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+DefaultValueGenerator`1"       ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+DoubleValueGenerator"          ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+Int16ValueGenerator"           ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+Int32ValueGenerator"           ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+Int64ValueGenerator"           ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+SByteValueGenerator"           ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+SingleValueGenerator"          ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+UInt16ValueGenerator"          ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+UInt32ValueGenerator"          ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator+UInt64ValueGenerator"          ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator`1+ComparableStep`1"            ),
                TypeOf( "NUnit.Framework.Internal         .ValueGenerator`1+Step"                        )
            ),
        };


    }
}
