using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF9
{
    class MyCommands
    {
        public static RoutedCommand TextBold { get; set; }
        public static RoutedCommand TextItalic { get; set; }
        public static RoutedCommand TextUnderline { get; set; }



        static MyCommands()
        {
            InputGestureCollection inputs1 = new InputGestureCollection();
            inputs1.Add(new KeyGesture(Key.B, ModifierKeys.Control, "Ctrl+B"));

            InputGestureCollection inputs2 = new InputGestureCollection();
            inputs2.Add(new KeyGesture(Key.I, ModifierKeys.Control, "Ctrl+I"));

            InputGestureCollection inputs3 = new InputGestureCollection();
            inputs3.Add(new KeyGesture(Key.U, ModifierKeys.Control, "Ctrl+U"));

            TextBold = new RoutedCommand("Bold", typeof(MyCommands), inputs1);
            TextItalic = new RoutedCommand("Italic", typeof(MyCommands), inputs2);
            TextUnderline = new RoutedCommand("Underline", typeof(MyCommands), inputs3);
        }
    }
}
