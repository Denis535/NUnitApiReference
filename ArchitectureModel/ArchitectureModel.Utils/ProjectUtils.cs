// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace ArchitectureModel.Utils {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text;

    public static class ProjectUtils {


        public static IEnumerable<Type> GetMissing(this Project project, Assembly assembly) {
            var total = assembly.DefinedTypes.Where( ShouldBeInProject );
            return project.GetMissing( total );
        }
        public static IEnumerable<Type> GetMissing(this Project project, params Assembly[] assemblies) {
            var total = assemblies.SelectMany( i => i.DefinedTypes ).Where( ShouldBeInProject );
            return project.GetMissing( total );
        }
        public static IEnumerable<Type> GetMissing(this Project project, IEnumerable<Type> total) {
            return total.Except( project.Flatten().OfType<Type>() );
        }


        public static IEnumerable<Type> GetExtra(this Project project, Assembly assembly) {
            var total = assembly.DefinedTypes.Where( ShouldBeInProject );
            return project.GetExtra( total );
        }
        public static IEnumerable<Type> GetExtra(this Project project, params Assembly[] assemblies) {
            var total = assemblies.SelectMany( i => i.DefinedTypes ).Where( ShouldBeInProject );
            return project.GetExtra( total );
        }
        public static IEnumerable<Type> GetExtra(this Project project, IEnumerable<Type> total) {
            return project.Flatten().OfType<Type>().Except( total );
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
