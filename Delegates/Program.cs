namespace Delegates
{
    internal class Program
    {
        //Declartion
        public delegate void Notify(String message);

        static void Main(string[] args)
        {
            //Instantiation
            //Notify notifyDelegate = ShowMessage;

            //Invocation
            //notifyDelegate("Thomas Delegates");

            Simple_Delegate_Example simple_Delegate_Example = new Simple_Delegate_Example();
            simple_Delegate_Example.example();

        }

        static void ShowMessage(String message)
        {
            Console.WriteLine(message);
        }

    }
}
