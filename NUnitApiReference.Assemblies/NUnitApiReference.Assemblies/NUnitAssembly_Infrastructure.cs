// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference.Assemblies {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class NUnitAssembly_Infrastructure {


        public static readonly Type[] Types = new[] {
            // Infrastructure
            typeof( NUnit.FrameworkPackageSettings                                               ),
            typeof( NUnit.Framework.Internal.PropertyNames                                       ),
            typeof( NUnit.Framework.Internal.TestNameGenerator                                   ),
            typeof( NUnit.Framework.Internal.TypeNameDifferenceResolver                          ),
            typeof( NUnit.Framework.Internal.PlatformHelper                                      ),
            typeof( NUnit.Framework.Internal.CultureDetector                                     ),
            typeof( NUnit.Framework.Interfaces.IPropertyBag                                      ),
            typeof( NUnit.Framework.Internal.PropertyBag                                         ),
            typeof( NUnit.Framework.Internal.Execution.EventPump                                 ),
            typeof( NUnit.Framework.Internal.Execution.EventPumpState                            ),
            typeof( NUnit.Framework.List                                                         ),
            typeof( NUnit.Framework.ListMapper                                                   ),
            // Infrastructure/ITestListener
            typeof( NUnit.Framework.Interfaces.ITestListener                                     ),
            typeof( NUnit.Framework.Interfaces.TestMessage                                       ),
            typeof( NUnit.Framework.Interfaces.TestOutput                                        ),
            typeof( NUnit.Framework.Internal.TestListener                                        ),
            typeof( NUnit.Framework.Internal.TestProgressReporter                                ),
            // Infrastructure/ITestListener/QueuingEventListener
            typeof( NUnit.Framework.Internal.Execution.QueuingEventListener                      ),
            typeof( NUnit.Framework.Internal.Execution.EventQueue                                ),
            typeof( NUnit.Framework.Internal.Execution.Event                                     ),
            typeof( NUnit.Framework.Internal.Execution.TestStartedEvent                          ),
            typeof( NUnit.Framework.Internal.Execution.TestFinishedEvent                         ),
            typeof( NUnit.Framework.Internal.Execution.TestOutputEvent                           ),
            typeof( NUnit.Framework.Internal.Execution.TestMessageEvent                          ),
            // Infrastructure/TextWriter
            typeof( NUnit.Framework.Internal.Execution.TextCapture                               ),
            typeof( NUnit.Framework.Internal.Execution.EventListenerTextWriter                   ),
            typeof( NUnit.Framework.Internal.InternalTraceWriter                                 ),
            typeof( NUnit.Framework.Constraints.MessageWriter                                    ),
            typeof( NUnit.Framework.Internal.TextMessageWriter                                   ),
            // Infrastructure/Logging
            typeof( NUnit.Framework.Internal.InternalTrace                                       ),
            typeof( NUnit.Framework.Internal.InternalTraceLevel                                  ),
            typeof( NUnit.Framework.Internal.ILogger                                             ),
            typeof( NUnit.Framework.Internal.Logger                                              ),
            // Infrastructure/Net
            typeof( NUnit.Compatibility.LongLivedMarshalByRefObject                              ),
            typeof( NUnit.Framework.Internal.OSPlatform                                          ),
            typeof( NUnit.Framework.Internal.OSPlatform.ProductType                              ),
            typeof( NUnit.Framework.Internal.RuntimeFramework                                    ),
            typeof( NUnit.Framework.Internal.RuntimeType                                         ),
            typeof( NUnit.Framework.Internal.StringUtil                                          ),
            typeof( NUnit.Framework.Internal.Randomizer                                          ),
            typeof( NUnit.Framework.Internal.ThreadUtility                                       ),
            typeof( NUnit.Framework.Internal.ExceptionHelper                                     ),
            typeof( NUnit.Framework.Internal.StackFilter                                         ),
            typeof( System.Web.UI.ICallbackEventHandler                                          ),
            // Infrastructure/Reflection
            typeof( NUnit.Framework.Internal.Reflect                                             ),
            typeof( NUnit.Framework.Internal.AssemblyHelper                                      ),
            typeof( NUnit.Framework.Internal.TypeHelper                                          ),
            typeof( NUnit.Framework.Internal.GenericMethodHelper                                 ),
            typeof( NUnit.Compatibility.AttributeHelper                                          ),
            typeof( NUnit.Framework.Interfaces.IReflectionInfo                                   ),
            typeof( NUnit.Framework.Interfaces.ITypeInfo                                         ),
            typeof( NUnit.Framework.Interfaces.IMethodInfo                                       ),
            typeof( NUnit.Framework.Interfaces.IParameterInfo                                    ),
            typeof( NUnit.Framework.Internal.TypeWrapper                                         ),
            typeof( NUnit.Framework.Internal.MethodWrapper                                       ),
            typeof( NUnit.Framework.Internal.ParameterWrapper                                    ),
            // Infrastructure/Xml
            typeof( NUnit.Framework.Interfaces.IXmlNodeBuilder                                   ),
            typeof( NUnit.Framework.Interfaces.NodeList                                          ),
            typeof( NUnit.Framework.Interfaces.TNode                                             ),
            typeof( NUnit.Framework.Interfaces.AttributeDictionary                               ),
        };


    }
}
