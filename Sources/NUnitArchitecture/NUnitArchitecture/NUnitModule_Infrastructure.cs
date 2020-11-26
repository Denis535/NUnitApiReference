// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitArchitecture {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Web.UI;
    using NUnit.Compatibility;
    using NUnit.Framework;
    using NUnit.Framework.Constraints;
    using NUnit.Framework.Interfaces;
    using NUnit.Framework.Internal;
    using NUnit.Framework.Internal.Execution;
    using ProjectArchitecture.Model;

    public class NUnitModule_Infrastructure : Module {

        public override string Name => "NUnit.Infrastructure";
        public override Namespace[] Namespaces => new INode[] {
            "System".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( LongLivedMarshalByRefObject                                ),
            (TypeItem) typeof( StringUtil                                                 ),
            (TypeItem) typeof( Randomizer                                                 ),
            (TypeItem) typeof( ThreadUtility                                              ),
            (TypeItem) typeof( ExceptionHelper                                            ),
            (TypeItem) typeof( StackFilter                                                ),
            (TypeItem) typeof( ICallbackEventHandler                                      ),

            "System.Threading".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( SandboxedThreadState                                       ),
            (TypeItem) typeof( SingleThreadedTestSynchronizationContext                   ),

            "System.Async".AsNamespace(),
            "AsyncToSyncAdapter".AsGroup(),
            (TypeItem) typeof( AsyncToSyncAdapter                                         ),
            (TypeItem) typeof( MessagePumpStrategy                                        ),
            "AwaitAdapter".AsGroup(),
            (TypeItem) typeof( AwaitAdapter ),
            (TypeItem) typeof( DefaultBlockingAwaitAdapter                                ),
            (TypeItem) typeof( CSharpPatternBasedAwaitAdapter                             ),
            (TypeItem) typeof( TaskAwaitAdapter                                           ),

            "System.Reflection".AsNamespace(),
            "Models".AsGroup(),
            (TypeItem) typeof( IReflectionInfo                                            ),
            (TypeItem) typeof( ITypeInfo                                                  ),
            (TypeItem) typeof( IMethodInfo                                                ),
            (TypeItem) typeof( IParameterInfo                                             ),
            (TypeItem) typeof( TypeWrapper                                                ),
            (TypeItem) typeof( MethodWrapper                                              ),
            (TypeItem) typeof( ParameterWrapper                                           ),
            "Utils".AsGroup(),
            (TypeItem) typeof( Reflect                                                    ),
            (TypeItem) typeof( AssemblyHelper                                             ),
            (TypeItem) typeof( TypeHelper                                                 ),
            (TypeItem) typeof( GenericMethodHelper                                        ),
            (TypeItem) typeof( AttributeHelper                                            ),

            "System.Environment".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( OSPlatform                                                 ),
            (TypeItem) typeof( OSPlatform.ProductType                                     ),
            (TypeItem) typeof( RuntimeFramework                                           ),
            (TypeItem) typeof( RuntimeType                                                ),

            "System.Logging".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( InternalTrace                                              ),
            (TypeItem) typeof( InternalTraceLevel                                         ),
            (TypeItem) typeof( ILogger                                                    ),
            (TypeItem) typeof( Logger                                                     ),

            "System.Xml".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( IXmlNodeBuilder                                            ),
            (TypeItem) typeof( NodeList                                                   ),
            (TypeItem) typeof( TNode                                                      ),
            (TypeItem) typeof( AttributeDictionary                                        ),

            "NUnit".AsNamespace(),
            "Exceptions".AsGroup(),
            (TypeItem) typeof( NUnitException                                             ),
            (TypeItem) typeof( InvalidTestFixtureException                                ),
            (TypeItem) typeof( InvalidDataSourceException                                 ),
            (TypeItem) typeof( TestCaseTimeoutException                                   ),
            (TypeItem) typeof( InvalidPlatformException                                   ),
            "Utils".AsGroup(),
            (TypeItem) typeof( Guard                                                      ),
            (TypeItem) typeof( Extensions                                                 ),
            (TypeItem) typeof( On                                                         ),

            "NUnit.IO".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( InternalTraceWriter                                        ),
            (TypeItem) typeof( MessageWriter                                              ),
            (TypeItem) typeof( TextMessageWriter                                          ),
            (TypeItem) typeof( TextCapture                                                ), // Sends text to TestExecutionContext.CurrentResult.OutWriter
            (TypeItem) typeof( EventListenerTextWriter                                    ), // Sends text to TestExecutionContext.Listener

            "NUnit.Messaging".AsNamespace(),
            "TestListener".AsGroup(),
            (TypeItem) typeof( ITestListener                                              ),
            (TypeItem) typeof( TestListener                                               ),
            (TypeItem) typeof( TestProgressReporter                                       ),
            (TypeItem) typeof( QueuingEventListener                                       ),
            (TypeItem) typeof( TestMessage                                                ),
            (TypeItem) typeof( TestOutput                                                 ),

            "EventPump".AsGroup(),
            (TypeItem) typeof( EventPump                                                  ), // Route events from QueuingEventListener to ITestListener
            (TypeItem) typeof( EventPumpState                                             ),
            "EventQueue".AsGroup(),
            (TypeItem) typeof( EventQueue                                                 ),
            (TypeItem) typeof( Event                                                      ),
            (TypeItem) typeof( TestStartedEvent                                           ),
            (TypeItem) typeof( TestFinishedEvent                                          ),
            (TypeItem) typeof( TestOutputEvent                                            ),
            (TypeItem) typeof( TestMessageEvent                                           ),

            "NUnit.Formatting".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( MsgUtils ),
            (TypeItem) typeof( ValueFormatter                                             ),
            (TypeItem) typeof( ValueFormatterFactory                                      ),

            "NUnit.Utils".AsNamespace(),
            "".AsGroup(),
            (TypeItem) typeof( List                                                       ),
            (TypeItem) typeof( ListMapper                                                 ),
            (TypeItem) typeof( CollectionTally                                            ),
            (TypeItem) typeof( CollectionTally.CollectionTallyResult                      ),
            (TypeItem) typeof( TypeNameDifferenceResolver                                 ),
            (TypeItem) typeof( Numerics                                                   ),
            (TypeItem) typeof( FloatingPointNumerics                                      ),
        }.ToHierarchy();


    }
}
