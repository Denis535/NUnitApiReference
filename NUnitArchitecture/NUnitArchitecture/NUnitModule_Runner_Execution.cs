// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

#pragma warning disable SA1118 // ParameterMustNotSpanMultipleLines
namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ProjectArchitecture.Model;
    using static NUnitProject;

    public class NUnitModule_Runner_Execution : Module {

        public override string Name => "NUnit.Runner.Execution";
        public override Namespace[] Namespaces => new Namespace[] {
            new Namespace(
                "NUnit.Runner.Execution",
                "TestExecutionContext".AsGroup()
                + typeof( NUnit.Framework.Internal          .TestExecutionContext                          )
                + typeof( NUnit.Framework.Internal          .TestExecutionContext.IsolatedContext          )
                + typeof( NUnit.Framework.Internal          .TestExecutionContext.AdhocContext             )
                + typeof( NUnit.Framework.Internal          .TestExecutionStatus                           ),
                "TestExecutionContext/Facade".AsGroup()
                + typeof( NUnit.Framework                   .TestContext                                   )
                + typeof( NUnit.Framework                   .TestContext.TestAdapter                       )
                + typeof( NUnit.Framework                   .TestContext.ResultAdapter                     )
                + typeof( NUnit.Framework                   .TestContext.PropertyBagAdapter                )
                + typeof( NUnit.Framework                   .TestParameters                                ),
                "WorkItemDispatcher".AsGroup()
                + typeof( NUnit.Framework.Internal.Execution.IWorkItemDispatcher                           )
                + typeof( NUnit.Framework.Internal.Execution.MainThreadWorkItemDispatcher                  )
                + typeof( NUnit.Framework.Internal.Execution.SimpleWorkItemDispatcher                      )
                + typeof( NUnit.Framework.Internal.Execution.ParallelWorkItemDispatcher                    ),
                "WorkItemBuilder".AsGroup()
                + typeof( NUnit.Framework.Internal.Execution.WorkItemBuilder                               ),
                "WorkItem".AsGroup()
                + typeof( NUnit.Framework.Internal.Execution.WorkItem                                      )
                + typeof( NUnit.Framework.Internal.Execution.SimpleWorkItem                                )
                + typeof( NUnit.Framework.Internal.Execution.CompositeWorkItem                             )
                + typeof( NUnit.Framework.Internal.Execution.CompositeWorkItem.OneTimeTearDownWorkItem     )
                + typeof( NUnit.Framework.Internal.Execution.WorkItemState                                 )
                + typeof( NUnit.Framework.Internal.Execution.ParallelExecutionStrategy                     )
                + typeof( NUnit.Framework                   .ParallelScope                                 )
                + typeof( NUnit.Framework.Interfaces        .ITestFilter                                   )
                + typeof( NUnit.Framework.Internal          .TestFilter                                    )
                + TypeOf( "NUnit.Framework.Internal.Filters .ValueMatchFilter"                             )
                + TypeOf( "NUnit.Framework.Internal.Filters .CategoryFilter"                               )
                + TypeOf( "NUnit.Framework.Internal.Filters .IdFilter"                                     )
                + TypeOf( "NUnit.Framework.Internal.Filters .TestNameFilter"                               )
                + TypeOf( "NUnit.Framework.Internal.Filters .FullNameFilter"                               )
                + TypeOf( "NUnit.Framework.Internal.Filters .NamespaceFilter"                              )
                + TypeOf( "NUnit.Framework.Internal.Filters .ClassNameFilter"                              )
                + TypeOf( "NUnit.Framework.Internal.Filters .PropertyFilter"                               )
                + TypeOf( "NUnit.Framework.Internal.Filters .MethodNameFilter"                             )
                + TypeOf( "NUnit.Framework.Internal.Filters .CompositeFilter"                              )
                + TypeOf( "NUnit.Framework.Internal.Filters .AndFilter"                                    )
                + TypeOf( "NUnit.Framework.Internal.Filters .OrFilter"                                     )
                + TypeOf( "NUnit.Framework.Internal.Filters .NotFilter"                                    ),
                "TestCommand".AsGroup()
                + typeof( NUnit.Framework.Internal.Commands .TestCommand                                   )
                + typeof( NUnit.Framework.Internal.Commands .TestMethodCommand                             )
                + typeof( NUnit.Framework.Internal.Commands .EmptyTestCommand                              )
                + typeof( NUnit.Framework.Internal.Commands .SkipCommand                                   )
                + typeof( NUnit.Framework.Internal.Commands .DelegatingTestCommand                         )
                + TypeOf( "NUnit.Framework.Internal.Commands.ApplyChangesToContextCommand"                 ),
                "TestCommand/Before".AsGroup()
                + typeof( NUnit.Framework.Internal.Commands .BeforeTestCommand                             )
                + typeof( NUnit.Framework.Internal.Commands .BeforeTestActionCommand                       )
                + typeof( NUnit.Framework.Internal.Commands .ConstructFixtureCommand                       )
                + typeof( NUnit.Framework.Internal.Commands .OneTimeSetUpCommand                           ),
                "TestCommand/After".AsGroup()
                + typeof( NUnit.Framework.Internal.Commands .AfterTestCommand                              )
                + typeof( NUnit.Framework.Internal.Commands .AfterTestActionCommand                        )
                + typeof( NUnit.Framework.Internal.Commands .DisposeFixtureCommand                         )
                + typeof( NUnit.Framework.Internal.Commands .OneTimeTearDownCommand                        )
                + typeof( NUnit.Framework.Internal.Commands .MaxTimeCommand                                )
                + typeof( NUnit.Framework.Internal.Commands .TheoryResultCommand                           ),
                "TestCommand/BeforeAndAfter".AsGroup()
                + typeof( NUnit.Framework.Internal.Commands .BeforeAndAfterTestCommand                     )
                + typeof( NUnit.Framework.Internal.Commands .TestActionCommand                             )
                + typeof( NUnit.Framework.Internal.Commands .TestActionItem                                )
                + typeof( NUnit.Framework.Internal.Commands .SetUpTearDownCommand                          )
                + typeof( NUnit.Framework.Internal.Commands .SetUpTearDownItem                             )
                + typeof( NUnit.Framework.Internal.Commands .TimeoutCommand                                )
            ),
            new Namespace(
                "NUnit.Runner.Execution.Annotations",
                "Extensibility/CommandWrapper".AsGroup()
                + typeof( NUnit.Framework.Interfaces        .ICommandWrapper                               )
                + typeof( NUnit.Framework.Interfaces        .IWrapSetUpTearDown                            )
                + typeof( NUnit.Framework.Interfaces        .IWrapTestMethod                               )
                + typeof( NUnit.Framework.Interfaces        .IRepeatTest                                   )
                + typeof( NUnit.Framework                   .RepeatAttribute                               )
                + typeof( NUnit.Framework                   .RepeatAttribute.RepeatedTestCommand           )
                + typeof( NUnit.Framework                   .MaxTimeAttribute                              )
                + typeof( NUnit.Framework                   .RetryAttribute                                )
                + typeof( NUnit.Framework                   .RetryAttribute.RetryCommand                   ),
                "Extensibility/ContextApplier".AsGroup()
                + typeof( NUnit.Framework.Interfaces        .IApplyToContext                               )
                + typeof( NUnit.Framework                   .DefaultFloatingPointToleranceAttribute        )
                + typeof( NUnit.Framework                   .SingleThreadedAttribute                       )
                + typeof( NUnit.Framework                   .SetCultureAttribute                           )
                + typeof( NUnit.Framework                   .SetUICultureAttribute                         )
                + typeof( NUnit.Framework                   .ParallelizableAttribute                       )
                + typeof( NUnit.Framework                   .NonParallelizableAttribute                    )
                + typeof( NUnit.Framework                   .TimeoutAttribute                              ),
                "Extensibility/TestAction".AsGroup()
                + typeof( NUnit.Framework                   .ITestAction                                   )
                + typeof( NUnit.Framework                   .TestActionAttribute                           )
                + typeof( NUnit.Framework                   .ActionTargets                                 )
            ),
            new Namespace(
                "NUnit.Infrastructure",
                "WorkShift".AsGroup()
                + typeof( NUnit.Framework.Internal.Execution.WorkShift                                     )
                + typeof( NUnit.Framework.Internal.Execution.ShiftChangeEventHandler                       ),
                "WorkShift/WorkItemQueue".AsGroup()
                + typeof( NUnit.Framework.Internal.Execution.WorkItemQueue                                 )
                + typeof( NUnit.Framework.Internal.Execution.WorkItemQueueState                            ),
                "WorkShift/TestWorker".AsGroup()
                + typeof( NUnit.Framework.Internal.Execution.TestWorker                                    )
                + typeof( NUnit.Framework.Internal.Execution.TestWorker.TestWorkerEventHandler             )
            ),
        };


    }
}
