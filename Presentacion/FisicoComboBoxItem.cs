namespace Presentacion
{
    internal class FisicoComboBoxItem
    {
        public required string Text { get; set; }
        public bool Value { get; set; }

        public static FisicoComboBoxItem[] ObtenerFisicoComboBoxItems()
        {
            return new[]
            {
                new FisicoComboBoxItem { Text = "Sí", Value = true },
                new FisicoComboBoxItem { Text = "No", Value = false }
            };
        }
    }
}
