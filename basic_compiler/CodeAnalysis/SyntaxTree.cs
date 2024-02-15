// similar to Roslyn
namespace basic_compiler.CodeAnalysis
{
    sealed class SyntaxTree
    {
        public SyntaxTree(IEnumerable<string> diagnostics,ExpressionSyntax root, SyntaxToken endOfFileToken)
        {
            Diagnostics = diagnostics.ToArray();
            Root = root;
            EndOfFileToken = endOfFileToken;
        }
        public IReadOnlyList<string> Diagnostics {get;}
        public ExpressionSyntax Root {get;}
        public SyntaxToken EndOfFileToken {get;}
        public static SyntaxTree Parse(string text)
        {
            var Parser = new Parser(text);
            return Parser.Parse();
        }
    }
}