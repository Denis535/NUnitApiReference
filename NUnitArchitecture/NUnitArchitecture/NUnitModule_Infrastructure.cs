// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ProjectArchitecture.Model;
    using static NUnitProject;

    public class NUnitModule_Infrastructure : Module {

        public override string Name => "NUnit.Infrastructure";
        public override Namespace[] Namespaces => new Namespace[] {
            new Namespace(
                "System",
                new Group(
                    null,
                    typeof( NUnit.Compatibility               .LongLivedMarshalByRefObject                                ),
                    typeof( NUnit.Framework.Internal          .StringUtil                                                 ),
                    typeof( NUnit.Framework.Internal          .Randomizer                                                 ),
                    typeof( NUnit.Framework.Internal          .ThreadUtility                                              ),
                    typeof( NUnit.Framework.Internal          .ExceptionHelper                                            ),
                    typeof( NUnit.Framework.Internal          .StackFilter                                                ),
                    typeof( System.Web.UI                     .ICallbackEventHandler                                      )
                )
            ),
            new Namespace(
                "System.Threading",
                new Group(
                    null,
                    TypeOf( "NUnit.Framework.Internal         .SandboxedThreadState"                                      ),
                    TypeOf( "NUnit.Framework.Internal         .SingleThreadedTestSynchronizationContext"                  )
                )
            ),
            new Namespace(
                "System.Async",
                new Group(
                    "AsyncToSyncAdapter",
                    TypeOf( "NUnit.Framework.Internal         .AsyncToSyncAdapter"                                        ),
                    TypeOf( "NUnit.Framework.Internal         .MessagePumpStrategy"                                       )
                ),
                new Group(
                    "AwaitAdapter",
                    TypeOf( "NUnit.Framework.Internal         .AwaitAdapter" ),
                    TypeOf( "NUnit.Framework.Internal         .DefaultBlockingAwaitAdapter"                               ),
                    TypeOf( "NUnit.Framework.Internal         .CSharpPatternBasedAwaitAdapter"                            ),
                    TypeOf( "NUnit.Framework.Internal         .TaskAwaitAdapter"                                          )
                )
            ),
            new Namespace(
                "System.Reflection",
                new Group(
                    "Models",
                    typeof( NUnit.Framework.Interfaces        .IReflectionInfo                                            ),
                    typeof( NUnit.Framework.Interfaces        .ITypeInfo                                                  ),
                    typeof( NUnit.Framework.Interfaces        .IMethodInfo                                                ),
                    typeof( NUnit.Framework.Interfaces        .IParameterInfo                                             ),
                    typeof( NUnit.Framework.Internal          .TypeWrapper                                                ),
                    typeof( NUnit.Framework.Internal          .MethodWrapper                                              ),
                    typeof( NUnit.Framework.Internal          .ParameterWrapper                                           )
                ),
                new Group(
                    "Utils",
                    typeof( NUnit.Framework.Internal          .Reflect                                                    ),
                    typeof( NUnit.Framework.Internal          .AssemblyHelper                                             ),
                    typeof( NUnit.Framework.Internal          .TypeHelper                                                 ),
                    typeof( NUnit.Framework.Internal          .GenericMethodHelper                                        ),
                    typeof( NUnit.Compatibility               .AttributeHelper                                            )
                )
            ),
            new Namespace(
                "System.Environment",
                new Group(
                    null,
                    typeof( NUnit.Framework.Internal          .OSPlatform                                                 ),
                    typeof( NUnit.Framework.Internal          .OSPlatform.ProductType                                     ),
                    typeof( NUnit.Framework.Internal          .RuntimeFramework                                           ),
                    typeof( NUnit.Framework.Internal          .RuntimeType                                                )
                )
            ),
            new Namespace(
                "System.Logging",
                new Group(
                    null,
                    typeof( NUnit.Framework.Internal          .InternalTrace                                              ),
                    typeof( NUnit.Framework.Internal          .InternalTraceLevel                                         ),
                    typeof( NUnit.Framework.Internal          .ILogger                                                    ),
                    typeof( NUnit.Framework.Internal          .Logger                                                     )
                )
            ),
            new Namespace(
                "System.Xml",
                new Group(
                    null,
                    typeof( NUnit.Framework.Interfaces        .IXmlNodeBuilder                                            ),
                    typeof( NUnit.Framework.Interfaces        .NodeList                                                   ),
                    typeof( NUnit.Framework.Interfaces        .TNode                                                      ),
                    typeof( NUnit.Framework.Interfaces        .AttributeDictionary                                        )
                )
            ),
            new Namespace(
                "NUnit",
                new Group(
                    "Exceptions",
                    typeof( NUnit.Framework.Internal          .NUnitException                                             ),
                    typeof( NUnit.Framework.Internal          .InvalidTestFixtureException                                ),
                    typeof( NUnit.Framework.Internal          .InvalidDataSourceException                                 ),
                    typeof( NUnit.Framework.Internal          .TestCaseTimeoutException                                   ),
                    TypeOf( "NUnit.Framework.Internal         .InvalidPlatformException"                                  )
                ),
                new Group(
                    "Utils",
                    TypeOf( "NUnit.Framework                  .Guard"                                                     ),
                    TypeOf( "NUnit.Framework                  .Extensions"                                                ),
                    TypeOf( "NUnit.Framework.Internal         .On"                                                        )
                )
            ),
            new Namespace(
                "NUnit.IO",
                new Group(
                    null,
                    typeof( NUnit.Framework.Internal          .InternalTraceWriter                                        ),
                    typeof( NUnit.Framework.Constraints       .MessageWriter                                              ),
                    typeof( NUnit.Framework.Internal          .TextMessageWriter                                          ),
                    typeof( NUnit.Framework.Internal.Execution.TextCapture                                                ), // Sends text to TestExecutionContext.CurrentResult.OutWriter
                    typeof( NUnit.Framework.Internal.Execution.EventListenerTextWriter                                    )  // Sends text to TestExecutionContext.Listener
                )
            ),
            new Namespace(
                "NUnit.Messaging",
                new Group(
                    "TestListener",
                    typeof( NUnit.Framework.Interfaces        .ITestListener                                              ),
                    typeof( NUnit.Framework.Internal          .TestListener                                               ),
                    typeof( NUnit.Framework.Internal          .TestProgressReporter                                       ),
                    typeof( NUnit.Framework.Internal.Execution.QueuingEventListener                                       ),
                    typeof( NUnit.Framework.Interfaces        .TestMessage                                                ),
                    typeof( NUnit.Framework.Interfaces        .TestOutput                                                 )
                ),
                new Group(
                    "EventPump",
                    typeof( NUnit.Framework.Internal.Execution.EventPump                                                  ), // Route events from QueuingEventListener to ITestListener
                    typeof( NUnit.Framework.Internal.Execution.EventPumpState                                             )
                ),
                new Group(
                    "EventQueue",
                    typeof( NUnit.Framework.Internal.Execution.EventQueue                                                 ),
                    typeof( NUnit.Framework.Internal.Execution.Event                                                      ),
                    typeof( NUnit.Framework.Internal.Execution.TestStartedEvent                                           ),
                    typeof( NUnit.Framework.Internal.Execution.TestFinishedEvent                                          ),
                    typeof( NUnit.Framework.Internal.Execution.TestOutputEvent                                            ),
                    typeof( NUnit.Framework.Internal.Execution.TestMessageEvent                                           )
                )
            ),
            new Namespace(
                "NUnit.Formatting",
                new Group(
                    null,
                    TypeOf( "NUnit.Framework.Constraints      .MsgUtils" ),
                    typeof( NUnit.Framework.Constraints       .ValueFormatter                                             ),
                    typeof( NUnit.Framework.Constraints       .ValueFormatterFactory                                      )
                )
            ),
            new Namespace(
                "NUnit.Utils",
                new Group(
                    null,
                    typeof( NUnit.Framework                   .List                                                       ),
                    typeof( NUnit.Framework                   .ListMapper                                                 ),
                    typeof( NUnit.Framework.Constraints       .CollectionTally                                            ),
                    typeof( NUnit.Framework.Constraints       .CollectionTally.CollectionTallyResult                      ),
                    typeof( NUnit.Framework.Internal          .TypeNameDifferenceResolver                                 ),
                    typeof( NUnit.Framework.Constraints       .Numerics                                                   ),
                    TypeOf( "NUnit.Framework.Constraints      .FloatingPointNumerics"                                     )
                )
            ),
        };


    }
}
