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
        public override Namespace[] Namespaces => new INode[] {
            "NUnit.Runner.Building".AsNamespace(),
            "AssemblyBuilder".AsGroup(),
            (TypeItem) typeof( ITestAssemblyBuilder                          ), // Builds assembly
            (TypeItem) typeof( DefaultTestAssemblyBuilder                    ),
            "TestBuilder".AsGroup(),
            (TypeItem) typeof( ISuiteBuilder                                 ), // Builds type (all fixtures of type)
            (TypeItem) typeof( DefaultSuiteBuilder                           ),
            "MethodBuilder".AsGroup(),
            (TypeItem) typeof( ITestCaseBuilder                              ), // Builds method (all tests of method)
            (TypeItem) typeof( DefaultTestCaseBuilder                        ),

            "NUnit.Runner.Building.Annotations".AsNamespace(),
            "FixtureBuilder".AsGroup(),
            (TypeItem) typeof( IFixtureBuilder                               ), // Builds fixture
            (TypeItem) typeof( IFixtureBuilder2                              ),
            (TypeItem) typeof( SetUpFixtureAttribute                         ),
            (TypeItem) typeof( TestFixtureAttribute                          ),
            (TypeItem) typeof( TestFixtureSourceAttribute                    ),
            (TypeItem) typeof( IPreFilter                                    ),
            (TypeItem) typeof( PreFilter                                     ),
            "FixtureBuilder/SetUp".AsGroup(),
            (TypeItem) typeof( OneTimeSetUpAttribute                         ),
            (TypeItem) typeof( SetUpAttribute                                ),
            "FixtureBuilder/TearDown".AsGroup(),
            (TypeItem) typeof( OneTimeTearDownAttribute                      ),
            (TypeItem) typeof( TearDownAttribute                             ),

            "TestBuilder".AsGroup(),
            (TypeItem) typeof( ITestBuilder                                  ), // Builds test
            (TypeItem) typeof( ISimpleTestBuilder                            ),
            (TypeItem) typeof( IImplyFixture                                 ),
            (TypeItem) typeof( TestAttribute                                 ),
            (TypeItem) typeof( TestCaseAttribute                             ),
            (TypeItem) typeof( TestCaseSourceAttribute                       ),
            "TestBuilder/CombiningStrategy".AsGroup(),
            (TypeItem) typeof( CombiningStrategyAttribute                    ),
            (TypeItem) typeof( SequentialAttribute                           ),
            (TypeItem) typeof( PairwiseAttribute                             ),
            (TypeItem) typeof( CombinatorialAttribute                        ),
            (TypeItem) typeof( TheoryAttribute                               ),

            "Extensibility/TestApplier".AsGroup(),
            (TypeItem) typeof( IApplyToTest                                  ),
            (TypeItem) typeof( CategoryAttribute                             ),
            (TypeItem) typeof( OrderAttribute                                ),
            (TypeItem) typeof( ExplicitAttribute                             ),
            (TypeItem) typeof( IgnoreAttribute                               ),
            (TypeItem) typeof( IncludeExcludeAttribute                       ),
            (TypeItem) typeof( PlatformAttribute                             ),
            (TypeItem) typeof( CultureAttribute                              ),
            "Extensibility/TestApplier/Property".AsGroup(),
            (TypeItem) typeof( PropertyAttribute                             ),
            (TypeItem) typeof( DescriptionAttribute                          ),
            (TypeItem) typeof( AuthorAttribute                               ),
            (TypeItem) typeof( TestOfAttribute                               ),
            (TypeItem) typeof( ApartmentAttribute                            ),
            (TypeItem) typeof( RequiresThreadAttribute                       ),
            (TypeItem) typeof( LevelOfParallelismAttribute                   ),

            "Data/DataSource".AsGroup(),
            (TypeItem) typeof( IParameterDataSource                          ),
            (TypeItem) typeof( ValuesAttribute                               ),
            (TypeItem) typeof( ValueSourceAttribute                          ),
            (TypeItem) typeof( RandomAttribute                               ),
            (TypeItem) typeof( RangeAttribute                                ),
            "Data/DataPoint".AsGroup(),
            (TypeItem) typeof( DatapointAttribute                            ),
            (TypeItem) typeof( DatapointSourceAttribute                      ),
            (TypeItem) typeof( DatapointsAttribute                           ),

            "NUnit.Infrastructure".AsNamespace(),
            "Builders".AsGroup(),
            (TypeItem) typeof( NamespaceTreeBuilder                          ),
            (TypeItem) typeof( NUnitTestFixtureBuilder                       ),
            (TypeItem) typeof( NUnitTestCaseBuilder                          ),
            "DataProvider".AsGroup(),
            (TypeItem) typeof( IParameterDataProvider                        ),
            (TypeItem) typeof( ParameterDataProvider                         ),
            (TypeItem) typeof( ParameterDataSourceProvider                   ),
            (TypeItem) typeof( DatapointProvider                             ),
            "DataCombiner".AsGroup(),
            (TypeItem) typeof( ICombiningStrategy                            ),
            (TypeItem) typeof( CombinatorialStrategy                         ),
            (TypeItem) typeof( SequentialStrategy                            ),
            (TypeItem) typeof( PairwiseStrategy                              ),
            (TypeItem) typeof( PairwiseStrategy.FleaRand                     ),
            (TypeItem) typeof( PairwiseStrategy.FeatureInfo                  ),
            (TypeItem) typeof( PairwiseStrategy.FeatureTuple                 ),
            (TypeItem) typeof( PairwiseStrategy.TestCaseInfo                 ),
            (TypeItem) typeof( PairwiseStrategy.PairwiseTestCaseGenerator    ),
            "Utils".AsGroup(),
            (TypeItem) typeof( PlatformHelper                                ),
            (TypeItem) typeof( CultureDetector                               ),
            (TypeItem) typeof( ProviderCache                                 ),
            (TypeItem) typeof( ParamAttributeTypeConversions                 ),
            "Utils/TestNameGenerator".AsGroup(),
            (TypeItem) typeof( TestNameGenerator                             ),
            "Utils/ValueGenerator".AsGroup(),
            (TypeItem) typeof( ValueGenerator                                ),
            (TypeItem) typeof( ValueGenerator.Step                           ),
            (TypeItem) typeof( ValueGenerator<>                              ),
            (TypeItem) typeof( ValueGenerator<>.Step                         ),
            (TypeItem) typeof( ValueGenerator<>.ComparableStep<>             ),
        }.ToHierarchy();


    }
}
