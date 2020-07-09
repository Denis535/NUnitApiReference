// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference.Renderer {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using NUnitApiReference.Assemblies;

    public static class Program {


        public static void Main(string[] args) {
            var items = NUnitAssembly.Types.Concat( NUnitAssembly_Assertion.Types ).Concat( NUnitAssembly_Infrastructure.Types );
            var path = GetPath();
            var content = Build( items );
            Save( path, content );

            Console.WriteLine( path );
            Console.WriteLine( content );
            Console.Read();
        }


        // Helpers
        private static string GetPath() {
            var dir = new DirectoryInfo( Directory.GetCurrentDirectory() ).Parent.Parent.Parent.Parent.FullName;
            return Path.Combine( dir, "Readme.md" );
        }
        private static void Save(string path, string content) {
            File.WriteAllText( path, content );
        }
        private static string Build(IEnumerable<TypeItem> items) {
            var builder = new StringBuilder();

            foreach (var item in items) {
                if (item.Header is string header) {
                    if (header.StartsWith( "# " )) {
                        var title = header.Substring( 2 );
                        var id = title.ToLowerInvariant();
                        builder.AppendLine( $"- [{title}]({id})" );
                    }
                    if (header.StartsWith( "## " )) {
                        var title = header.Substring( 3 );
                        var id = title.ToLowerInvariant();
                        builder.AppendLine( $" * [{title}]({id}-1)" );
                    }
                    if (header.StartsWith( "### " )) {
                        var title = header.Substring( 4 );
                        var id = title.ToLowerInvariant();
                        builder.AppendLine( $"  + [{title}]({id}-2)" );
                    }
                    if (header.StartsWith( "#### " )) {
                        var title = header.Substring( 5 );
                        var id = title.ToLowerInvariant();
                        builder.AppendLine( $"   + [{title}]({id}-3)" );
                    }
                }
            }
            builder.AppendLine();

            foreach (var item in items) {
                if (item.Header is string header) {
                    builder.AppendLine( header );
                } else
                if (item.Type is Type type) {
                    builder.AppendLine( $"* *{type.Namespace}*.{type.Name}" );
                }
            }
            builder.AppendLine();
            return builder.ToString();
        }


    }
}
