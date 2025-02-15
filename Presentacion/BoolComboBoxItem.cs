namespace Presentacion
{
    public class BoolComboBoxItem
    {
        public required string Text { get; set; }
        public bool Value { get; set; }

        public static BoolComboBoxItem[] ObtenerItems()
        {
            return
            [
                new BoolComboBoxItem { Text = "Sí", Value = true },
                new BoolComboBoxItem { Text = "No", Value = false }
            ];
        }
    }
}
