// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ProjectArchitecture.Model {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text;

    public static class ProjectExtensions {


        public static void Compare(this Project project, Assembly assembly, out IList<Type> common, out IList<Type> missing, out IList<Type> extra) {
            var actual = project.Flatten<TypeItem>().Select( i => i.Type );
            var expected = assembly.DefinedTypes.Where( ShouldBeInProject );
            Compare( actual, expected, out common, out missing, out extra );
        }
        public static void Compare(this Project project, Assembly[] assemblies, out IList<Type> common, out IList<Type> missing, out IList<Type> extra) {
            var actual = project.Flatten<TypeItem>().Select( i => i.Type );
            var expected = assemblies.SelectMany( i => i.DefinedTypes ).Where( ShouldBeInProject );
            Compare( actual, expected, out common, out missing, out extra );
        }
        public static void Compare(this Project project, IEnumerable<Type> types, out IList<Type> common, out IList<Type> missing, out IList<Type> extra) {
            var actual = project.Flatten<TypeItem>().Select( i => i.Type );
            Compare( actual, types, out common, out missing, out extra );
        }


        // Helpers/Linq
        private static void Compare<T>(IEnumerable<T> actual, IEnumerable<T> expected, out IList<T> common, out IList<T> missing, out IList<T> extra) {
            common = new List<T>();
            missing = new List<T>();
            extra = new List<T>();
            var expected_ = new LinkedList<T>( expected );
            foreach (var item in actual) {
                if (expected_.Remove( item )) {
                    common.Add( item );
                } else {
                    extra.Add( item );
                }
            }
            foreach (var item in expected_) {
                missing.Add( item );
            }
        }
        // Helpers/Type
        private static bool ShouldBeInProject(this Type type) {
            return !type.IsObsolete() && !type.IsCompilerGenerated() && !type.IsNestedPrivate;
        }
        private static bool IsObsolete(this Type? type) {
            while (type != null) {
                if (type.IsDefined( typeof( ObsoleteAttribute ) )) return true;
                type = type.DeclaringType;
            }
            return false;
        }
        private static bool IsCompilerGenerated(this Type? type) {
            while (type != null) {
                if (type.IsDefined( typeof( CompilerGeneratedAttribute ) )) return true;
                type = type.DeclaringType;
            }
            return false;
        }


    }
}
