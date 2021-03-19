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

namespace Learning_About_Shapes
{
    public partial class MainWindow : Window
    {
        Parallelogram generalPara = new Parallelogram();
        Triangle generalTri = new Triangle();
        Ellipse generalElli = new Ellipse();
        RegularPolygon generalRPoly = new RegularPolygon();
        Trapezoid generalTrap = new Trapezoid();

        string current_page = "";
        public MainWindow()
        {
            InitializeComponent();
            current_page = "Home";
            Home_Page.Visibility = Visibility.Visible;
            Inf_Page.Visibility = Visibility.Hidden;
            l5.Visibility = Visibility.Hidden;
            tbox5.Visibility = Visibility.Hidden; 
        }

        private bool checkInput(string x) //checks if the input is a number
        {
            try
            {
                Convert.ToDouble(x);
                return false;
            }
            catch
            {
                MessageBox.Show("You have an invalid input\n");
                return true;
            }
        }

        private bool checkInt(string x) //used to make sure a number entered is both an int and a number
        {
            try
            {
                if (Convert.ToInt32(x) == Convert.ToDouble(x))
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("You have an invalid input\n");
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("You have an invalid input\n");
                return true;
            }
        }

        private void Par_Button_Click(object sender, RoutedEventArgs e)
        {
            current_page = "Para";
            Home_Page.Visibility = Visibility.Hidden;
            Inf_Page.Visibility = Visibility.Visible;

            Info_Block.Text = generalPara.GenInfo;

            Image1.Source = new BitmapImage(new Uri("Para.png", UriKind.Relative));

            l1.Text = "a";
            tbox1.Text = "Enter the side.";

            l2.Text = "h";
            tbox2.Text = "Enter height.";
            l2.Visibility = Visibility.Visible;
            tbox2.Visibility = Visibility.Visible;

            l3.Text = "b";
            tbox3.Text = "Enter base.";
            l3.Visibility = Visibility.Visible;
            tbox3.Visibility = Visibility.Visible;

            l4.Visibility = Visibility.Hidden;
            tbox4.Visibility = Visibility.Hidden;

            db1.Text = "The perimeter is: ";
            db2.Text = "The area is: ";

            b1_Button.Content = "Square";
            b2_Button.Content = "Rectangle";

            b1_Button.Visibility = Visibility.Visible;
            b2_Button.Visibility = Visibility.Visible;

        }

        private void GH_Button_Click(object sender, RoutedEventArgs e)
        {
            Home_Page.Visibility = Visibility.Visible;
            Inf_Page.Visibility = Visibility.Hidden;
            l5.Visibility = Visibility.Hidden;
            tbox5.Visibility = Visibility.Hidden;

        }

        private void Tri_Button_Click(object sender, RoutedEventArgs e)
        {
            current_page = "Gtri";
            Home_Page.Visibility = Visibility.Hidden;
            Inf_Page.Visibility = Visibility.Visible;

            Info_Block.Text = generalTri.GenInfo;

            Image1.Source = new BitmapImage(new Uri("Gtri.png", UriKind.Relative));

            l1.Text = "a";
            tbox1.Text = "Enter the side.";

            l2.Text = "b";
            tbox2.Text = "Enter side.";
            l2.Visibility = Visibility.Visible;
            tbox2.Visibility = Visibility.Visible;

            l3.Text = "c";
            tbox3.Text = "Enter side.";
            l3.Visibility = Visibility.Visible;
            tbox3.Visibility = Visibility.Visible;

            l4.Text = "h";
            tbox4.Text = "Enter height.";
            l4.Visibility = Visibility.Visible;
            tbox4.Visibility = Visibility.Visible;

            db1.Text = "The perimeter is: ";
            db2.Text = "The area is: ";

            b1_Button.Content = "Right Tri.";

            b1_Button.Visibility = Visibility.Visible;
            b2_Button.Visibility = Visibility.Hidden;
        }

