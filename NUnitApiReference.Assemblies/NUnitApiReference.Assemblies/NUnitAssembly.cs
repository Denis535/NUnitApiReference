// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference.Assemblies {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class NUnitAssembly {


        public static readonly Type[] Types = new[] {
            // Api
            typeof( NUnit.Framework.Api.FrameworkController                                      ),
            typeof( NUnit.Framework.Api.FrameworkController.FrameworkControllerAction            ),
            typeof( NUnit.Framework.Api.FrameworkController.LoadTestsAction                      ),
            typeof( NUnit.Framework.Api.FrameworkController.CountTestsAction                     ),
            typeof( NUnit.Framework.Api.FrameworkController.ExploreTestsAction                   ),
            typeof( NUnit.Framework.Api.FrameworkController.RunTestsAction                       ),
            typeof( NUnit.Framework.Api.FrameworkController.RunAsyncAction                       ),
            typeof( NUnit.Framework.Api.FrameworkController.StopRunAction                        ),

            // Runner
            typeof( NUnit.Framework.Api.ITestAssemblyRunner                                      ),
            typeof( NUnit.Framework.Api.NUnitTestAssemblyRunner                                  ),
            typeof( NUnit.Framework.Interfaces.IPreFilter                                        ),
            typeof( NUnit.Framework.Interfaces.ITestFilter                                       ),
            typeof( NUnit.Framework.Internal.TestFilter                                          ),

            // Building/Builders/Assembly
            typeof( NUnit.Framework.Api.ITestAssemblyBuilder                                     ),
            typeof( NUnit.Framework.Api.DefaultTestAssemblyBuilder                               ),
            typeof( NUnit.Framework.Internal.Builders.NamespaceTreeBuilder                       ),
            // Building/Builders/Type
            typeof( NUnit.Framework.Interfaces.ISuiteBuilder                                     ),
            typeof( NUnit.Framework.Internal.Builders.DefaultSuiteBuilder                        ),
            // Building/Builders/Type
            typeof( NUnit.Framework.Interfaces.IFixtureBuilder                                   ),
            typeof( NUnit.Framework.Interfaces.IFixtureBuilder2                                  ),
            typeof( NUnit.Framework.SetUpFixtureAttribute                                        ),
            typeof( NUnit.Framework.TestFixtureAttribute                                         ),
            typeof( NUnit.Framework.TestFixtureSourceAttribute                                   ),
            typeof( NUnit.Framework.Internal.Builders.NUnitTestFixtureBuilder                    ),
            // Building/Builders/Method
            typeof( NUnit.Framework.Interfaces.ITestCaseBuilder                                  ),
            typeof( NUnit.Framework.Internal.Builders.DefaultTestCaseBuilder                     ),
            // Building/Builders/Method
            typeof( NUnit.Framework.Interfaces.ITestBuilder                                      ),
            typeof( NUnit.Framework.Interfaces.ISimpleTestBuilder                                ),
            typeof( NUnit.Framework.Interfaces.IImplyFixture                                     ),
            typeof( NUnit.Framework.TestAttribute                                                ),
            typeof( NUnit.Framework.TestCaseAttribute                                            ),
            typeof( NUnit.Framework.TestCaseSourceAttribute                                      ),
            typeof( NUnit.Framework.Internal.Builders.NUnitTestCaseBuilder                       ),
            // Building/Builders/Method/CombiningStrategy
            typeof( NUnit.Framework.CombiningStrategyAttribute                                   ),
            typeof( NUnit.Framework.SequentialAttribute                                          ),
            typeof( NUnit.Framework.PairwiseAttribute                                            ),
            typeof( NUnit.Framework.CombinatorialAttribute                                       ),
            typeof( NUnit.Framework.TheoryAttribute                                              ),
            // Building/Attributes/Test
            typeof( NUnit.Framework.Interfaces.IApplyToTest                                      ),
            typeof( NUnit.Framework.CategoryAttribute                                            ),
            typeof( NUnit.Framework.OrderAttribute                                               ),
            typeof( NUnit.Framework.ExplicitAttribute                                            ),
            typeof( NUnit.Framework.IgnoreAttribute                                              ),
            typeof( NUnit.Framework.IncludeExcludeAttribute                                      ),
            typeof( NUnit.Framework.PlatformAttribute                                            ),
            typeof( NUnit.Framework.CultureAttribute                                             ),
            // Building/Attributes/Test/Property
            typeof( NUnit.Framework.PropertyAttribute                                            ),
            typeof( NUnit.Framework.DescriptionAttribute                                         ),
            typeof( NUnit.Framework.AuthorAttribute                                              ),
            typeof( NUnit.Framework.TestOfAttribute                                              ),
            typeof( NUnit.Framework.ApartmentAttribute                                           ),
            typeof( NUnit.Framework.RequiresThreadAttribute                                      ),
            typeof( NUnit.Framework.LevelOfParallelismAttribute                                  ),
            typeof( NUnit.Framework.ParallelScope                                                ),
            // Building/Attributes/SetUp
            typeof( NUnit.Framework.OneTimeSetUpAttribute                                        ),
            typeof( NUnit.Framework.SetUpAttribute                                               ),
            // Building/Attributes/TearDown
            typeof( NUnit.Framework.OneTimeTearDownAttribute                                     ),
            typeof( NUnit.Framework.TearDownAttribute                                            ),
            // Building/Attributes/Data/Parameter
            typeof( NUnit.Framework.Interfaces.IParameterDataSource                              ),
            typeof( NUnit.Framework.ValuesAttribute                                              ),
            typeof( NUnit.Framework.ValueSourceAttribute                                         ),
            typeof( NUnit.Framework.RandomAttribute                                              ),
            typeof( NUnit.Framework.RangeAttribute                                               ),
            // Building/Attributes/Data/Point
            typeof( NUnit.Framework.DatapointAttribute                                           ),
            typeof( NUnit.Framework.DatapointSourceAttribute                                     ),
            typeof( NUnit.Framework.DatapointsAttribute                                          ),
            // Building/Infrastructure/Data/Provider
            typeof( NUnit.Framework.Interfaces.IParameterDataProvider                            ),
            typeof( NUnit.Framework.Internal.Builders.ParameterDataProvider                      ),
            typeof( NUnit.Framework.Internal.Builders.ParameterDataSourceProvider                ),
            typeof( NUnit.Framework.Internal.Builders.DatapointProvider                          ),
            // Building/Infrastructure/Data/Combiner
            typeof( NUnit.Framework.Interfaces.ICombiningStrategy                                ),
            typeof( NUnit.Framework.Internal.Builders.CombinatorialStrategy                      ),
            typeof( NUnit.Framework.Internal.Builders.SequentialStrategy                         ),
            typeof( NUnit.Framework.Internal.Builders.PairwiseStrategy                           ),

            // Execution/Context
            typeof( NUnit.Framework.Internal.TestExecutionContext                                ),
            typeof( NUnit.Framework.Internal.TestExecutionContext.IsolatedContext                ),
            typeof( NUnit.Framework.Internal.TestExecutionContext.AdhocContext                   ),
            typeof( NUnit.Framework.Internal.TestExecutionStatus                                 ),
            typeof( NUnit.Framework.TestContext                                                  ),
            typeof( NUnit.Framework.TestContext.TestAdapter                                      ),
            typeof( NUnit.Framework.TestContext.ResultAdapter                                    ),
            typeof( NUnit.Framework.TestContext.PropertyBagAdapter                               ),
            typeof( NUnit.Framework.TestParameters                                               ),
            // Execution/WorkItem
            typeof( NUnit.Framework.Internal.Execution.WorkItem                                  ),
            typeof( NUnit.Framework.Internal.Execution.WorkItemState                             ),
            typeof( NUnit.Framework.Internal.Execution.ParallelExecutionStrategy                 ),
            typeof( NUnit.Framework.Internal.Execution.SimpleWorkItem                            ),
            typeof( NUnit.Framework.Internal.Execution.CompositeWorkItem                         ),
            typeof( NUnit.Framework.Internal.Execution.CompositeWorkItem.OneTimeTearDownWorkItem ),
            typeof( NUnit.Framework.Internal.Execution.WorkItemBuilder                           ),
            // Execution/WorkItem/Dispatcher
            typeof( NUnit.Framework.Internal.Execution.IWorkItemDispatcher                       ),
            typeof( NUnit.Framework.Internal.Execution.MainThreadWorkItemDispatcher              ),
            typeof( NUnit.Framework.Internal.Execution.SimpleWorkItemDispatcher                  ),
            typeof( NUnit.Framework.Internal.Execution.ParallelWorkItemDispatcher                ),
            // Execution/WorkItem/Dispatcher/ParallelWorkItemDispatcher
            typeof( NUnit.Framework.Internal.Execution.WorkShift                                 ),
            typeof( NUnit.Framework.Internal.Execution.ShiftChangeEventHandler                   ),
            typeof( NUnit.Framework.Internal.Execution.TestWorker                                ),
            typeof( NUnit.Framework.Internal.Execution.TestWorker.TestWorkerEventHandler         ),
            typeof( NUnit.Framework.Internal.Execution.WorkItemQueue                             ),
            typeof( NUnit.Framework.Internal.Execution.WorkItemQueueState                        ),
            // Execution/Commands/Test
            typeof( NUnit.Framework.Internal.Commands.TestCommand                                ),
            typeof( NUnit.Framework.Internal.Commands.TestMethodCommand                          ),
            typeof( NUnit.Framework.Internal.Commands.EmptyTestCommand                           ),
            typeof( NUnit.Framework.Internal.Commands.SkipCommand                                ),
            typeof( NUnit.Framework.Internal.Commands.DelegatingTestCommand                      ),
            // Execution/Commands/Test/Before
            typeof( NUnit.Framework.Internal.Commands.BeforeTestCommand                          ),
            typeof( NUnit.Framework.Internal.Commands.BeforeTestActionCommand                    ),
            typeof( NUnit.Framework.Internal.Commands.ConstructFixtureCommand                    ),
            typeof( NUnit.Framework.Internal.Commands.OneTimeSetUpCommand                        ),
            // Execution/Commands/Test/After
            typeof( NUnit.Framework.Internal.Commands.AfterTestCommand                           ),
            typeof( NUnit.Framework.Internal.Commands.AfterTestActionCommand                     ),
            typeof( NUnit.Framework.Internal.Commands.DisposeFixtureCommand                      ),
            typeof( NUnit.Framework.Internal.Commands.OneTimeTearDownCommand                     ),
            typeof( NUnit.Framework.Internal.Commands.MaxTimeCommand                             ),
            typeof( NUnit.Framework.Internal.Commands.TheoryResultCommand                        ),
            // Execution/Commands/Test/BeforeAndAfter
            typeof( NUnit.Framework.Internal.Commands.BeforeAndAfterTestCommand                  ),
            typeof( NUnit.Framework.Internal.Commands.TestActionCommand                          ),
            typeof( NUnit.Framework.Internal.Commands.TestActionItem                             ),
            typeof( NUnit.Framework.Internal.Commands.SetUpTearDownCommand                       ),
            typeof( NUnit.Framework.Internal.Commands.SetUpTearDownItem                          ),
            typeof( NUnit.Framework.Internal.Commands.TimeoutCommand                             ),
            // Execution/Attributes/Context
            typeof( NUnit.Framework.Interfaces.IApplyToContext                                   ),
            typeof( NUnit.Framework.DefaultFloatingPointToleranceAttribute                       ),
            typeof( NUnit.Framework.SingleThreadedAttribute                                      ),
            typeof( NUnit.Framework.SetCultureAttribute                                          ),
            typeof( NUnit.Framework.SetUICultureAttribute                                        ),
            typeof( NUnit.Framework.ParallelizableAttribute                                      ),
            typeof( NUnit.Framework.NonParallelizableAttribute                                   ),
            typeof( NUnit.Framework.TimeoutAttribute                                             ),
            // Execution/Attributes/Commands
            typeof( NUnit.Framework.Interfaces.ICommandWrapper                                   ),
            typeof( NUnit.Framework.Interfaces.IWrapSetUpTearDown                                ),
            typeof( NUnit.Framework.Interfaces.IWrapTestMethod                                   ),
            typeof( NUnit.Framework.Interfaces.IRepeatTest                                       ),
            typeof( NUnit.Framework.RepeatAttribute                                              ),
            typeof( NUnit.Framework.RepeatAttribute.RepeatedTestCommand                          ),
            typeof( NUnit.Framework.MaxTimeAttribute                                             ),
            typeof( NUnit.Framework.RetryAttribute                                               ),
            typeof( NUnit.Framework.RetryAttribute.RetryCommand                                  ),
            // Execution/Attributes/Actions
            typeof( NUnit.Framework.ITestAction                                                  ),
            typeof( NUnit.Framework.ActionTargets                                                ),
            typeof( NUnit.Framework.TestActionAttribute                                          ),

            // Test
            typeof( NUnit.Framework.Interfaces.ITest                                             ),
            typeof( NUnit.Framework.Interfaces.RunState                                          ),
            typeof( NUnit.Framework.Internal.Test                                                ),
            // Test/Suite
            typeof( NUnit.Framework.Internal.TestSuite                                           ),
            // Test/Assembly
            typeof( NUnit.Framework.Internal.TestAssembly                                        ),
            // Test/Fixture
            typeof( NUnit.Framework.Internal.SetUpFixture                                        ),
            typeof( NUnit.Framework.Internal.TestFixture                                         ),
            typeof( NUnit.Framework.Internal.ParameterizedFixtureSuite                           ),
            // Test/Method
            typeof( NUnit.Framework.Internal.TestMethod                                          ),
            typeof( NUnit.Framework.Internal.ParameterizedMethodSuite                            ),
            // Test/Data
            typeof( NUnit.Framework.Interfaces.ITestData                                         ),
            typeof( NUnit.Framework.Internal.TestParameters                                      ),
            // Test/Data/Fixture
            typeof( NUnit.Framework.Interfaces.ITestFixtureData                                  ),
            typeof( NUnit.Framework.Internal.TestFixtureParameters                               ),
            typeof( NUnit.Framework.TestFixtureData                                              ),
            // Test/Data/Case
            typeof( NUnit.Framework.Interfaces.ITestCaseData                                     ),
            typeof( NUnit.Framework.Internal.TestCaseParameters                                  ),
            typeof( NUnit.Framework.TestCaseData                                                 ),
            // Test/Result
            typeof( NUnit.Framework.Interfaces.ITestResult                                       ),
            typeof( NUnit.Framework.Internal.TestResult                                          ),
            typeof( NUnit.Framework.Interfaces.ResultState                                       ),
            typeof( NUnit.Framework.Interfaces.TestStatus                                        ),
            typeof( NUnit.Framework.Interfaces.FailureSite                                       ),
            typeof( NUnit.Framework.Interfaces.AssertionResult                                   ),
            typeof( NUnit.Framework.Interfaces.AssertionStatus                                   ),
            typeof( NUnit.Framework.Interfaces.TestAttachment                                    ),
            // Test/Result/Suite
            typeof( NUnit.Framework.Internal.TestSuiteResult                                     ),
            // Test/Result/Case
            typeof( NUnit.Framework.Internal.TestCaseResult                                      ),

            // Attributes
            typeof( NUnit.Framework.NUnitAttribute                                               ),
            typeof( NUnit.Framework.NonTestAssemblyAttribute                                     ),
            typeof( NUnit.Framework.TestAssemblyDirectoryResolveAttribute                        ),

            // Exceptions
            typeof( NUnit.Framework.Internal.NUnitException                                      ),
            typeof( NUnit.Framework.Internal.InvalidTestFixtureException                         ),
            typeof( NUnit.Framework.Internal.InvalidDataSourceException                          ),
            typeof( NUnit.Framework.Internal.TestCaseTimeoutException                            ),
        };


    }
}
