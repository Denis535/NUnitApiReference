// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NUnit;
    using NUnit.Framework;
    using NUnit.Framework.Api;
    using NUnit.Framework.Interfaces;
    using NUnit.Framework.Internal;
    using NUnit.Framework.Internal.Builders;
    using ProjectArchitecture.Model;

    public class NUnitModule_Runner_Building : Module {

        public override string Name => "NUnit.Runner.Building";
        public override Namespace[] Namespaces => new object[] {
            "NUnit.Runner.Building".AsNamespace(),
            "AssemblyBuilder".AsGroup(),
            typeof( ITestAssemblyBuilder                          ), // Builds assembly
            typeof( DefaultTestAssemblyBuilder                    ),
            "TestBuilder".AsGroup(),
            typeof( ISuiteBuilder                                 ), // Builds type (all fixtures of type)
            typeof( DefaultSuiteBuilder                           ),
            "MethodBuilder".AsGroup(),
            typeof( ITestCaseBuilder                              ), // Builds method (all tests of method)
            typeof( DefaultTestCaseBuilder                        ),

            "NUnit.Runner.Building.Annotations".AsNamespace(),
            "FixtureBuilder".AsGroup(),
            typeof( IFixtureBuilder                               ), // Builds fixture
            typeof( IFixtureBuilder2                              ),
            typeof( SetUpFixtureAttribute                         ),
            typeof( TestFixtureAttribute                          ),
            typeof( TestFixtureSourceAttribute                    ),
            typeof( IPreFilter                                    ),
            typeof( PreFilter                                     ),
            "FixtureBuilder/SetUp".AsGroup(),
            typeof( OneTimeSetUpAttribute                         ),
            typeof( SetUpAttribute                                ),
            "FixtureBuilder/TearDown".AsGroup(),
            typeof( OneTimeTearDownAttribute                      ),
            typeof( TearDownAttribute                             ),

            "TestBuilder".AsGroup(),
            typeof( ITestBuilder                                  ), // Builds test
            typeof( ISimpleTestBuilder                            ),
            typeof( IImplyFixture                                 ),
            typeof( TestAttribute                                 ),
            typeof( TestCaseAttribute                             ),
            typeof( TestCaseSourceAttribute                       ),
            "TestBuilder/CombiningStrategy".AsGroup(),
            typeof( CombiningStrategyAttribute                    ),
            typeof( SequentialAttribute                           ),
            typeof( PairwiseAttribute                             ),
            typeof( CombinatorialAttribute                        ),
            typeof( TheoryAttribute                               ),

            "Extensibility/TestApplier".AsGroup(),
            typeof( IApplyToTest                                  ),
            typeof( CategoryAttribute                             ),
            typeof( OrderAttribute                                ),
            typeof( ExplicitAttribute                             ),
            typeof( IgnoreAttribute                               ),
            typeof( IncludeExcludeAttribute                       ),
            typeof( PlatformAttribute                             ),
            typeof( CultureAttribute                              ),
            "Extensibility/TestApplier/Property".AsGroup(),
            typeof( PropertyAttribute                             ),
            typeof( DescriptionAttribute                          ),
            typeof( AuthorAttribute                               ),
            typeof( TestOfAttribute                               ),
            typeof( ApartmentAttribute                            ),
            typeof( RequiresThreadAttribute                       ),
            typeof( LevelOfParallelismAttribute                   ),

            "Data/DataSource".AsGroup(),
            typeof( IParameterDataSource                          ),
            typeof( ValuesAttribute                               ),
            typeof( ValueSourceAttribute                          ),
            typeof( RandomAttribute                               ),
            typeof( RangeAttribute                                ),
            "Data/DataPoint".AsGroup(),
            typeof( DatapointAttribute                            ),
            typeof( DatapointSourceAttribute                      ),
            typeof( DatapointsAttribute                           ),

            "NUnit.Infrastructure".AsNamespace(),
            "Builders".AsGroup(),
            typeof( NamespaceTreeBuilder                          ),
            typeof( NUnitTestFixtureBuilder                       ),
            typeof( NUnitTestCaseBuilder                          ),
            "DataProvider".AsGroup(),
            typeof( IParameterDataProvider                        ),
            typeof( ParameterDataProvider                         ),
            typeof( ParameterDataSourceProvider                   ),
            typeof( DatapointProvider                             ),
            "DataCombiner".AsGroup(),
            typeof( ICombiningStrategy                            ),
            typeof( CombinatorialStrategy                         ),
            typeof( SequentialStrategy                            ),
            typeof( PairwiseStrategy                              ),
            typeof( PairwiseStrategy.FleaRand                     ),
            typeof( PairwiseStrategy.FeatureInfo                  ),
            typeof( PairwiseStrategy.FeatureTuple                 ),
            typeof( PairwiseStrategy.TestCaseInfo                 ),
            typeof( PairwiseStrategy.PairwiseTestCaseGenerator    ),
            "Utils".AsGroup(),
            typeof( PlatformHelper                                ),
            typeof( CultureDetector                               ),
            typeof( ProviderCache                                 ),
            typeof( ParamAttributeTypeConversions                 ),
            "Utils/TestNameGenerator".AsGroup(),
            typeof( TestNameGenerator                             ),
            "Utils/ValueGenerator".AsGroup(),
            typeof( ValueGenerator                                ),
            typeof( ValueGenerator<>                              ),
            typeof( ValueGenerator.Step                           ),
            typeof( ValueGenerator<>.Step                         ),
            typeof( ValueGenerator<>.ComparableStep<>             ),
        }.ToHierarchy();


    }
}