        private void Eli_Button_Click(object sender, RoutedEventArgs e)
        {
            current_page = "Elli";
            Home_Page.Visibility = Visibility.Hidden;
            Inf_Page.Visibility = Visibility.Visible;

            Info_Block.Text = generalElli.GenInfo;

            Image1.Source = new BitmapImage(new Uri("Elli.png", UriKind.Relative));

            l1.Text = "a";
            tbox1.Text = "Enter major axis.";

            l2.Text = "b";
            tbox2.Text = "Enter minor axis.";
            l2.Visibility = Visibility.Visible;
            tbox2.Visibility = Visibility.Visible;

            l3.Visibility = Visibility.Hidden;
            tbox3.Visibility = Visibility.Hidden;

            l4.Visibility = Visibility.Hidden;
            tbox4.Visibility = Visibility.Hidden;

            db1.Text = "The circumference is: ";
            db2.Text = "The area is: ";

            b1_Button.Content = "Circle";

            b1_Button.Visibility = Visibility.Visible;
            b2_Button.Visibility = Visibility.Hidden;
        }

        private void GenData_button_Click(object sender, RoutedEventArgs e)
        {
            if (current_page == "Para" || current_page == "Squa" || current_page == "Rect")
            {

                if (current_page == "Squa")
                {
                    if (checkInput(tbox1.Text))
                    {
                        return;
                    }
                    generalPara.setShape(Convert.ToDouble(tbox1.Text), Convert.ToDouble(tbox1.Text), Convert.ToDouble(tbox1.Text));
                }

                else if (current_page == "Rect")
                {
                    if (checkInput(tbox1.Text) || checkInput(tbox1.Text))
                    {
                        return;
                    }
                    generalPara.setShape(Convert.ToDouble(tbox1.Text), Convert.ToDouble(tbox2.Text), Convert.ToDouble(tbox1.Text));
                }

                else
                {
                    if (checkInput(tbox1.Text) || checkInput(tbox2.Text) || checkInput(tbox3.Text))
                    {
                        return;
                    }
                    generalPara.setShape(Convert.ToDouble(tbox1.Text), Convert.ToDouble(tbox2.Text), Convert.ToDouble(tbox3.Text));
                }

                db1.Text = "The perimeter is: " + generalPara.Perimeter;
                db2.Text = "The area is: " + generalPara.Area;
            }

            if (current_page == "Gtri" || current_page == "Rtri")
            {
                if (current_page == "Rtri")
                {
                    if (checkInput(tbox1.Text) || checkInput(tbox2.Text) || checkInput(tbox3.Text))
                    {
                        return;
                    }

                    if ((Convert.ToDouble(tbox1.Text) * Convert.ToDouble(tbox1.Text) + Convert.ToDouble(tbox2.Text) * Convert.ToDouble(tbox2.Text)) != Convert.ToDouble(tbox3.Text) * Convert.ToDouble(tbox3.Text))
                    {
                        MessageBox.Show("Your triangle does not follow pythagorean theorem, please correct inputs.\n");
                        return;
                    }
                    generalTri.setShape(Convert.ToDouble(tbox1.Text), Convert.ToDouble(tbox2.Text), Convert.ToDouble(tbox3.Text));
                }

                else
                {
                    if (checkInput(tbox1.Text) || checkInput(tbox2.Text) || checkInput(tbox3.Text) || checkInput(tbox4.Text))
                    {
                        return;
                    }

                    if (Convert.ToDouble(tbox3.Text) <= Convert.ToDouble(tbox4.Text)) //simplier test, is not perfect since it does not check the base, but should work in a fair amount of cases.
                    {
                        MessageBox.Show("Your triangle does not follow pythagorean theorem, please correct inputs.\n");
                        return;
                    }

                    generalTri.setShape(Convert.ToDouble(tbox1.Text), Convert.ToDouble(tbox2.Text), Convert.ToDouble(tbox3.Text), Convert.ToDouble(tbox4.Text));
                }

                db1.Text = "The perimeter is: " + generalTri.Perimeter;
                db2.Text = "The area is: " + generalTri.Area;
            }

            if (current_page == "Elli" || current_page == "Circ")
            {
                if (current_page == "Circ")
                {
                    if (checkInput(tbox1.Text))
                    {
                        return;
                    }

                    generalElli.setShape(Convert.ToDouble(tbox1.Text), Convert.ToDouble(tbox1.Text));
                }

                else
                {
                    if (checkInput(tbox1.Text) || checkInput(tbox2.Text))
                    {
                        return;
                    }

                    generalElli.setShape(Convert.ToDouble(tbox1.Text), Convert.ToDouble(tbox2.Text));
                }

                db1.Text = "The circumference is: " + generalElli.Perimeter;
                db2.Text = "The area is: " + generalElli.Area;
            }

            if (current_page == "Poly")
            {

                if (checkInput(tbox1.Text) || checkInt(tbox2.Text))
                {
                    return;
                }

                generalRPoly.setShape(Convert.ToDouble(tbox1.Text), Convert.ToDouble(tbox2.Text));


                db1.Text = "The perimeter is: " + generalRPoly.Perimeter;
                db2.Text = "The area is: " + generalRPoly.Area;
            }

            if (current_page == "Trap")
            {

                if (checkInput(tbox1.Text) || checkInput(tbox2.Text) || checkInput(tbox3.Text) || checkInput(tbox4.Text) || checkInput(tbox5.Text))
                {
                    return;
                }

                generalTrap.setShape(Convert.ToDouble(tbox1.Text), Convert.ToDouble(tbox2.Text), Convert.ToDouble(tbox3.Text), Convert.ToDouble(tbox4.Text), Convert.ToDouble(tbox5.Text));


                db1.Text = "The perimeter is: " + generalTrap.Perimeter;
                db2.Text = "The area is: " + generalTrap.Area;
            }
        }

