# Table of Contents
  - [Project: NUnit](#project-nunit)
    - [Module: NUnit.Main](#module-nunitmain)
      - [Namespace: NUnit](#namespace-nunit)
        - [Group: ](#group-)
      - [Namespace: NUnit.Annotations](#namespace-nunitannotations)
        - [Group: ](#group--1)
      - [Namespace: NUnit.Api](#namespace-nunitapi)
        - [Group: ](#group--2)
      - [Namespace: NUnit.Runner](#namespace-nunitrunner)
        - [Group: ](#group--3)
    - [Module: NUnit.Runner.Building](#module-nunitrunnerbuilding)
      - [Namespace: NUnit.Runner.Building](#namespace-nunitrunnerbuilding)
        - [Group: AssemblyBuilder](#group-assemblybuilder)
        - [Group: TestBuilder](#group-testbuilder)
        - [Group: MethodBuilder](#group-methodbuilder)
      - [Namespace: NUnit.Runner.Building.Annotations](#namespace-nunitrunnerbuildingannotations)
        - [Group: FixtureBuilder](#group-fixturebuilder)
        - [Group: FixtureBuilder/SetUp](#group-fixturebuildersetup)
        - [Group: FixtureBuilder/TearDown](#group-fixturebuilderteardown)
        - [Group: TestBuilder](#group-testbuilder-1)
        - [Group: TestBuilder/CombiningStrategy](#group-testbuildercombiningstrategy)
        - [Group: Extensibility/TestApplier](#group-extensibilitytestapplier)
        - [Group: Extensibility/TestApplier/Property](#group-extensibilitytestapplierproperty)
        - [Group: Data/DataSource](#group-datadatasource)
        - [Group: Data/DataPoint](#group-datadatapoint)
      - [Namespace: NUnit.Infrastructure](#namespace-nunitinfrastructure)
        - [Group: Builders](#group-builders)
        - [Group: DataProvider](#group-dataprovider)
        - [Group: DataCombiner](#group-datacombiner)
        - [Group: Utils](#group-utils)
        - [Group: Utils/TestNameGenerator](#group-utilstestnamegenerator)
        - [Group: Utils/ValueGenerator](#group-utilsvaluegenerator)
    - [Module: NUnit.Runner.Execution](#module-nunitrunnerexecution)
      - [Namespace: NUnit.Runner.Execution](#namespace-nunitrunnerexecution)
        - [Group: TestExecutionContext](#group-testexecutioncontext)
        - [Group: TestExecutionContext/Facade](#group-testexecutioncontextfacade)
        - [Group: WorkItemDispatcher](#group-workitemdispatcher)
        - [Group: WorkItemBuilder](#group-workitembuilder)
        - [Group: WorkItem](#group-workitem)
        - [Group: TestCommand](#group-testcommand)
        - [Group: TestCommand/Before](#group-testcommandbefore)
        - [Group: TestCommand/After](#group-testcommandafter)
        - [Group: TestCommand/BeforeAndAfter](#group-testcommandbeforeandafter)
      - [Namespace: NUnit.Runner.Execution.Annotations](#namespace-nunitrunnerexecutionannotations)
        - [Group: Extensibility/CommandWrapper](#group-extensibilitycommandwrapper)
        - [Group: Extensibility/ContextApplier](#group-extensibilitycontextapplier)
        - [Group: Extensibility/TestAction](#group-extensibilitytestaction)
      - [Namespace: NUnit.Infrastructure](#namespace-nunitinfrastructure-1)
        - [Group: WorkShift](#group-workshift)
        - [Group: WorkShift/WorkItemQueue](#group-workshiftworkitemqueue)
        - [Group: WorkShift/TestWorker](#group-workshifttestworker)
    - [Module: NUnit.Runner.Entities](#module-nunitrunnerentities)
      - [Namespace: NUnit.Runner.Entities](#namespace-nunitrunnerentities)
        - [Group: Test](#group-test)
        - [Group: Test/Suite](#group-testsuite)
        - [Group: Test/Suite/Assembly](#group-testsuiteassembly)
        - [Group: Test/Suite/Fixture](#group-testsuitefixture)
        - [Group: Test/Suite/Method](#group-testsuitemethod)
        - [Group: Test/Method](#group-testmethod)
        - [Group: TestResult](#group-testresult)
        - [Group: TestResult/Suite](#group-testresultsuite)
        - [Group: TestResult/Case](#group-testresultcase)
        - [Group: TestData](#group-testdata)
        - [Group: TestData/Fixture](#group-testdatafixture)
        - [Group: TestData/Case](#group-testdatacase)
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
        - [Group: Constraint/Prefix](#group-constraintprefix)
        - [Group: Constraint/Binary](#group-constraintbinary)
        - [Group: Constraint/Comparison](#group-constraintcomparison)
        - [Group: Constraint/Collection](#group-constraintcollection)
        - [Group: Constraint/Collection/Items](#group-constraintcollectionitems)
        - [Group: Constraint/String](#group-constraintstring)
        - [Group: Constraint/Path](#group-constraintpath)
        - [Group: Constraint/Type](#group-constrainttype)
        - [Group: ConstraintResult](#group-constraintresult)
        - [Group: ConstraintResult/Prefix](#group-constraintresultprefix)
        - [Group: ConstraintResult/Comparison](#group-constraintresultcomparison)
        - [Group: ConstraintResult/Collection](#group-constraintresultcollection)
        - [Group: ConstraintResult/Collection/Item](#group-constraintresultcollectionitem)
        - [Group: ConstraintExpression](#group-constraintexpression)
        - [Group: ConstraintOperator](#group-constraintoperator)
        - [Group: ConstraintOperator/Prefix](#group-constraintoperatorprefix)
        - [Group: ConstraintOperator/Prefix/Collection](#group-constraintoperatorprefixcollection)
        - [Group: ConstraintOperator/Binary](#group-constraintoperatorbinary)
        - [Group: ConstraintOperator/SelfResolving](#group-constraintoperatorselfresolving)
      - [Namespace: NUnit.Infrastructure](#namespace-nunitinfrastructure-3)
        - [Group: Adapters](#group-adapters)
        - [Group: Comparers](#group-comparers)
        - [Group: Utils](#group-utils-1)
    - [Module: NUnit.Infrastructure](#module-nunitinfrastructure)
      - [Namespace: System](#namespace-system)
        - [Group: ](#group--4)
      - [Namespace: System.Threading](#namespace-systemthreading)
        - [Group: ](#group--5)
      - [Namespace: System.Async](#namespace-systemasync)
        - [Group: AsyncToSyncAdapter](#group-asynctosyncadapter)
        - [Group: AwaitAdapter](#group-awaitadapter)
      - [Namespace: System.Reflection](#namespace-systemreflection)
        - [Group: Models](#group-models)
        - [Group: Utils](#group-utils-2)
      - [Namespace: System.Environment](#namespace-systemenvironment)
        - [Group: ](#group--6)
      - [Namespace: System.Logging](#namespace-systemlogging)
        - [Group: ](#group--7)
      - [Namespace: System.Xml](#namespace-systemxml)
        - [Group: ](#group--8)
      - [Namespace: NUnit](#namespace-nunit-1)
        - [Group: Exceptions](#group-exceptions-1)
        - [Group: Utils](#group-utils-3)
      - [Namespace: NUnit.IO](#namespace-nunitio)
        - [Group: ](#group--9)
      - [Namespace: NUnit.Messaging](#namespace-nunitmessaging)
        - [Group: TestListener](#group-testlistener)
        - [Group: EventPump](#group-eventpump)
        - [Group: EventQueue](#group-eventqueue)
      - [Namespace: NUnit.Formatting](#namespace-nunitformatting)
        - [Group: ](#group--10)
      - [Namespace: NUnit.Utils](#namespace-nunitutils)
        - [Group: ](#group--11)

# Project: NUnit
## Module: NUnit.Main
### Namespace: NUnit
#### Group: 
* FrameworkPackageSettings
### Namespace: NUnit.Annotations
#### Group: 
* NUnitAttribute
* NonTestAssemblyAttribute
* TestAssemblyDirectoryResolveAttribute
### Namespace: NUnit.Api
#### Group: 
* FrameworkController
* FrameworkControllerAction
* LoadTestsAction
* CountTestsAction
* ExploreTestsAction
* RunTestsAction
* RunAsyncAction
* StopRunAction
### Namespace: NUnit.Runner
#### Group: 
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
#### Group: FixtureBuilder/SetUp
* OneTimeSetUpAttribute
* SetUpAttribute
#### Group: FixtureBuilder/TearDown
* OneTimeTearDownAttribute
* TearDownAttribute
#### Group: TestBuilder
* ITestBuilder
* ISimpleTestBuilder
* IImplyFixture
* TestAttribute
* TestCaseAttribute
* TestCaseSourceAttribute
#### Group: TestBuilder/CombiningStrategy
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
#### Group: Extensibility/TestApplier/Property
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
#### Group: Utils/TestNameGenerator
* TestNameGenerator
#### Group: Utils/ValueGenerator
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
#### Group: Test/Suite
* TestSuite
#### Group: Test/Suite/Assembly
* TestAssembly
#### Group: Test/Suite/Fixture
* IDisposableFixture
* SetUpFixture
* TestFixture
* ParameterizedFixtureSuite
#### Group: Test/Suite/Method
* ParameterizedMethodSuite
#### Group: Test/Method
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
#### Group: TestResult/Suite
* TestSuiteResult
#### Group: TestResult/Case
* TestCaseResult
#### Group: TestData
* ITestData
* TestParameters
#### Group: TestData/Fixture
* ITestFixtureData
* TestFixtureParameters
* TestFixtureData
#### Group: TestData/Case
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
#### Group: Constraint/Prefix
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
#### Group: Constraint/Binary
* BinaryConstraint
* AndConstraint
* OrConstraint
#### Group: Constraint/Comparison
* ComparisonConstraint
* LessThanConstraint
* LessThanOrEqualConstraint
* GreaterThanConstraint
* GreaterThanOrEqualConstraint
#### Group: Constraint/Collection
* CollectionConstraint
* EmptyCollectionConstraint
* CollectionOrderedConstraint
#### Group: Constraint/Collection/Items
* CollectionItemsEqualConstraint
* CollectionEquivalentConstraint
* CollectionSubsetConstraint
* CollectionSupersetConstraint
* CollectionContainsConstraint
* DictionaryContainsKeyConstraint
* DictionaryContainsValueConstraint
* UniqueItemsConstraint
#### Group: Constraint/String
* StringConstraint
* EmptyStringConstraint
* StartsWithConstraint
* EndsWithConstraint
* SubstringConstraint
* RegexConstraint
#### Group: Constraint/Path
* PathConstraint
* SamePathConstraint
* SubPathConstraint
* SamePathOrUnderConstraint
#### Group: Constraint/Type
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
#### Group: ConstraintResult/Prefix
* PropertyConstraintResult
#### Group: ConstraintResult/Comparison
* EqualConstraintResult
#### Group: ConstraintResult/Collection
* CollectionEquivalentConstraintResult
#### Group: ConstraintResult/Collection/Item
* EachItemConstraintResult
#### Group: ConstraintExpression
* ConstraintExpression
* ItemsConstraintExpression
* ResolvableConstraintExpression
#### Group: ConstraintOperator
* ConstraintOperator
#### Group: ConstraintOperator/Prefix
* PrefixOperator
* NotOperator
* WithOperator
#### Group: ConstraintOperator/Prefix/Collection
* CollectionOperator
* NoneOperator
* SomeOperator
* AllOperator
#### Group: ConstraintOperator/Binary
* BinaryOperator
* AndOperator
* OrOperator
#### Group: ConstraintOperator/SelfResolving
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
#### Group: 
* LongLivedMarshalByRefObject
* StringUtil
* Randomizer
* ThreadUtility
* ExceptionHelper
* StackFilter
* ICallbackEventHandler
### Namespace: System.Threading
#### Group: 
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
#### Group: 
* OSPlatform
* ProductType
* RuntimeFramework
* RuntimeType
### Namespace: System.Logging
#### Group: 
* InternalTrace
* InternalTraceLevel
* ILogger
* Logger
### Namespace: System.Xml
#### Group: 
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
#### Group: 
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
#### Group: 
* MsgUtils
* ValueFormatter
* ValueFormatterFactory
### Namespace: NUnit.Utils
#### Group: 
* List
* ListMapper
* CollectionTally
* CollectionTallyResult
* TypeNameDifferenceResolver
* Numerics
* FloatingPointNumerics
