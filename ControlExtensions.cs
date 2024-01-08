namespace frickative
{
    public static class ControlExtensions
    {
        public static T? FindControl<T>(this Control control) where T : Control
        {
            if (control == null)
                return null;

            T? result = control.Controls.OfType<T>().FirstOrDefault();
            if (result is not null)
                return result;
            foreach(Control child in control.Controls)
            {
                result = FindControl<T>(child);
                if (result is not null) 
                    return result;
            }
            return null;
        }

        public static void SetAllChecked(this CheckedListBox box, bool state)
        {
            for (int i = 0; i < box.Items.Count; i++)
            {
                box.SetItemChecked(i, state);
            }
        }
    }
}
