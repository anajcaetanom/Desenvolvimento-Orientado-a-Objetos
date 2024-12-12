namespace interpreter;

public class SubtractExpression : IExpression
{
    private readonly IExpression _rightExpression;
    private readonly IExpression _leftExpression;
    
    public SubtractExpression(IExpression leftExpression, IExpression rightExpression)
    {
        _leftExpression = leftExpression;
        _rightExpression = rightExpression;
    }

    public int Interpret()
    {
        return _leftExpression.Interpret() - _rightExpression.Interpret();
    }
}