// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class NUnitModule_Runner_Execution : Module {

        private static readonly HeaderItem X_Runner_Execution                = HeaderItem.H1( "Runner/Execution" );
        private static readonly HeaderItem XX_Runner_Execution               = HeaderItem.H2( "Runner/Execution" );
        private static readonly HeaderItem XX_Runner_Execution_Extensibility = HeaderItem.H2( "Runner/Execution/Extensibility" );
        private static readonly HeaderItem XX_Infrastructure                 = HeaderItem.H2( "Infrastructure" );


        public override Item[] Items => new Item[] {
            X_Runner_Execution,

            XX_Runner_Execution,
            "Commands/Test",
            typeof( NUnit.Framework.Internal.Commands .TestCommand                                   ),
            typeof( NUnit.Framework.Internal.Commands .TestMethodCommand                             ),
            typeof( NUnit.Framework.Internal.Commands .EmptyTestCommand                              ),
            typeof( NUnit.Framework.Internal.Commands .SkipCommand                                   ),
            typeof( NUnit.Framework.Internal.Commands .DelegatingTestCommand                         ),
            "Commands/Test/Before",
            typeof( NUnit.Framework.Internal.Commands .BeforeTestCommand                             ),
            typeof( NUnit.Framework.Internal.Commands .BeforeTestActionCommand                       ),
            typeof( NUnit.Framework.Internal.Commands .ConstructFixtureCommand                       ),
            typeof( NUnit.Framework.Internal.Commands .OneTimeSetUpCommand                           ),
            "Commands/Test/After",
            typeof( NUnit.Framework.Internal.Commands .AfterTestCommand                              ),
            typeof( NUnit.Framework.Internal.Commands .AfterTestActionCommand                        ),
            typeof( NUnit.Framework.Internal.Commands .DisposeFixtureCommand                         ),
            typeof( NUnit.Framework.Internal.Commands .OneTimeTearDownCommand                        ),
            typeof( NUnit.Framework.Internal.Commands .MaxTimeCommand                                ),
            typeof( NUnit.Framework.Internal.Commands .TheoryResultCommand                           ),
            "Commands/Test/BeforeAndAfter",
            typeof( NUnit.Framework.Internal.Commands .BeforeAndAfterTestCommand                     ),
            typeof( NUnit.Framework.Internal.Commands .TestActionCommand                             ),
            typeof( NUnit.Framework.Internal.Commands .TestActionItem                                ),
            typeof( NUnit.Framework.Internal.Commands .SetUpTearDownCommand                          ),
            typeof( NUnit.Framework.Internal.Commands .SetUpTearDownItem                             ),
            typeof( NUnit.Framework.Internal.Commands .TimeoutCommand                                ),
            "Context",
            typeof( NUnit.Framework.Internal          .TestExecutionContext                          ),
            typeof( NUnit.Framework.Internal          .TestExecutionContext.IsolatedContext          ),
            typeof( NUnit.Framework.Internal          .TestExecutionContext.AdhocContext             ),
            typeof( NUnit.Framework.Internal          .TestExecutionStatus                           ),
            "Context/Wrapper",
            typeof( NUnit.Framework                   .TestContext                                   ),
            typeof( NUnit.Framework                   .TestContext.TestAdapter                       ),
            typeof( NUnit.Framework                   .TestContext.ResultAdapter                     ),
            typeof( NUnit.Framework                   .TestContext.PropertyBagAdapter                ),
            typeof( NUnit.Framework                   .TestParameters                                ),

            XX_Runner_Execution_Extensibility,
            "CommandWrappers",
            typeof( NUnit.Framework.Interfaces        .ICommandWrapper                               ),
            typeof( NUnit.Framework.Interfaces        .IWrapSetUpTearDown                            ),
            typeof( NUnit.Framework.Interfaces        .IWrapTestMethod                               ),
            typeof( NUnit.Framework.Interfaces        .IRepeatTest                                   ),
            typeof( NUnit.Framework                   .RepeatAttribute                               ),
            typeof( NUnit.Framework                   .RepeatAttribute.RepeatedTestCommand           ),
            typeof( NUnit.Framework                   .MaxTimeAttribute                              ),
            typeof( NUnit.Framework                   .RetryAttribute                                ),
            typeof( NUnit.Framework                   .RetryAttribute.RetryCommand                   ),
            "Actions",
            typeof( NUnit.Framework                   .ITestAction                                   ),
            typeof( NUnit.Framework                   .ActionTargets                                 ),
            typeof( NUnit.Framework                   .TestActionAttribute                           ),
            "ContextAppliers",
            typeof( NUnit.Framework.Interfaces        .IApplyToContext                               ),
            typeof( NUnit.Framework                   .DefaultFloatingPointToleranceAttribute        ),
            typeof( NUnit.Framework                   .SingleThreadedAttribute                       ),
            typeof( NUnit.Framework                   .SetCultureAttribute                           ),
            typeof( NUnit.Framework                   .SetUICultureAttribute                         ),
            typeof( NUnit.Framework                   .ParallelizableAttribute                       ),
            typeof( NUnit.Framework                   .NonParallelizableAttribute                    ),
            typeof( NUnit.Framework                   .TimeoutAttribute                              ),

            XX_Infrastructure,
            "WorkItems",
            typeof( NUnit.Framework.Internal.Execution.WorkItem                                      ),
            typeof( NUnit.Framework.Internal.Execution.SimpleWorkItem                                ),
            typeof( NUnit.Framework.Internal.Execution.CompositeWorkItem                             ),
            typeof( NUnit.Framework.Internal.Execution.CompositeWorkItem.OneTimeTearDownWorkItem     ),
            typeof( NUnit.Framework.Internal.Execution.WorkItemBuilder                               ),
            typeof( NUnit.Framework.Internal.Execution.WorkItemState                                 ),
            typeof( NUnit.Framework.Internal.Execution.ParallelExecutionStrategy                     ),
            typeof( NUnit.Framework                   .ParallelScope                                 ),
            "WorkItemDispatchers",
            typeof( NUnit.Framework.Internal.Execution.IWorkItemDispatcher                           ),
            typeof( NUnit.Framework.Internal.Execution.MainThreadWorkItemDispatcher                  ),
            typeof( NUnit.Framework.Internal.Execution.SimpleWorkItemDispatcher                      ),
            typeof( NUnit.Framework.Internal.Execution.ParallelWorkItemDispatcher                    ),
        };


    }
}
