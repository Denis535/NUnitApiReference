// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference.Renderer {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using NUnitApiReference;

    public static class Program {


        public static void Main(string[] args) {
            var path = GetPath();
            var content = Build( NUnitModule.AllItems );
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
        private static string Build(IEnumerable<Item> items) {
            var builder = new StringBuilder();

            foreach (var item in items.Where( i => i.Header != null )) {
                builder.AppendLine( GetHeader( item.Header! ) );
            }
            builder.AppendLine();

            foreach (var item in items) {
                builder.AppendLine( GetContent( item ) );
            }
            builder.AppendLine();

            return builder.ToString();
        }
        private static string GetHeader(string value) {
            if (value.StartsWith( "# " )) {
                var title = value.Substring( 2 );
                var id = title.ToLowerInvariant();
                return string.Format( "- [{0}](#{1})", title, id );
            }
            if (value.StartsWith( "## " )) {
                var title = value.Substring( 3 );
                var id = title.ToLowerInvariant();
                return string.Format( "* [{0}](#{1})", title, id );
            }
            if (value.StartsWith( "### " )) {
                var title = value.Substring( 4 );
                var id = title.ToLowerInvariant();
                return string.Format( "+ [{0}](#{1})", title, id );
            }
            if (value.StartsWith( "#### " )) {
                var title = value.Substring( 5 );
                var id = title.ToLowerInvariant();
                return string.Format( "- [{0}](#{1})", title, id );
            }
            throw new ArgumentException( "Value is invalid" );
        }
        private static string GetContent(Item value) {
            if (value.Header is string header) return header;
            if (value.Type is Type type) return $"* {type.Name}";
            throw new ArgumentException( "Value is invalid" );
        }


    }
}
