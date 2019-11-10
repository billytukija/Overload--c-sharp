using System;

namespace Overload
{
    public static class DialogBox
    {
        public static void Show()
        {
            //Do something here
        }
        public static void Show(bool ok)
        { 
           //Do something here
        }

        public static void Show(string message, bool ok, bool cancel)
        {
            //Do something here
        }

        public static void Show(bool ok, bool ignore, bool cancel)
        {
            //Do something here
        }

        public static void Show(string feedback, bool submit , bool yes, bool no)
        {
            //Do something here
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DialogBox.Show();
            DialogBox.Show(true);
            DialogBox.Show(false, true, false);

            //etc..
        }
    }
}
