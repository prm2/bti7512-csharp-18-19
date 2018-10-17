using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnChange
{
    // If your event needs specific parameters, create a subclass of
    // 'EventArgs'
    public class NameChangedEventArgs : EventArgs
    {
        public string NewName { get; set; }
    }

    public class Person
    {
        string name;

        // Declare the event using the generic delegate 'EventHandler'
        public event EventHandler<NameChangedEventArgs> NameChanged;

        // Events are never called directly in application logic. Place
        // the call in a separate method. Always declared as 
        // 'protected virtual'. And always named 'On...' and the name
        // of the event.
        protected virtual void OnNameChanged(NameChangedEventArgs args)
        {
            NameChanged?.Invoke(this, args);
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    // Raise the event by calling the specific method
                    OnNameChanged(new NameChangedEventArgs { NewName = value });
                }
            }
        }


    }
}
