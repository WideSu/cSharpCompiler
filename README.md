# Compiler
An ongoing Compiler project built using C#.

# Features
Can parse binary expressions with parenthesis, return the result with error message and parser tree.

You can use `#showTree` to close or open printing parser tree.
And use `#cls` to clear the screem.
```
1 + 3 * 5
```
16
```
(1 + 3) * 5
```
20
```
1 + 3 3
```
Result
```
└──BinaryExpression
    ├──NumberExpression
    |   └──NumberToken 1
    ├──PlusToken
    └──NumberExpression
        └──NumberToken 3
ERROR: Unexpected token <NumberToken>, expected <EndOfFileToken>
```
