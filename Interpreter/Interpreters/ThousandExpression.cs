namespace Interpreter.Interpreters
{
    public class ThousandExpression : Expression
    {
        public override string One => "M";

        public override string Four => "null";

        public override string Five => "null";

        public override string Nine => "null";

        public override int Multiplier => 1000;
    }
}
