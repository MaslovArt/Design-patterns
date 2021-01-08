namespace Interpreter.Interpreters
{
    public abstract class Expression
    {
        public void Interprete(Context context)
        {
            if (string.IsNullOrEmpty(context.Input)) return;

            if (context.Input.StartsWith(Nine))
            {
                context.Output += 9 * Multiplier;
                context.Input = context.Input.Substring(2);
            }

            if (context.Input.StartsWith(Five))
            {
                context.Output += 5 * Multiplier;
                context.Input = context.Input.Substring(1);
            }

            if (context.Input.StartsWith(Four))
            {
                context.Output += 4 * Multiplier;
                context.Input = context.Input.Substring(2);
            }

            while (context.Input.StartsWith(One)) {
                context.Output += 1 * Multiplier;
                context.Input = context.Input.Substring(1);
            }
        }

        public abstract string One { get; }
        public abstract string Four { get; }
        public abstract string Five { get; }
        public abstract string Nine { get; }
        public abstract int Multiplier { get; }
    }
}
