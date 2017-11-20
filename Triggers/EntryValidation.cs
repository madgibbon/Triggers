using System;
using Xamarin.Forms;

namespace Triggers
{
    public class EntryValidation : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            int parsed;
            bool valid = int.TryParse(sender.Text, out parsed);

            if(!valid)
            {
                sender.TextColor = Color.Red;
            }
            else
            {
                sender.TextColor = Color.Blue;
            }
        }
    }
}