        private void b1_Button_Click(object sender, RoutedEventArgs e)
        {
            if (current_page == "Para")
            {
                current_page = "Squa";

                Info_Block.Text = generalPara.SquInfo;

                Image1.Source = new BitmapImage(new Uri("Squ.png", UriKind.Relative));

                l1.Text = "a";
                tbox1.Text = "Enter the side.";

                l2.Visibility = Visibility.Hidden;
                tbox2.Visibility = Visibility.Hidden;

                l3.Visibility = Visibility.Hidden;
                tbox3.Visibility = Visibility.Hidden;

                l4.Visibility = Visibility.Hidden;
                tbox4.Visibility = Visibility.Hidden;

                db1.Text = "The perimeter is: ";
                db2.Text = "The area is: ";

                b1_Button.Content = "";
                b2_Button.Content = "";

                b1_Button.Visibility = Visibility.Visible;
                b2_Button.Visibility = Visibility.Visible;
            }

            if (current_page == "Gtri")
            {
                current_page = "Rtri";

                Info_Block.Text = generalTri.RTInfo;

                Image1.Source = new BitmapImage(new Uri("Rtri.png", UriKind.Relative));

                l1.Text = "a";
                tbox1.Text = "Enter side.";
                l1.Visibility = Visibility.Visible;
                tbox2.Visibility = Visibility.Visible;

                l2.Text = "b";
                tbox2.Text = "Enter side.";
                l2.Visibility = Visibility.Visible;
                tbox2.Visibility = Visibility.Visible;

                l3.Text = "c";
                tbox3.Text = "Enter side.";
                l3.Visibility = Visibility.Visible;
                tbox3.Visibility = Visibility.Visible;

                l4.Visibility = Visibility.Hidden;
                tbox4.Visibility = Visibility.Hidden;

                db1.Text = "The perimeter is: ";
                db2.Text = "The area is: ";

                b1_Button.Visibility = Visibility.Hidden;
                b2_Button.Visibility = Visibility.Hidden;
            }

            if (current_page == "Elli")
            {
                current_page = "Circ";

                Info_Block.Text = generalElli.CInfo;

                Image1.Source = new BitmapImage(new Uri("Cir.png", UriKind.Relative));

                l1.Text = "r";
                tbox1.Text = "Enter radius.";

                l2.Visibility = Visibility.Hidden;
                tbox2.Visibility = Visibility.Hidden;

                l3.Visibility = Visibility.Hidden;
                tbox3.Visibility = Visibility.Hidden;

                l4.Visibility = Visibility.Hidden;
                tbox4.Visibility = Visibility.Hidden;

                db1.Text = "The circumference is: ";
                db2.Text = "The area is: ";

                b1_Button.Visibility = Visibility.Hidden;
                b2_Button.Visibility = Visibility.Hidden;
            }
        }

