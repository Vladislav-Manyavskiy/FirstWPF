using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyFirstWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The Description of this box is: {this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckbox.IsChecked = this.AssemblyCheckbox.IsChecked = this.PlasmaCheckbox.IsChecked = this.LaserCheckbox.IsChecked =
                this.PurchasesCheckbox.IsChecked = this.LatheCheckbox.IsChecked = this.DrillCheckbox.IsChecked = this.FoldCheckbox.IsChecked =
                this.RollCheckbox.IsChecked = this.SawCheckbox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LenghtText.Text += (string)(((CheckBox)sender).Content + " ");
        }

        private void UNCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            string textbox = this.LenghtText.Text;
            string[] textboxes = textbox.Split(' ');

            for (int i = 0; i < textboxes.Length; i++)
            {
                if (textboxes[i] == " ")
                {
                    textboxes[i] = "";
                    continue;
                }
                if (WeldCheckbox.IsChecked == false && textboxes[i] == "Weld" || AssemblyCheckbox.IsChecked == false && textboxes[i] == "Assembly"
                    || PlasmaCheckbox.IsChecked == false && textboxes[i] == "Plasma" || LaserCheckbox.IsChecked == false && textboxes[i] == "Laser"
                    || PurchasesCheckbox.IsChecked == false && textboxes[i] == "Purchases" || LatheCheckbox.IsChecked == false && textboxes[i] == "Lathe"
                    || DrillCheckbox.IsChecked == false && textboxes[i] == "Drill" || FoldCheckbox.IsChecked == false && textboxes[i] == "Fold"
                    || RollCheckbox.IsChecked == false && textboxes[i] == "Roll" || SawCheckbox.IsChecked == false && textboxes[i] == "Saw")
                {
                    textboxes[i] = "";
                }

            }
            textbox = string.Join(" ", textboxes);
            this.LenghtText.Text = textbox;


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteBox == null)
                return;
            var box = (ComboBox)sender;
            var item = (ComboBoxItem)(box).SelectedValue;
            this.NoteBox.Text = (string)(item).Content;
        }

        private void SupplierName_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassName.Text = this.SupplierName.Text;
        }
    }
}
