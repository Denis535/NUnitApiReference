// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ApiReference;

    public class NUnitModule_Assertion : Module {

        public override string Name => "NUnit.Assertion";
        public override Namespace[] Namespaces => new Namespace[] {
            new Namespace(
                "NUnit.Assertions",
                // Assert
                typeof( NUnit.Framework            .Assert                                         ),
                typeof( NUnit.Framework            .StringAssert                                   ),
                typeof( NUnit.Framework            .CollectionAssert                               ),
                typeof( NUnit.Framework            .DirectoryAssert                                ),
                typeof( NUnit.Framework            .FileAssert                                     ),
                typeof( NUnit.Framework            .Warn                                           ),
                typeof( NUnit.Framework            .Assume                                         ),
                // ToBe
                typeof( NUnit.Framework            .Is                                             ),
                typeof( NUnit.Framework            .Iz                                             ),
                typeof( NUnit.Framework            .Has                                            ),
                typeof( NUnit.Framework            .Does                                           ),
                typeof( NUnit.Framework            .Contains                                       ),
                typeof( NUnit.Framework            .Throws                                         ),
                // Delegates
                typeof( NUnit.Framework            .TestDelegate                                   ),
                typeof( NUnit.Framework            .AsyncTestDelegate                              ),
                typeof( NUnit.Framework.Constraints.ActualValueDelegate<>                          ),
                // Exceptions
                typeof( NUnit.Framework            .ResultStateException                           ),
                typeof( NUnit.Framework            .AssertionException                             ),
                typeof( NUnit.Framework            .MultipleAssertException                        ),
                typeof( NUnit.Framework            .InconclusiveException                          ),
                typeof( NUnit.Framework            .IgnoreException                                ),
                typeof( NUnit.Framework            .SuccessException                               )
            ),
            new Namespace(
                "NUnit.Constraints",
                // ConstraintBuilder
                typeof( NUnit.Framework.Constraints.ConstraintBuilder                              ),
                typeof( NUnit.Framework.Constraints.ConstraintBuilder.ConstraintStack              ),

                // ConstraintResolver
                typeof( NUnit.Framework.Constraints.IResolveConstraint                             ),
                typeof( NUnit.Framework.Constraints.ReusableConstraint                             ),

                // Constraint
                typeof( NUnit.Framework.Constraints.IConstraint                                    ),
                typeof( NUnit.Framework.Constraints.Constraint                                     ),
                typeof( NUnit.Framework.Constraints.NullConstraint                                 ),
                typeof( NUnit.Framework.Constraints.FalseConstraint                                ),
                typeof( NUnit.Framework.Constraints.TrueConstraint                                 ),
                typeof( NUnit.Framework.Constraints.NaNConstraint                                  ),
                typeof( NUnit.Framework.Constraints.EqualConstraint                                ),
                typeof( NUnit.Framework.Constraints.SameAsConstraint                               ),
                typeof( NUnit.Framework.Constraints.RangeConstraint                                ),
                typeof( NUnit.Framework.Constraints.AnyOfConstraint                                ),
                typeof( NUnit.Framework.Constraints.ExactCountConstraint                           ),
                typeof( NUnit.Framework.Constraints.EmptyConstraint                                ),
                typeof( NUnit.Framework.Constraints.ContainsConstraint                             ),
                typeof( NUnit.Framework.Constraints.AttributeExistsConstraint                      ),
                typeof( NUnit.Framework.Constraints.PropertyExistsConstraint                       ),
                typeof( NUnit.Framework.Constraints.BinarySerializableConstraint                   ),
                typeof( NUnit.Framework.Constraints.XmlSerializableConstraint                      ),
                typeof( NUnit.Framework.Constraints.EmptyDirectoryConstraint                       ),
                typeof( NUnit.Framework.Constraints.FileOrDirectoryExistsConstraint                ),
                typeof( NUnit.Framework.Constraints.PredicateConstraint<>                          ),
                typeof( NUnit.Framework.Constraints.ThrowsExceptionConstraint                      ),
                typeof( NUnit.Framework.Constraints.ThrowsNothingConstraint                        ),
                // Constraint/Prefix
                typeof( NUnit.Framework.Constraints.PrefixConstraint                               ),
                typeof( NUnit.Framework.Constraints.NotConstraint                                  ),
                typeof( NUnit.Framework.Constraints.AttributeConstraint                            ),
                typeof( NUnit.Framework.Constraints.PropertyConstraint                             ),
                typeof( NUnit.Framework.Constraints.NoItemConstraint                               ),
                typeof( NUnit.Framework.Constraints.SomeItemsConstraint                            ),
                typeof( NUnit.Framework.Constraints.AllItemsConstraint                             ),
                typeof( NUnit.Framework.Constraints.ThrowsConstraint                               ),
                typeof( NUnit.Framework.Constraints.DelayedConstraint                              ),
                typeof( NUnit.Framework.Constraints.DelayedConstraint.WithRawDelayInterval         ),
                typeof( NUnit.Framework.Constraints.DelayedConstraint.WithDimensionedDelayInterval ),
                typeof( NUnit.Framework.Constraints.DelayedConstraint.WithRawPollingInterval       ),
                typeof( NUnit.Framework.Constraints.Interval                                       ),
                // Constraint/Binary
                typeof( NUnit.Framework.Constraints.BinaryConstraint                               ),
                typeof( NUnit.Framework.Constraints.AndConstraint                                  ),
                typeof( NUnit.Framework.Constraints.OrConstraint                                   ),
                // Constraint/Comparison
                typeof( NUnit.Framework.Constraints.ComparisonConstraint                           ),
                typeof( NUnit.Framework.Constraints.LessThanConstraint                             ),
                typeof( NUnit.Framework.Constraints.LessThanOrEqualConstraint                      ),
                typeof( NUnit.Framework.Constraints.GreaterThanConstraint                          ),
                typeof( NUnit.Framework.Constraints.GreaterThanOrEqualConstraint                   ),
                // Constraint/Collection
                typeof( NUnit.Framework.Constraints.CollectionConstraint                           ),
                typeof( NUnit.Framework.Constraints.EmptyCollectionConstraint                      ),
                typeof( NUnit.Framework.Constraints.CollectionOrderedConstraint                    ),
                // Constraint/Collection/Items
                typeof( NUnit.Framework.Constraints.CollectionItemsEqualConstraint                 ),
                typeof( NUnit.Framework.Constraints.CollectionEquivalentConstraint                 ),
                typeof( NUnit.Framework.Constraints.CollectionSubsetConstraint                     ),
                typeof( NUnit.Framework.Constraints.CollectionSupersetConstraint                   ),
                typeof( NUnit.Framework.Constraints.CollectionContainsConstraint                   ),
                typeof( NUnit.Framework.Constraints.DictionaryContainsKeyConstraint                ),
                typeof( NUnit.Framework.Constraints.DictionaryContainsValueConstraint              ),
                typeof( NUnit.Framework.Constraints.UniqueItemsConstraint                          ),
                // Constraint/String
                typeof( NUnit.Framework.Constraints.StringConstraint                               ),
                typeof( NUnit.Framework.Constraints.EmptyStringConstraint                          ),
                typeof( NUnit.Framework.Constraints.StartsWithConstraint                           ),
                typeof( NUnit.Framework.Constraints.EndsWithConstraint                             ),
                typeof( NUnit.Framework.Constraints.SubstringConstraint                            ),
                typeof( NUnit.Framework.Constraints.RegexConstraint                                ),
                // Constraint/Path
                typeof( NUnit.Framework.Constraints.PathConstraint                                 ),
                typeof( NUnit.Framework.Constraints.SamePathConstraint                             ),
                typeof( NUnit.Framework.Constraints.SubPathConstraint                              ),
                typeof( NUnit.Framework.Constraints.SamePathOrUnderConstraint                      ),
                // Constraint/Type
                typeof( NUnit.Framework.Constraints.TypeConstraint                                 ),
                typeof( NUnit.Framework.Constraints.ExactTypeConstraint                            ),
                typeof( NUnit.Framework.Constraints.ExceptionTypeConstraint                        ),
                typeof( NUnit.Framework.Constraints.AssignableFromConstraint                       ),
                typeof( NUnit.Framework.Constraints.AssignableToConstraint                         ),
                typeof( NUnit.Framework.Constraints.InstanceOfTypeConstraint                       ),

                // ConstraintResult
                typeof( NUnit.Framework.Constraints.ConstraintResult                               ),
                typeof( NUnit.Framework.Constraints.EqualConstraintResult                          ),
                typeof( NUnit.Framework.Constraints.CollectionEquivalentConstraintResult           ),
                typeof( NUnit.Framework.Constraints.ConstraintStatus                               ),

                // ConstraintExpression
                typeof( NUnit.Framework.Constraints.ConstraintExpression                           ),
                typeof( NUnit.Framework.Constraints.ItemsConstraintExpression                      ),
                typeof( NUnit.Framework.Constraints.ResolvableConstraintExpression                 ),

                // ConstraintOperator
                typeof( NUnit.Framework.Constraints.ConstraintOperator                             ),
                // ConstraintOperator/Prefix
                typeof( NUnit.Framework.Constraints.PrefixOperator                                 ),
                typeof( NUnit.Framework.Constraints.NotOperator                                    ),
                typeof( NUnit.Framework.Constraints.WithOperator                                   ),
                // ConstraintOperator/Prefix/Collection
                typeof( NUnit.Framework.Constraints.CollectionOperator                             ),
                typeof( NUnit.Framework.Constraints.NoneOperator                                   ),
                typeof( NUnit.Framework.Constraints.SomeOperator                                   ),
                typeof( NUnit.Framework.Constraints.AllOperator                                    ),
                // ConstraintOperator/Binary
                typeof( NUnit.Framework.Constraints.BinaryOperator                                 ),
                typeof( NUnit.Framework.Constraints.AndOperator                                    ),
                typeof( NUnit.Framework.Constraints.OrOperator                                     ),
                // ConstraintOperator/SelfResolving
                typeof( NUnit.Framework.Constraints.SelfResolvingOperator                          ),
                typeof( NUnit.Framework.Constraints.AttributeOperator                              ),
                typeof( NUnit.Framework.Constraints.PropOperator                                   ),
                typeof( NUnit.Framework.Constraints.ExactCountOperator                             ),
                typeof( NUnit.Framework.Constraints.ThrowsOperator                                 )
            ),
            new Namespace(
                "NUnit.Infrastructure",
                // Adapters
                typeof( NUnit.Framework.Constraints.EqualityAdapter                                ),
                typeof( NUnit.Framework.Constraints.ComparisonAdapter                              ),
                // Comparers
                typeof( NUnit.Framework.Constraints.NUnitEqualityComparer                          ),
                typeof( NUnit.Framework.Constraints.NUnitEqualityComparer.FailurePoint             ),
                typeof( NUnit.Framework.Constraints.NUnitComparer                                  ),
                // Utils
                typeof( NUnit.Framework.Constraints.Numerics                                       ),
                typeof( NUnit.Framework.Constraints.Tolerance                                      ),
                typeof( NUnit.Framework.Constraints.Tolerance.Range                                ),
                typeof( NUnit.Framework.Constraints.ToleranceMode                                  )
            ),
        };


    }
}