        private void b2_Button_Click(object sender, RoutedEventArgs e)
        {
            if (current_page == "Para")
            {
                current_page = "Rect";

                Info_Block.Text = generalPara.SquInfo;

                Image1.Source = new BitmapImage(new Uri("Rect.png", UriKind.Relative));

                l1.Text = "w";
                tbox1.Text = "Enter the widith.";

                l2.Text = "l";
                tbox2.Text = "Enter the length.";
                l2.Visibility = Visibility.Visible;
                tbox2.Visibility = Visibility.Visible;

                l3.Visibility = Visibility.Hidden;
                tbox3.Visibility = Visibility.Hidden;

                db1.Text = "The perimeter is: ";
                db2.Text = "The area is: ";

                b1_Button.Content = "";
                b2_Button.Content = "";

                b1_Button.Visibility = Visibility.Visible;
                b2_Button.Visibility = Visibility.Visible;
            }
        }

        private void RP_Button_Click(object sender, RoutedEventArgs e)
        {
            current_page = "Poly";
            Home_Page.Visibility = Visibility.Hidden;
            Inf_Page.Visibility = Visibility.Visible;

            Info_Block.Text = generalRPoly.GenInfo;

            Image1.Source = new BitmapImage(new Uri("Pent.png", UriKind.Relative));

            l1.Text = "s";
            tbox1.Text = "Side length.";

            l2.Text = "n";
            tbox2.Text = "Number of sides.";
            l2.Visibility = Visibility.Visible;
            tbox2.Visibility = Visibility.Visible;

            l3.Visibility = Visibility.Hidden;
            tbox3.Visibility = Visibility.Hidden;

            l4.Visibility = Visibility.Hidden;
            tbox4.Visibility = Visibility.Hidden;

            db1.Text = "The perimeter is: ";
            db2.Text = "The area is: ";

            b1_Button.Visibility = Visibility.Hidden;
            b2_Button.Visibility = Visibility.Hidden;
        }

        private void Tra_Button_Click(object sender, RoutedEventArgs e)
        {
            current_page = "Trap";
            Home_Page.Visibility = Visibility.Hidden;
            Inf_Page.Visibility = Visibility.Visible;

            Info_Block.Text = generalTrap.GenInfo;

            Image1.Source = new BitmapImage(new Uri("Trap.png", UriKind.Relative));

            l1.Text = "a";
            tbox1.Text = "Side length.";

            l2.Text = "b";
            tbox2.Text = "Side length.";
            l2.Visibility = Visibility.Visible;
            tbox2.Visibility = Visibility.Visible;

            l3.Text = "c";
            tbox3.Text = "Side length.";
            l3.Visibility = Visibility.Visible;
            tbox3.Visibility = Visibility.Visible;

            l4.Text = "d";
            tbox4.Text = "Side length.";
            l4.Visibility = Visibility.Visible;
            tbox4.Visibility = Visibility.Visible;

            l5.Text = "h";
            tbox5.Text = "Height length.";
            l5.Visibility = Visibility.Visible;
            tbox5.Visibility = Visibility.Visible;

            db1.Text = "The perimeter is: ";
            db2.Text = "The area is: ";

            b1_Button.Visibility = Visibility.Hidden;
            b2_Button.Visibility = Visibility.Hidden;
        }
    }
}
