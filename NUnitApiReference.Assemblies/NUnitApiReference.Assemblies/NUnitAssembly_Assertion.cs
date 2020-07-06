// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference.Assemblies {
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class NUnitAssembly_Assertion {


        public static readonly Type[] Types = new[] {
            // Assertion
            typeof( NUnit.Framework.Assert                                                       ),
            typeof( NUnit.Framework.StringAssert                                                 ),
            typeof( NUnit.Framework.CollectionAssert                                             ),
            typeof( NUnit.Framework.DirectoryAssert                                              ),
            typeof( NUnit.Framework.FileAssert                                                   ),
            typeof( NUnit.Framework.Warn                                                         ),
            typeof( NUnit.Framework.Assume                                                       ),
            // Assertion/Constraints
            typeof( NUnit.Framework.Is                                                           ),
            typeof( NUnit.Framework.Iz                                                           ),
            typeof( NUnit.Framework.Has                                                          ),
            typeof( NUnit.Framework.Does                                                         ),
            typeof( NUnit.Framework.Contains                                                     ),
            typeof( NUnit.Framework.Throws                                                       ),
            // Assertion/Exceptions
            typeof( NUnit.Framework.ResultStateException                                         ),
            typeof( NUnit.Framework.AssertionException                                           ),
            typeof( NUnit.Framework.MultipleAssertException                                      ),
            typeof( NUnit.Framework.InconclusiveException                                        ),
            typeof( NUnit.Framework.IgnoreException                                              ),
            typeof( NUnit.Framework.SuccessException                                             ),
            // Assertion/Delegates
            typeof( NUnit.Framework.TestDelegate                                                 ),
            typeof( NUnit.Framework.AsyncTestDelegate                                            ),

            // Constraints
            typeof( NUnit.Framework.Constraints.IResolveConstraint                               ),
            typeof( NUnit.Framework.Constraints.IConstraint                                      ),
            typeof( NUnit.Framework.Constraints.Constraint                                       ),
            typeof( NUnit.Framework.Constraints.NullConstraint                                   ),
            typeof( NUnit.Framework.Constraints.FalseConstraint                                  ),
            typeof( NUnit.Framework.Constraints.TrueConstraint                                   ),
            typeof( NUnit.Framework.Constraints.NaNConstraint                                    ),
            typeof( NUnit.Framework.Constraints.EqualConstraint                                  ),
            typeof( NUnit.Framework.Constraints.SameAsConstraint                                 ),
            typeof( NUnit.Framework.Constraints.RangeConstraint                                  ),
            typeof( NUnit.Framework.Constraints.AnyOfConstraint                                  ),
            typeof( NUnit.Framework.Constraints.ExactCountConstraint                             ),
            typeof( NUnit.Framework.Constraints.EmptyConstraint                                  ),
            typeof( NUnit.Framework.Constraints.ContainsConstraint                               ),
            typeof( NUnit.Framework.Constraints.AttributeExistsConstraint                        ),
            typeof( NUnit.Framework.Constraints.PropertyExistsConstraint                         ),
            typeof( NUnit.Framework.Constraints.BinarySerializableConstraint                     ),
            typeof( NUnit.Framework.Constraints.XmlSerializableConstraint                        ),
            typeof( NUnit.Framework.Constraints.EmptyDirectoryConstraint                         ),
            typeof( NUnit.Framework.Constraints.FileOrDirectoryExistsConstraint                  ),
            typeof( NUnit.Framework.Constraints.PredicateConstraint<>                            ),
            typeof( NUnit.Framework.Constraints.ThrowsExceptionConstraint                        ),
            typeof( NUnit.Framework.Constraints.ThrowsNothingConstraint                          ),
            // Constraints/Prefix
            typeof( NUnit.Framework.Constraints.PrefixConstraint                                 ),
            typeof( NUnit.Framework.Constraints.NotConstraint                                    ),
            typeof( NUnit.Framework.Constraints.AttributeConstraint                              ),
            typeof( NUnit.Framework.Constraints.PropertyConstraint                               ),
            typeof( NUnit.Framework.Constraints.NoItemConstraint                                 ),
            typeof( NUnit.Framework.Constraints.SomeItemsConstraint                              ),
            typeof( NUnit.Framework.Constraints.AllItemsConstraint                               ),
            typeof( NUnit.Framework.Constraints.ThrowsConstraint                                 ),
            typeof( NUnit.Framework.Constraints.DelayedConstraint                                ),
            typeof( NUnit.Framework.Constraints.DelayedConstraint.WithRawDelayInterval           ),
            typeof( NUnit.Framework.Constraints.DelayedConstraint.WithDimensionedDelayInterval   ),
            typeof( NUnit.Framework.Constraints.DelayedConstraint.WithRawPollingInterval         ),
            // Constraints/Binary
            typeof( NUnit.Framework.Constraints.BinaryConstraint                                 ),
            typeof( NUnit.Framework.Constraints.AndConstraint                                    ),
            typeof( NUnit.Framework.Constraints.OrConstraint                                     ),
            // Constraints/Comparison
            typeof( NUnit.Framework.Constraints.ComparisonConstraint                             ),
            typeof( NUnit.Framework.Constraints.LessThanConstraint                               ),
            typeof( NUnit.Framework.Constraints.LessThanOrEqualConstraint                        ),
            typeof( NUnit.Framework.Constraints.GreaterThanConstraint                            ),
            typeof( NUnit.Framework.Constraints.GreaterThanOrEqualConstraint                     ),
            // Constraints/Collection
            typeof( NUnit.Framework.Constraints.CollectionConstraint                             ),
            typeof( NUnit.Framework.Constraints.EmptyCollectionConstraint                        ),
            typeof( NUnit.Framework.Constraints.CollectionOrderedConstraint                      ),
            // Constraints/Collection/Items
            typeof( NUnit.Framework.Constraints.CollectionItemsEqualConstraint                   ),
            typeof( NUnit.Framework.Constraints.CollectionEquivalentConstraint                   ),
            typeof( NUnit.Framework.Constraints.CollectionSubsetConstraint                       ),
            typeof( NUnit.Framework.Constraints.CollectionSupersetConstraint                     ),
            typeof( NUnit.Framework.Constraints.CollectionContainsConstraint                     ),
            typeof( NUnit.Framework.Constraints.DictionaryContainsKeyConstraint                  ),
            typeof( NUnit.Framework.Constraints.DictionaryContainsValueConstraint                ),
            typeof( NUnit.Framework.Constraints.UniqueItemsConstraint                            ),
            // Constraints/String
            typeof( NUnit.Framework.Constraints.StringConstraint                                 ),
            typeof( NUnit.Framework.Constraints.EmptyStringConstraint                            ),
            typeof( NUnit.Framework.Constraints.StartsWithConstraint                             ),
            typeof( NUnit.Framework.Constraints.EndsWithConstraint                               ),
            typeof( NUnit.Framework.Constraints.SubstringConstraint                              ),
            typeof( NUnit.Framework.Constraints.RegexConstraint                                  ),
            // Constraints/Path
            typeof( NUnit.Framework.Constraints.PathConstraint                                   ),
            typeof( NUnit.Framework.Constraints.SamePathConstraint                               ),
            typeof( NUnit.Framework.Constraints.SubPathConstraint                                ),
            typeof( NUnit.Framework.Constraints.SamePathOrUnderConstraint                        ),
            // Constraints/Type
            typeof( NUnit.Framework.Constraints.TypeConstraint                                   ),
            typeof( NUnit.Framework.Constraints.ExactTypeConstraint                              ),
            typeof( NUnit.Framework.Constraints.ExceptionTypeConstraint                          ),
            typeof( NUnit.Framework.Constraints.AssignableFromConstraint                         ),
            typeof( NUnit.Framework.Constraints.AssignableToConstraint                           ),
            typeof( NUnit.Framework.Constraints.InstanceOfTypeConstraint                         ),
            // Constraints/Misc
            typeof( NUnit.Framework.Constraints.ReusableConstraint                               ),
            // Constraints/Delegates
            typeof( NUnit.Framework.Constraints.ActualValueDelegate<>                            ),
            typeof( NUnit.Framework.Constraints.ValueFormatter                                   ),
            typeof( NUnit.Framework.Constraints.ValueFormatterFactory                            ),
            // Constraint/Result
            typeof( NUnit.Framework.Constraints.ConstraintResult                                 ),
            typeof( NUnit.Framework.Constraints.EqualConstraintResult                            ),
            typeof( NUnit.Framework.Constraints.CollectionEquivalentConstraintResult             ),
            typeof( NUnit.Framework.Constraints.ConstraintStatus                                 ),

            // Expressions
            typeof( NUnit.Framework.Constraints.ConstraintExpression                             ),
            typeof( NUnit.Framework.Constraints.ItemsConstraintExpression                        ),
            typeof( NUnit.Framework.Constraints.ResolvableConstraintExpression                   ),

            // Operators
            typeof( NUnit.Framework.Constraints.ConstraintOperator                               ),
            // Operators/Prefix
            typeof( NUnit.Framework.Constraints.PrefixOperator                                   ),
            typeof( NUnit.Framework.Constraints.NotOperator                                      ),
            typeof( NUnit.Framework.Constraints.WithOperator                                     ),
            // Operators/Prefix/Collection
            typeof( NUnit.Framework.Constraints.CollectionOperator                               ),
            typeof( NUnit.Framework.Constraints.NoneOperator                                     ),
            typeof( NUnit.Framework.Constraints.SomeOperator                                     ),
            typeof( NUnit.Framework.Constraints.AllOperator                                      ),
            // Operators/Binary
            typeof( NUnit.Framework.Constraints.BinaryOperator                                   ),
            typeof( NUnit.Framework.Constraints.AndOperator                                      ),
            typeof( NUnit.Framework.Constraints.OrOperator                                       ),
            // Operators/SelfResolving
            typeof( NUnit.Framework.Constraints.SelfResolvingOperator                            ),
            typeof( NUnit.Framework.Constraints.AttributeOperator                                ),
            typeof( NUnit.Framework.Constraints.PropOperator                                     ),
            typeof( NUnit.Framework.Constraints.ExactCountOperator                               ),
            typeof( NUnit.Framework.Constraints.ThrowsOperator                                   ),

            // Utils
            typeof( NUnit.Framework.Constraints.Numerics                                         ),
            typeof( NUnit.Framework.Constraints.Interval                                         ),
            typeof( NUnit.Framework.Constraints.Tolerance                                        ),
            typeof( NUnit.Framework.Constraints.Tolerance.Range                                  ),
            typeof( NUnit.Framework.Constraints.ToleranceMode                                    ),
            // Infrastructure
            typeof( NUnit.Framework.Constraints.ConstraintBuilder                                ),
            typeof( NUnit.Framework.Constraints.ConstraintBuilder.ConstraintStack                ),
            typeof( NUnit.Framework.Constraints.CollectionTally                                  ),
            typeof( NUnit.Framework.Constraints.CollectionTally.CollectionTallyResult            ),
            typeof( NUnit.Framework.Constraints.EqualityAdapter                                  ),
            typeof( NUnit.Framework.Constraints.ComparisonAdapter                                ),
            typeof( NUnit.Framework.Constraints.NUnitEqualityComparer                            ),
            typeof( NUnit.Framework.Constraints.NUnitEqualityComparer.FailurePoint               ),
            typeof( NUnit.Framework.Constraints.NUnitComparer                                    ),
        };


    }
}
