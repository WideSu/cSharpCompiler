// similar to Roslyn
namespace basic_compiler.CodeAnalysis
{
    public enum SyntaxKind
    {
        // Tokens
        BadToken,
        EndOfFileToken,
        WhitespaceToken,
        LiteralToken,
        PlusToken,
        MinusToken,
        StarToken,
        SlashToken,
        OpenParenthesisToken,
        CloseParenthesisToken,
        //expressions
        BinaryExpression,
        ParenthesizedExpression,
        LiteralExpression
    }
}