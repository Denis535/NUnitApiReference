// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ProjectArchitecture.Model;

    public class NUnitModule_Infrastructure : Module {

        public override string Name => "NUnit.Infrastructure";
        public override Namespace[] Namespaces => new INode[] {
            "System".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( NUnit.Compatibility               .LongLivedMarshalByRefObject                                ),
            (TypeItem) typeof( NUnit.Framework.Internal          .StringUtil                                                 ),
            (TypeItem) typeof( NUnit.Framework.Internal          .Randomizer                                                 ),
            (TypeItem) typeof( NUnit.Framework.Internal          .ThreadUtility                                              ),
            (TypeItem) typeof( NUnit.Framework.Internal          .ExceptionHelper                                            ),
            (TypeItem) typeof( NUnit.Framework.Internal          .StackFilter                                                ),
            (TypeItem) typeof( System.Web.UI                     .ICallbackEventHandler                                      ),

            "System.Threading".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal         .SandboxedThreadState                                        ),
            (TypeItem) typeof( NUnit.Framework.Internal         .SingleThreadedTestSynchronizationContext                    ),

            "System.Async".AsNamespace(),
            "AsyncToSyncAdapter".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal         .AsyncToSyncAdapter                                          ),
            (TypeItem) typeof( NUnit.Framework.Internal         .MessagePumpStrategy                                         ),
            "AwaitAdapter".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal         .AwaitAdapter ),
            (TypeItem) typeof( NUnit.Framework.Internal         .DefaultBlockingAwaitAdapter                                 ),
            (TypeItem) typeof( NUnit.Framework.Internal         .CSharpPatternBasedAwaitAdapter                              ),
            (TypeItem) typeof( NUnit.Framework.Internal         .TaskAwaitAdapter                                            ),

            "System.Reflection".AsNamespace(),
            "Models".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Interfaces        .IReflectionInfo                                            ),
            (TypeItem) typeof( NUnit.Framework.Interfaces        .ITypeInfo                                                  ),
            (TypeItem) typeof( NUnit.Framework.Interfaces        .IMethodInfo                                                ),
            (TypeItem) typeof( NUnit.Framework.Interfaces        .IParameterInfo                                             ),
            (TypeItem) typeof( NUnit.Framework.Internal          .TypeWrapper                                                ),
            (TypeItem) typeof( NUnit.Framework.Internal          .MethodWrapper                                              ),
            (TypeItem) typeof( NUnit.Framework.Internal          .ParameterWrapper                                           ),
            "Utils".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal          .Reflect                                                    ),
            (TypeItem) typeof( NUnit.Framework.Internal          .AssemblyHelper                                             ),
            (TypeItem) typeof( NUnit.Framework.Internal          .TypeHelper                                                 ),
            (TypeItem) typeof( NUnit.Framework.Internal          .GenericMethodHelper                                        ),
            (TypeItem) typeof( NUnit.Compatibility               .AttributeHelper                                            ),

            "System.Environment".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal          .OSPlatform                                                 ),
            (TypeItem) typeof( NUnit.Framework.Internal          .OSPlatform.ProductType                                     ),
            (TypeItem) typeof( NUnit.Framework.Internal          .RuntimeFramework                                           ),
            (TypeItem) typeof( NUnit.Framework.Internal          .RuntimeType                                                ),

            "System.Logging".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal          .InternalTrace                                              ),
            (TypeItem) typeof( NUnit.Framework.Internal          .InternalTraceLevel                                         ),
            (TypeItem) typeof( NUnit.Framework.Internal          .ILogger                                                    ),
            (TypeItem) typeof( NUnit.Framework.Internal          .Logger                                                     ),

            "System.Xml".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Interfaces        .IXmlNodeBuilder                                            ),
            (TypeItem) typeof( NUnit.Framework.Interfaces        .NodeList                                                   ),
            (TypeItem) typeof( NUnit.Framework.Interfaces        .TNode                                                      ),
            (TypeItem) typeof( NUnit.Framework.Interfaces        .AttributeDictionary                                        ),

            "NUnit".AsNamespace(),
            "Exceptions".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal          .NUnitException                                             ),
            (TypeItem) typeof( NUnit.Framework.Internal          .InvalidTestFixtureException                                ),
            (TypeItem) typeof( NUnit.Framework.Internal          .InvalidDataSourceException                                 ),
            (TypeItem) typeof( NUnit.Framework.Internal          .TestCaseTimeoutException                                   ),
            (TypeItem) typeof( NUnit.Framework.Internal         .InvalidPlatformException                                    ),
            "Utils".AsGroup(),
            (TypeItem) typeof( NUnit.Framework                  .Guard                                                       ),
            (TypeItem) typeof( NUnit.Framework                  .Extensions                                                  ),
            (TypeItem) typeof( NUnit.Framework.Internal         .On                                                          ),

            "NUnit.IO".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal          .InternalTraceWriter                                        ),
            (TypeItem) typeof( NUnit.Framework.Constraints       .MessageWriter                                              ),
            (TypeItem) typeof( NUnit.Framework.Internal          .TextMessageWriter                                          ),
            (TypeItem) typeof( NUnit.Framework.Internal.Execution.TextCapture                                                ), // Sends text to TestExecutionContext.CurrentResult.OutWriter
            (TypeItem) typeof( NUnit.Framework.Internal.Execution.EventListenerTextWriter                                    ), // Sends text to TestExecutionContext.Listener

            "NUnit.Messaging".AsNamespace(),
            "TestListener".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Interfaces        .ITestListener                                              ),
            (TypeItem) typeof( NUnit.Framework.Internal          .TestListener                                               ),
            (TypeItem) typeof( NUnit.Framework.Internal          .TestProgressReporter                                       ),
            (TypeItem) typeof( NUnit.Framework.Internal.Execution.QueuingEventListener                                       ),
            (TypeItem) typeof( NUnit.Framework.Interfaces        .TestMessage                                                ),
            (TypeItem) typeof( NUnit.Framework.Interfaces        .TestOutput                                                 ),

            "EventPump".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal.Execution.EventPump                                                  ), // Route events from QueuingEventListener to ITestListener
            (TypeItem) typeof( NUnit.Framework.Internal.Execution.EventPumpState                                             ),
            "EventQueue".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Internal.Execution.EventQueue                                                 ),
            (TypeItem) typeof( NUnit.Framework.Internal.Execution.Event                                                      ),
            (TypeItem) typeof( NUnit.Framework.Internal.Execution.TestStartedEvent                                           ),
            (TypeItem) typeof( NUnit.Framework.Internal.Execution.TestFinishedEvent                                          ),
            (TypeItem) typeof( NUnit.Framework.Internal.Execution.TestOutputEvent                                            ),
            (TypeItem) typeof( NUnit.Framework.Internal.Execution.TestMessageEvent                                           ),

            "NUnit.Formatting".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( NUnit.Framework.Constraints       .MsgUtils ),
            (TypeItem) typeof( NUnit.Framework.Constraints       .ValueFormatter                                             ),
            (TypeItem) typeof( NUnit.Framework.Constraints       .ValueFormatterFactory                                      ),

            "NUnit.Utils".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( NUnit.Framework                   .List                                                       ),
            (TypeItem) typeof( NUnit.Framework                   .ListMapper                                                 ),
            (TypeItem) typeof( NUnit.Framework.Constraints       .CollectionTally                                            ),
            (TypeItem) typeof( NUnit.Framework.Constraints       .CollectionTally.CollectionTallyResult                      ),
            (TypeItem) typeof( NUnit.Framework.Internal          .TypeNameDifferenceResolver                                 ),
            (TypeItem) typeof( NUnit.Framework.Constraints       .Numerics                                                   ),
            (TypeItem) typeof( NUnit.Framework.Constraints       .FloatingPointNumerics                                      ),
        }.ToHierarchy();


    }
}
