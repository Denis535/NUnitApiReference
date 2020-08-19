# Table of Contents
  - [Project: NUnit](#project-nunit)
    - [Module: NUnit.Main](#module-nunitmain)
      - [Namespace: NUnit](#namespace-nunit)
        - [Group: Default](#group-default)
      - [Namespace: NUnit.Annotations](#namespace-nunitannotations)
        - [Group: Default](#group-default-1)
      - [Namespace: NUnit.Api](#namespace-nunitapi)
        - [Group: Default](#group-default-2)
      - [Namespace: NUnit.Runner](#namespace-nunitrunner)
        - [Group: Default](#group-default-3)
    - [Module: NUnit.Runner.Building](#module-nunitrunnerbuilding)
      - [Namespace: NUnit.Runner.Building](#namespace-nunitrunnerbuilding)
        - [Group: AssemblyBuilder](#group-assemblybuilder)
        - [Group: TestBuilder](#group-testbuilder)
        - [Group: MethodBuilder](#group-methodbuilder)
      - [Namespace: NUnit.Runner.Building.Annotations](#namespace-nunitrunnerbuildingannotations)
        - [Group: FixtureBuilder](#group-fixturebuilder)
        - [Group: TestBuilder](#group-testbuilder-1)
        - [Group: Extensibility/TestApplier](#group-extensibility/testapplier)
        - [Group: Data/DataSource](#group-data/datasource)
        - [Group: Data/DataPoint](#group-data/datapoint)
      - [Namespace: NUnit.Infrastructure](#namespace-nunitinfrastructure)
        - [Group: Builders](#group-builders)
        - [Group: DataProvider](#group-dataprovider)
        - [Group: DataCombiner](#group-datacombiner)
        - [Group: Utils](#group-utils)
    - [Module: NUnit.Runner.Execution](#module-nunitrunnerexecution)
      - [Namespace: NUnit.Runner.Execution](#namespace-nunitrunnerexecution)
        - [Group: TestExecutionContext](#group-testexecutioncontext)
        - [Group: TestExecutionContext/Facade](#group-testexecutioncontext/facade)
        - [Group: WorkItemDispatcher](#group-workitemdispatcher)
        - [Group: WorkItemBuilder](#group-workitembuilder)
        - [Group: WorkItem](#group-workitem)
        - [Group: TestCommand](#group-testcommand)
        - [Group: TestCommand/Before](#group-testcommand/before)
        - [Group: TestCommand/After](#group-testcommand/after)
        - [Group: TestCommand/BeforeAndAfter](#group-testcommand/beforeandafter)
      - [Namespace: NUnit.Runner.Execution.Annotations](#namespace-nunitrunnerexecutionannotations)
        - [Group: Extensibility/CommandWrapper](#group-extensibility/commandwrapper)
        - [Group: Extensibility/ContextApplier](#group-extensibility/contextapplier)
        - [Group: Extensibility/TestAction](#group-extensibility/testaction)
      - [Namespace: NUnit.Infrastructure](#namespace-nunitinfrastructure-1)
        - [Group: WorkShift](#group-workshift)
        - [Group: WorkShift/WorkItemQueue](#group-workshift/workitemqueue)
        - [Group: WorkShift/TestWorker](#group-workshift/testworker)
    - [Module: NUnit.Runner.Entities](#module-nunitrunnerentities)
      - [Namespace: NUnit.Runner.Entities](#namespace-nunitrunnerentities)
        - [Group: Test](#group-test)
        - [Group: TestResult](#group-testresult)
        - [Group: TestData](#group-testdata)
      - [Namespace: NUnit.Infrastructure](#namespace-nunitinfrastructure-2)
        - [Group: PropertyBag](#group-propertybag)
    - [Module: NUnit.Assertion](#module-nunitassertion)
      - [Namespace: NUnit.Assertions](#namespace-nunitassertions)
        - [Group: Assert](#group-assert)
        - [Group: ToBe](#group-tobe)
        - [Group: Delegates](#group-delegates)
        - [Group: Exceptions](#group-exceptions)
      - [Namespace: NUnit.Constraints](#namespace-nunitconstraints)
        - [Group: ConstraintBuilder](#group-constraintbuilder)
        - [Group: ConstraintResolver](#group-constraintresolver)
        - [Group: Constraint](#group-constraint)
        - [Group: ConstraintResult](#group-constraintresult)
        - [Group: ConstraintExpression](#group-constraintexpression)
        - [Group: ConstraintOperator](#group-constraintoperator)
      - [Namespace: NUnit.Infrastructure](#namespace-nunitinfrastructure-3)
        - [Group: Adapters](#group-adapters)
        - [Group: Comparers](#group-comparers)
        - [Group: Utils](#group-utils-1)
    - [Module: NUnit.Infrastructure](#module-nunitinfrastructure)
      - [Namespace: System](#namespace-system)
        - [Group: Default](#group-default-4)
      - [Namespace: System.Threading](#namespace-systemthreading)
        - [Group: Default](#group-default-5)
      - [Namespace: System.Async](#namespace-systemasync)
        - [Group: AsyncToSyncAdapter](#group-asynctosyncadapter)
        - [Group: AwaitAdapter](#group-awaitadapter)
      - [Namespace: System.Reflection](#namespace-systemreflection)
        - [Group: Models](#group-models)
        - [Group: Utils](#group-utils-2)
      - [Namespace: System.Environment](#namespace-systemenvironment)
        - [Group: Default](#group-default-6)
      - [Namespace: System.Logging](#namespace-systemlogging)
        - [Group: Default](#group-default-7)
      - [Namespace: System.Xml](#namespace-systemxml)
        - [Group: Default](#group-default-8)
      - [Namespace: NUnit](#namespace-nunit-1)
        - [Group: Exceptions](#group-exceptions-1)
        - [Group: Utils](#group-utils-3)
      - [Namespace: NUnit.IO](#namespace-nunitio)
        - [Group: Default](#group-default-9)
      - [Namespace: NUnit.Messaging](#namespace-nunitmessaging)
        - [Group: TestListener](#group-testlistener)
        - [Group: EventPump](#group-eventpump)
        - [Group: EventQueue](#group-eventqueue)
      - [Namespace: NUnit.Formatting](#namespace-nunitformatting)
        - [Group: Default](#group-default-10)
      - [Namespace: NUnit.Utils](#namespace-nunitutils)
        - [Group: Default](#group-default-11)

# Project: NUnit
## Module: NUnit.Main
### Namespace: NUnit
#### Group: Default
* FrameworkPackageSettings
### Namespace: NUnit.Annotations
#### Group: Default
* NUnitAttribute
* NonTestAssemblyAttribute
* TestAssemblyDirectoryResolveAttribute
### Namespace: NUnit.Api
#### Group: Default
* FrameworkController
* FrameworkControllerAction
* LoadTestsAction
* CountTestsAction
* ExploreTestsAction
* RunTestsAction
* RunAsyncAction
* StopRunAction
### Namespace: NUnit.Runner
#### Group: Default
* ITestAssemblyRunner
* NUnitTestAssemblyRunner
## Module: NUnit.Runner.Building
### Namespace: NUnit.Runner.Building
#### Group: AssemblyBuilder
* ITestAssemblyBuilder
* DefaultTestAssemblyBuilder
#### Group: TestBuilder
* ISuiteBuilder
* DefaultSuiteBuilder
#### Group: MethodBuilder
* ITestCaseBuilder
* DefaultTestCaseBuilder
### Namespace: NUnit.Runner.Building.Annotations
#### Group: FixtureBuilder
* IFixtureBuilder
* IFixtureBuilder2
* SetUpFixtureAttribute
* TestFixtureAttribute
* TestFixtureSourceAttribute
* IPreFilter
* PreFilter
* OneTimeSetUpAttribute
* SetUpAttribute
* OneTimeTearDownAttribute
* TearDownAttribute
#### Group: TestBuilder
* ITestBuilder
* ISimpleTestBuilder
* IImplyFixture
* TestAttribute
* TestCaseAttribute
* TestCaseSourceAttribute
* CombiningStrategyAttribute
* SequentialAttribute
* PairwiseAttribute
* CombinatorialAttribute
* TheoryAttribute
#### Group: Extensibility/TestApplier
* IApplyToTest
* CategoryAttribute
* OrderAttribute
* ExplicitAttribute
* IgnoreAttribute
* IncludeExcludeAttribute
* PlatformAttribute
* CultureAttribute
* PropertyAttribute
* DescriptionAttribute
* AuthorAttribute
* TestOfAttribute
* ApartmentAttribute
* RequiresThreadAttribute
* LevelOfParallelismAttribute
#### Group: Data/DataSource
* IParameterDataSource
* ValuesAttribute
* ValueSourceAttribute
* RandomAttribute
* RangeAttribute
#### Group: Data/DataPoint
* DatapointAttribute
* DatapointSourceAttribute
* DatapointsAttribute
### Namespace: NUnit.Infrastructure
#### Group: Builders
* NamespaceTreeBuilder
* NUnitTestFixtureBuilder
* NUnitTestCaseBuilder
#### Group: DataProvider
* IParameterDataProvider
* ParameterDataProvider
* ParameterDataSourceProvider
* DatapointProvider
#### Group: DataCombiner
* ICombiningStrategy
* CombinatorialStrategy
* SequentialStrategy
* PairwiseStrategy
* FleaRand
* FeatureInfo
* FeatureTuple
* TestCaseInfo
* PairwiseTestCaseGenerator
#### Group: Utils
* PlatformHelper
* CultureDetector
* ProviderCache
* ParamAttributeTypeConversions
* TestNameGenerator
* ValueGenerator
* ValueGenerator`1
* Step
* Step
* ComparableStep`1
## Module: NUnit.Runner.Execution
### Namespace: NUnit.Runner.Execution
#### Group: TestExecutionContext
* TestExecutionContext
* IsolatedContext
* AdhocContext
* TestExecutionStatus
#### Group: TestExecutionContext/Facade
* TestContext
* TestAdapter
* ResultAdapter
* PropertyBagAdapter
* TestParameters
#### Group: WorkItemDispatcher
* IWorkItemDispatcher
* MainThreadWorkItemDispatcher
* SimpleWorkItemDispatcher
* ParallelWorkItemDispatcher
#### Group: WorkItemBuilder
* WorkItemBuilder
#### Group: WorkItem
* WorkItem
* SimpleWorkItem
* CompositeWorkItem
* OneTimeTearDownWorkItem
* WorkItemState
* ParallelExecutionStrategy
* ParallelScope
* ITestFilter
* TestFilter
* ValueMatchFilter
* CategoryFilter
* IdFilter
* TestNameFilter
* FullNameFilter
* NamespaceFilter
* ClassNameFilter
* PropertyFilter
* MethodNameFilter
* CompositeFilter
* AndFilter
* OrFilter
* NotFilter
#### Group: TestCommand
* TestCommand
* TestMethodCommand
* EmptyTestCommand
* SkipCommand
* DelegatingTestCommand
* ApplyChangesToContextCommand
#### Group: TestCommand/Before
* BeforeTestCommand
* BeforeTestActionCommand
* ConstructFixtureCommand
* OneTimeSetUpCommand
#### Group: TestCommand/After
* AfterTestCommand
* AfterTestActionCommand
* DisposeFixtureCommand
* OneTimeTearDownCommand
* MaxTimeCommand
* TheoryResultCommand
#### Group: TestCommand/BeforeAndAfter
* BeforeAndAfterTestCommand
* TestActionCommand
* TestActionItem
* SetUpTearDownCommand
* SetUpTearDownItem
* TimeoutCommand
### Namespace: NUnit.Runner.Execution.Annotations
#### Group: Extensibility/CommandWrapper
* ICommandWrapper
* IWrapSetUpTearDown
* IWrapTestMethod
* IRepeatTest
* RepeatAttribute
* RepeatedTestCommand
* MaxTimeAttribute
* RetryAttribute
* RetryCommand
#### Group: Extensibility/ContextApplier
* IApplyToContext
* DefaultFloatingPointToleranceAttribute
* SingleThreadedAttribute
* SetCultureAttribute
* SetUICultureAttribute
* ParallelizableAttribute
* NonParallelizableAttribute
* TimeoutAttribute
#### Group: Extensibility/TestAction
* ITestAction
* TestActionAttribute
* ActionTargets
### Namespace: NUnit.Infrastructure
#### Group: WorkShift
* WorkShift
* ShiftChangeEventHandler
#### Group: WorkShift/WorkItemQueue
* WorkItemQueue
* WorkItemQueueState
#### Group: WorkShift/TestWorker
* TestWorker
* TestWorkerEventHandler
## Module: NUnit.Runner.Entities
### Namespace: NUnit.Runner.Entities
#### Group: Test
* ITest
* Test
* RunState
* TestSuite
* TestAssembly
* IDisposableFixture
* SetUpFixture
* TestFixture
* ParameterizedFixtureSuite
* ParameterizedMethodSuite
* TestMethod
#### Group: TestResult
* ITestResult
* TestResult
* ResultState
* TestStatus
* FailureSite
* AssertionResult
* AssertionStatus
* TestAttachment
* TestSuiteResult
* TestCaseResult
#### Group: TestData
* ITestData
* TestParameters
* ITestFixtureData
* TestFixtureParameters
* TestFixtureData
* ITestCaseData
* TestCaseParameters
* TestCaseData
### Namespace: NUnit.Infrastructure
#### Group: PropertyBag
* IPropertyBag
* PropertyBag
* PropertyNames
## Module: NUnit.Assertion
### Namespace: NUnit.Assertions
#### Group: Assert
* Assert
* StringAssert
* CollectionAssert
* DirectoryAssert
* FileAssert
* Warn
* Assume
#### Group: ToBe
* Is
* Iz
* Has
* Does
* Contains
* Throws
#### Group: Delegates
* TestDelegate
* AsyncTestDelegate
* ActualValueDelegate`1
#### Group: Exceptions
* ResultStateException
* AssertionException
* MultipleAssertException
* InconclusiveException
* IgnoreException
* SuccessException
### Namespace: NUnit.Constraints
#### Group: ConstraintBuilder
* ConstraintBuilder
* ConstraintStack
#### Group: ConstraintResolver
* IResolveConstraint
* ReusableConstraint
#### Group: Constraint
* IConstraint
* Constraint
* NullConstraint
* FalseConstraint
* TrueConstraint
* NaNConstraint
* EqualConstraint
* SameAsConstraint
* RangeConstraint
* AnyOfConstraint
* ExactCountConstraint
* EmptyConstraint
* ContainsConstraint
* AttributeExistsConstraint
* PropertyExistsConstraint
* BinarySerializableConstraint
* XmlSerializableConstraint
* EmptyDirectoryConstraint
* FileOrDirectoryExistsConstraint
* PredicateConstraint`1
* ThrowsExceptionConstraint
* ThrowsNothingConstraint
* ExceptionNotThrownConstraint
* Tolerance
* Range
* ToleranceMode
* PrefixConstraint
* NotConstraint
* AttributeConstraint
* PropertyConstraint
* NoItemConstraint
* SomeItemsConstraint
* AllItemsConstraint
* ThrowsConstraint
* DelayedConstraint
* WithRawDelayInterval
* WithDimensionedDelayInterval
* WithRawPollingInterval
* Interval
* IntervalUnit
* BinaryConstraint
* AndConstraint
* OrConstraint
* ComparisonConstraint
* LessThanConstraint
* LessThanOrEqualConstraint
* GreaterThanConstraint
* GreaterThanOrEqualConstraint
* CollectionConstraint
* EmptyCollectionConstraint
* CollectionOrderedConstraint
* CollectionItemsEqualConstraint
* CollectionEquivalentConstraint
* CollectionSubsetConstraint
* CollectionSupersetConstraint
* CollectionContainsConstraint
* DictionaryContainsKeyConstraint
* DictionaryContainsValueConstraint
* UniqueItemsConstraint
* StringConstraint
* EmptyStringConstraint
* StartsWithConstraint
* EndsWithConstraint
* SubstringConstraint
* RegexConstraint
* PathConstraint
* SamePathConstraint
* SubPathConstraint
* SamePathOrUnderConstraint
* TypeConstraint
* ExactTypeConstraint
* ExceptionTypeConstraint
* AssignableFromConstraint
* AssignableToConstraint
* InstanceOfTypeConstraint
#### Group: ConstraintResult
* ConstraintResult
* ExactCountConstraintResult
* ConstraintStatus
* PropertyConstraintResult
* EqualConstraintResult
* CollectionEquivalentConstraintResult
* EachItemConstraintResult
#### Group: ConstraintExpression
* ConstraintExpression
* ItemsConstraintExpression
* ResolvableConstraintExpression
#### Group: ConstraintOperator
* ConstraintOperator
* PrefixOperator
* NotOperator
* WithOperator
* CollectionOperator
* NoneOperator
* SomeOperator
* AllOperator
* BinaryOperator
* AndOperator
* OrOperator
* SelfResolvingOperator
* AttributeOperator
* PropOperator
* ExactCountOperator
* ThrowsOperator
### Namespace: NUnit.Infrastructure
#### Group: Adapters
* EqualityAdapter
* PredicateEqualityAdapter`2
* ComparisonAdapter
#### Group: Comparers
* NUnitEqualityComparer
* FailurePoint
* NUnitComparer
* IChainComparer
* NumericsComparer
* CharsComparer
* StringsComparer
* TupleComparerBase
* TupleComparer
* ValueTupleComparer
* TimeSpanToleranceComparer
* DateTimeOffsetsComparer
* ArraysComparer
* EnumerablesComparer
* DictionariesComparer
* DictionaryEntriesComparer
* KeyValuePairsComparer
* StreamsComparer
* EquatablesComparer
* DirectoriesComparer
#### Group: Utils
* ConstraintUtils
## Module: NUnit.Infrastructure
### Namespace: System
#### Group: Default
* LongLivedMarshalByRefObject
* StringUtil
* Randomizer
* ThreadUtility
* ExceptionHelper
* StackFilter
* ICallbackEventHandler
### Namespace: System.Threading
#### Group: Default
* SandboxedThreadState
* SingleThreadedTestSynchronizationContext
### Namespace: System.Async
#### Group: AsyncToSyncAdapter
* AsyncToSyncAdapter
* MessagePumpStrategy
#### Group: AwaitAdapter
* AwaitAdapter
* DefaultBlockingAwaitAdapter
* CSharpPatternBasedAwaitAdapter
* TaskAwaitAdapter
### Namespace: System.Reflection
#### Group: Models
* IReflectionInfo
* ITypeInfo
* IMethodInfo
* IParameterInfo
* TypeWrapper
* MethodWrapper
* ParameterWrapper
#### Group: Utils
* Reflect
* AssemblyHelper
* TypeHelper
* GenericMethodHelper
* AttributeHelper
### Namespace: System.Environment
#### Group: Default
* OSPlatform
* ProductType
* RuntimeFramework
* RuntimeType
### Namespace: System.Logging
#### Group: Default
* InternalTrace
* InternalTraceLevel
* ILogger
* Logger
### Namespace: System.Xml
#### Group: Default
* IXmlNodeBuilder
* NodeList
* TNode
* AttributeDictionary
### Namespace: NUnit
#### Group: Exceptions
* NUnitException
* InvalidTestFixtureException
* InvalidDataSourceException
* TestCaseTimeoutException
* InvalidPlatformException
#### Group: Utils
* Guard
* Extensions
* On
### Namespace: NUnit.IO
#### Group: Default
* InternalTraceWriter
* MessageWriter
* TextMessageWriter
* TextCapture
* EventListenerTextWriter
### Namespace: NUnit.Messaging
#### Group: TestListener
* ITestListener
* TestListener
* TestProgressReporter
* QueuingEventListener
* TestMessage
* TestOutput
#### Group: EventPump
* EventPump
* EventPumpState
#### Group: EventQueue
* EventQueue
* Event
* TestStartedEvent
* TestFinishedEvent
* TestOutputEvent
* TestMessageEvent
### Namespace: NUnit.Formatting
#### Group: Default
* MsgUtils
* ValueFormatter
* ValueFormatterFactory
### Namespace: NUnit.Utils
#### Group: Default
* List
* ListMapper
* CollectionTally
* CollectionTallyResult
* TypeNameDifferenceResolver
* Numerics
* FloatingPointNumerics
