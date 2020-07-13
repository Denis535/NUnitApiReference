// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace NUnitApiReference.Renderer {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

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
        private static string Build(IEnumerable<Item> items) {
            var builder = new StringBuilder();
            foreach (var (item, id) in items.OfType<HeaderItem>().WithId()) {
                builder.AppendLine( item.GetHeader( id ) );
            }
            builder.AppendLine();
            foreach (var item in items) {
                builder.AppendLine( item.GetContent() );
            }
            return builder.ToString();
        }
        private static string GetHeader(this HeaderItem value, int number) {
            return value.Level switch
            {
                1 => string.Format( "- [{0}](#{1}-{2})", value.Value, value.Value.ToLowerInvariant(), number ),
                2 => string.Format( " * [{0}](#{1}-{2})", value.Value, value.Value.ToLowerInvariant(), number ),
                3 => string.Format( "  + [{0}](#{1}-{2})", value.Value, value.Value.ToLowerInvariant(), number ),
                4 => string.Format( "   - [{0}](#{1}-{2})", value.Value, value.Value.ToLowerInvariant(), number ),
                _ => throw new ArgumentException( "Value is invalid" ),
            };
        }
        private static string GetContent(this Item value) {
            return value switch
            {
                HeaderItem header when header.Level == 1 => "# " + header.Value,
                HeaderItem header when header.Level == 2 => "## " + header.Value,
                HeaderItem header when header.Level == 3 => "### " + header.Value,
                HeaderItem header when header.Level == 4 => "#### " + header.Value,
                GroupItem group => "* ***" + group.Value + "***",
                TypeItem type => "* " + type.Value.Name,
                _ => throw new ArgumentException( "Value is invalid" ),
            };
        }
        // Helpers/File
        private static string GetPath() {
            var dir = new DirectoryInfo( Directory.GetCurrentDirectory() ).Parent.Parent.Parent.Parent.FullName;
            return Path.Combine( dir, "Readme.md" );
        }
        private static void Save(string path, string content) {
            File.WriteAllText( path, content );
        }
        // Helpers/Linq
        private static IEnumerable<(T, int)> WithId<T>(this IEnumerable<T> source) {
            foreach (var (item, prevs) in source.WithPrevious()) {
                var id = prevs.Count( i => i.Equals( item ) );
                yield return (item, id);
            }
        }
        private static IEnumerable<(T, IEnumerable<T>)> WithPrevious<T>(this IEnumerable<T> source) {
            var previous = new List<T>();
            foreach (var item in source) {
                yield return (item, previous);
                previous.Add( item );
            }
        }


    }
}
