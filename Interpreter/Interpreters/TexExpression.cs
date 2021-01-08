namespace Interpreter.Interpreters
{
    public class TexExpression : Expression
    {
        public override string One => "X";

        public override string Four => "XL";

        public override string Five => "L";

        public override string Nine => "XC";

        public override int Multiplier => 10;
    }
}
