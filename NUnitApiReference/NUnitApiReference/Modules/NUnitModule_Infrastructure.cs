// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class NUnitModule_Infrastructure : Module {

        private static readonly HeaderItem X_Infrastructure = HeaderItem.H1( "Infrastructure" );
        private static readonly HeaderItem XX_System        = HeaderItem.H2( "System" );
        private static readonly HeaderItem XX_NUnit         = HeaderItem.H2( "NUnit" );


        public override Item[] Items => new Item[] {
            X_Infrastructure,

            XX_System,
            typeof( NUnit.Compatibility               .LongLivedMarshalByRefObject           ),
            typeof( NUnit.Framework.Internal          .StringUtil                            ),
            typeof( NUnit.Framework.Internal          .Randomizer                            ),
            typeof( NUnit.Framework.Internal          .ThreadUtility                         ),
            typeof( NUnit.Framework.Internal          .ExceptionHelper                       ),
            typeof( NUnit.Framework.Internal          .StackFilter                           ),
            typeof( System.Web.UI                     .ICallbackEventHandler                 ),
            "Reflection",
            typeof( NUnit.Framework.Internal          .Reflect                               ),
            typeof( NUnit.Framework.Internal          .AssemblyHelper                        ),
            typeof( NUnit.Framework.Internal          .TypeHelper                            ),
            typeof( NUnit.Framework.Internal          .GenericMethodHelper                   ),
            typeof( NUnit.Compatibility               .AttributeHelper                       ),
            "Reflection/Model",
            typeof( NUnit.Framework.Interfaces        .IReflectionInfo                       ),
            typeof( NUnit.Framework.Interfaces        .ITypeInfo                             ),
            typeof( NUnit.Framework.Interfaces        .IMethodInfo                           ),
            typeof( NUnit.Framework.Interfaces        .IParameterInfo                        ),
            typeof( NUnit.Framework.Internal          .TypeWrapper                           ),
            typeof( NUnit.Framework.Internal          .MethodWrapper                         ),
            typeof( NUnit.Framework.Internal          .ParameterWrapper                      ),
            "Environment",
            typeof( NUnit.Framework.Internal          .OSPlatform                            ),
            typeof( NUnit.Framework.Internal          .OSPlatform.ProductType                ),
            typeof( NUnit.Framework.Internal          .RuntimeFramework                      ),
            typeof( NUnit.Framework.Internal          .RuntimeType                           ),
            "Logging",
            typeof( NUnit.Framework.Internal          .InternalTrace                         ),
            typeof( NUnit.Framework.Internal          .InternalTraceLevel                    ),
            typeof( NUnit.Framework.Internal          .ILogger                               ),
            typeof( NUnit.Framework.Internal          .Logger                                ),
            "Xml",
            typeof( NUnit.Framework.Interfaces        .IXmlNodeBuilder                       ),
            typeof( NUnit.Framework.Interfaces        .NodeList                              ),
            typeof( NUnit.Framework.Interfaces        .TNode                                 ),
            typeof( NUnit.Framework.Interfaces        .AttributeDictionary                   ),

            XX_NUnit,
            typeof( NUnit                             .FrameworkPackageSettings              ),
            typeof( NUnit.Framework.Internal          .TypeNameDifferenceResolver            ),
            "Collections",
            typeof( NUnit.Framework                   .List                                  ),
            typeof( NUnit.Framework                   .ListMapper                            ),
            typeof( NUnit.Framework.Internal.Execution.EventQueue                            ),
            typeof( NUnit.Framework.Constraints       .CollectionTally                       ),
            typeof( NUnit.Framework.Constraints       .CollectionTally.CollectionTallyResult ),
            "Formatter",
            typeof( NUnit.Framework.Constraints       .ValueFormatter                        ),
            typeof( NUnit.Framework.Constraints       .ValueFormatterFactory                 ),
            "TextWriter",
            typeof( NUnit.Framework.Internal.Execution.TextCapture                           ),
            typeof( NUnit.Framework.Internal.Execution.EventListenerTextWriter               ),
            typeof( NUnit.Framework.Internal          .InternalTraceWriter                   ),
            typeof( NUnit.Framework.Constraints       .MessageWriter                         ),
            typeof( NUnit.Framework.Internal          .TextMessageWriter                     ),
            "TestListener",
            typeof( NUnit.Framework.Interfaces        .ITestListener                         ),
            typeof( NUnit.Framework.Internal          .TestListener                          ),
            typeof( NUnit.Framework.Internal          .TestProgressReporter                  ),
            typeof( NUnit.Framework.Internal.Execution.QueuingEventListener                  ),
            typeof( NUnit.Framework.Interfaces        .TestMessage                           ),
            typeof( NUnit.Framework.Interfaces        .TestOutput                            ),
            "EventPump",
            typeof( NUnit.Framework.Internal.Execution.EventPump                             ),
            typeof( NUnit.Framework.Internal.Execution.EventPumpState                        ),
            "Event",
            typeof( NUnit.Framework.Internal.Execution.Event                                 ),
            typeof( NUnit.Framework.Internal.Execution.TestStartedEvent                      ),
            typeof( NUnit.Framework.Internal.Execution.TestFinishedEvent                     ),
            typeof( NUnit.Framework.Internal.Execution.TestOutputEvent                       ),
            typeof( NUnit.Framework.Internal.Execution.TestMessageEvent                      ),
            "WorkShift",
            typeof( NUnit.Framework.Internal.Execution.WorkShift                             ),
            typeof( NUnit.Framework.Internal.Execution.TestWorker                            ),
            typeof( NUnit.Framework.Internal.Execution.TestWorker.TestWorkerEventHandler     ),
            typeof( NUnit.Framework.Internal.Execution.WorkItemQueue                         ),
            typeof( NUnit.Framework.Internal.Execution.WorkItemQueueState                    ),
            typeof( NUnit.Framework.Internal.Execution.ShiftChangeEventHandler               ),
        };


    }
}
