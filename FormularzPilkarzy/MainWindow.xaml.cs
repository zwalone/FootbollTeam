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

namespace FormularzPilkarzy
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Setup();
        }

        public void Setup()
        {
            for (int i = 50; i < 101; i++)
            {
                age_cb.Items.Add(i);
            }
            age_cb.SelectedItem = 80;
        }

        public void ReturnDefault()
        {
            name_tbx.Foreground = surname_tbx.Foreground = Brushes.Gray;
            name_tbx.Text = "Podaj imię";
            surname_tbx.Text = "Podaj nazwisko";
            age_cb.SelectedItem = 80;
            weight_sl.Value = 50;
        }
        #region TextBoxes
        //Name TextBox
        private void Name_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            if (name_tbx.Text == "Podaj imię")
            {
                name_tbx.BorderBrush = SystemColors.ControlDarkBrush;
                name_tbx.Text = " ";
                name_tbx.Foreground = Brushes.Black;

            }
        }
        //To Delete
        private void Name_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Name_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            if (name_tbx.Text.Trim().Length == 0 )
            {
                name_tbx.Foreground = Brushes.Gray;
                name_tbx.Text = "Podaj imię";
            }
        }
        //Surname
        private void Surname_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            if (surname_tbx.Text == "Podaj nazwisko")
            {
                surname_tbx.BorderBrush = SystemColors.ControlDarkBrush;
                surname_tbx.Text = " ";
                surname_tbx.Foreground = Brushes.Black;

            }
        }

        private void Surname_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            if (surname_tbx.Text.Trim().Length == 0)
            {
                surname_tbx.Foreground = Brushes.Gray;
                surname_tbx.Text = "Podaj nazwisko";
            }
        }


        #endregion

        #region Buttons
        //Add
        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            if (name_tbx.Text != "Podaj imię" && surname_tbx.Text != "Podaj nazwisko")
            {
                Player player = new Player(name_tbx.Text, surname_tbx.Text, (float)weight_sl.Value, (int)age_cb.SelectedItem);

                content_lbx.Items.Add(player);

                ReturnDefault();
            }
            if (name_tbx.Text == "Podaj imię")
            {
                name_tbx.BorderBrush = Brushes.Red;
            }
            if (surname_tbx.Text == "Podaj nazwisko")
            {
                surname_tbx.BorderBrush = Brushes.Red;
            }

        }
        //Modyfi
        private void Modify_btn_Click(object sender, RoutedEventArgs e)
        {

            if (content_lbx.SelectedItems.Count != 0)
            {
                name_tbx.Foreground = surname_tbx.Foreground = Brushes.Black;
                name_tbx.BorderBrush = surname_tbx.BorderBrush = SystemColors.ControlDarkBrush;
                Player player = content_lbx.SelectedItem as Player;
                content_lbx.Items.RemoveAt(content_lbx.SelectedIndex);

                name_tbx.Text = player.Name;
                surname_tbx.Text = player.Surrname;
                weight_sl.Value = player.Weight;
                age_cb.SelectedItem = player.Age;
            }
        }
        //Remove
        private void Remove_btn_Click(object sender, RoutedEventArgs e)
        {
            if (content_lbx.SelectedItems.Count !=0)
            {
                content_lbx.Items.RemoveAt(content_lbx.SelectedIndex);
            }
        }
        #endregion
    }
}
