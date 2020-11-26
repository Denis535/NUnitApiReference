// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using NUnit.Framework.Internal;
    using NUnit.Framework.Internal.Commands;
    using NUnit.Framework.Internal.Execution;
    using NUnit.Framework.Internal.Filters;
    using ProjectArchitecture.Model;

    public class NUnitModule_Runner_Execution : Module {

        public override string Name => "NUnit.Runner.Execution";
        public override Namespace[] Namespaces => new INode[] {
            "NUnit.Runner.Execution".AsNamespace(),
            "TestExecutionContext".AsGroup(),
            (TypeItem) typeof( TestExecutionContext                      ),
            (TypeItem) typeof( TestExecutionContext.IsolatedContext      ),
            (TypeItem) typeof( TestExecutionContext.AdhocContext         ),
            (TypeItem) typeof( TestExecutionStatus                       ),
            "TestExecutionContext/Facade".AsGroup(),
            (TypeItem) typeof( TestContext                               ),
            (TypeItem) typeof( TestContext.TestAdapter                   ),
            (TypeItem) typeof( TestContext.ResultAdapter                 ),
            (TypeItem) typeof( TestContext.PropertyBagAdapter            ),
            (TypeItem) typeof( NUnit.Framework.TestParameters            ),
            "WorkItemDispatcher".AsGroup(),
            (TypeItem) typeof( IWorkItemDispatcher                       ),
            (TypeItem) typeof( MainThreadWorkItemDispatcher              ),
            (TypeItem) typeof( SimpleWorkItemDispatcher                  ),
            (TypeItem) typeof( ParallelWorkItemDispatcher                ),
            "WorkItemBuilder".AsGroup(),
            (TypeItem) typeof( WorkItemBuilder                           ),
            "WorkItem".AsGroup(),
            (TypeItem) typeof( WorkItem                                  ),
            (TypeItem) typeof( SimpleWorkItem                            ),
            (TypeItem) typeof( CompositeWorkItem                         ),
            (TypeItem) typeof( CompositeWorkItem.OneTimeTearDownWorkItem ),
            (TypeItem) typeof( WorkItemState                             ),
            (TypeItem) typeof( ParallelExecutionStrategy                 ),
            (TypeItem) typeof( ParallelScope                             ),
            (TypeItem) typeof( ITestFilter                               ),
            (TypeItem) typeof( TestFilter                                ),
            (TypeItem) typeof( ValueMatchFilter                          ),
            (TypeItem) typeof( CategoryFilter                            ),
            (TypeItem) typeof( IdFilter                                  ),
            (TypeItem) typeof( TestNameFilter                            ),
            (TypeItem) typeof( FullNameFilter                            ),
            (TypeItem) typeof( NamespaceFilter                           ),
            (TypeItem) typeof( ClassNameFilter                           ),
            (TypeItem) typeof( PropertyFilter                            ),
            (TypeItem) typeof( MethodNameFilter                          ),
            (TypeItem) typeof( CompositeFilter                           ),
            (TypeItem) typeof( AndFilter                                 ),
            (TypeItem) typeof( OrFilter                                  ),
            (TypeItem) typeof( NotFilter                                 ),
            "TestCommand".AsGroup(),
            (TypeItem) typeof( TestCommand                               ),
            (TypeItem) typeof( TestMethodCommand                         ),
            (TypeItem) typeof( EmptyTestCommand                          ),
            (TypeItem) typeof( SkipCommand                               ),
            (TypeItem) typeof( DelegatingTestCommand                     ),
            (TypeItem) typeof( ApplyChangesToContextCommand              ),
            "TestCommand/Before".AsGroup(),
            (TypeItem) typeof( BeforeTestCommand                         ),
            (TypeItem) typeof( BeforeTestActionCommand                   ),
            (TypeItem) typeof( ConstructFixtureCommand                   ),
            (TypeItem) typeof( OneTimeSetUpCommand                       ),
            "TestCommand/After".AsGroup(),
            (TypeItem) typeof( AfterTestCommand                          ),
            (TypeItem) typeof( AfterTestActionCommand                    ),
            (TypeItem) typeof( DisposeFixtureCommand                     ),
            (TypeItem) typeof( OneTimeTearDownCommand                    ),
            (TypeItem) typeof( MaxTimeCommand                            ),
            (TypeItem) typeof( TheoryResultCommand                       ),
            "TestCommand/BeforeAndAfter".AsGroup(),
            (TypeItem) typeof( BeforeAndAfterTestCommand                 ),
            (TypeItem) typeof( TestActionCommand                         ),
            (TypeItem) typeof( TestActionItem                            ),
            (TypeItem) typeof( SetUpTearDownCommand                      ),
            (TypeItem) typeof( SetUpTearDownItem                         ),
            (TypeItem) typeof( TimeoutCommand                            ),

            "NUnit.Runner.Execution.Annotations".AsNamespace(),
            "Extensibility/CommandWrapper".AsGroup(),
            (TypeItem) typeof( ICommandWrapper                           ),
            (TypeItem) typeof( IWrapSetUpTearDown                        ),
            (TypeItem) typeof( IWrapTestMethod                           ),
            (TypeItem) typeof( IRepeatTest                               ),
            (TypeItem) typeof( RepeatAttribute                           ),
            (TypeItem) typeof( RepeatAttribute.RepeatedTestCommand       ),
            (TypeItem) typeof( MaxTimeAttribute                          ),
            (TypeItem) typeof( RetryAttribute                            ),
            (TypeItem) typeof( RetryAttribute.RetryCommand               ),
            "Extensibility/ContextApplier".AsGroup(),
            (TypeItem) typeof( IApplyToContext                           ),
            (TypeItem) typeof( DefaultFloatingPointToleranceAttribute    ),
            (TypeItem) typeof( SingleThreadedAttribute                   ),
            (TypeItem) typeof( SetCultureAttribute                       ),
            (TypeItem) typeof( SetUICultureAttribute                     ),
            (TypeItem) typeof( ParallelizableAttribute                   ),
            (TypeItem) typeof( NonParallelizableAttribute                ),
            (TypeItem) typeof( TimeoutAttribute                          ),
            "Extensibility/TestAction".AsGroup(),
            (TypeItem) typeof( ITestAction                               ),
            (TypeItem) typeof( TestActionAttribute                       ),
            (TypeItem) typeof( ActionTargets                             ),

            "NUnit.Infrastructure".AsNamespace(),
            "WorkShift".AsGroup(),
            (TypeItem) typeof( WorkShift                                 ),
            (TypeItem) typeof( ShiftChangeEventHandler                   ),
            "WorkShift/WorkItemQueue".AsGroup(),
            (TypeItem) typeof( WorkItemQueue                             ),
            (TypeItem) typeof( WorkItemQueueState                        ),
            "WorkShift/TestWorker".AsGroup(),
            (TypeItem) typeof( TestWorker                                ),
            (TypeItem) typeof( TestWorker.TestWorkerEventHandler         ),
        }.ToHierarchy();


    }
}
