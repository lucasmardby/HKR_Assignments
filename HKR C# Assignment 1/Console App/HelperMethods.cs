namespace Console_App
{
    public static class HelperMethods
    {
        public static void ConfirmationButton()
        {
            /*Used in all the "Task" Methods to have the user 
             confirm before moving on to the next class method.*/

            Console.WriteLine();
            Console.WriteLine("Press any button to continue.");
            Console.ReadLine();
        }
    }
}
