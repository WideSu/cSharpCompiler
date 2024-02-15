// similar to Roslyn
namespace basic_compiler.CodeAnalysis
{
    abstract class SyntaxNode
    {
        public abstract SyntaxKind Kind{get;}
        public abstract IEnumerable<SyntaxNode> GetChildren();
    }
}