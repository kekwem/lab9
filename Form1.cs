using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumaButton_Click(object sender, EventArgs e)
        {
            Zespolona pierwsza = new Zespolona(Convert.ToDouble(z1textBox.Text),
                Convert.ToDouble(z2textBox.Text));
            Zespolona druga = new Zespolona(Convert.ToDouble(z3textBox.Text),
                Convert.ToDouble(z4textBox.Text));
            Zespolona result = new Zespolona();
            result = pierwsza + druga;
            if (result['u'] < 0)
            {
                z5textBox.Text = $"{result['r']}{result['u']}i";
            }
            else
            {
                z5textBox.Text = $"{result['r']}+{result['u']}i";
            }
        }

        private void roznicaButton_Click(object sender, EventArgs e)
        {
            Zespolona pierwsza = new Zespolona(Convert.ToDouble(z1textBox.Text),
                Convert.ToDouble(z2textBox.Text));
            Zespolona druga = new Zespolona(Convert.ToDouble(z3textBox.Text),
                Convert.ToDouble(z4textBox.Text));
            Zespolona result = new Zespolona();
            result = pierwsza - druga;
            if (result['u'] < 0)
            {
                z5textBox.Text = $"{result['r']}{result['u']}i";
            }
            else
            {
                z5textBox.Text = $"{result['r']}+{result['u']}i";
            }
        }

        private void mnozenieButton_Click(object sender, EventArgs e)
        {
            Zespolona pierwsza = new Zespolona(Convert.ToDouble(z1textBox.Text),
                Convert.ToDouble(z2textBox.Text));
            Zespolona druga = new Zespolona(Convert.ToDouble(z3textBox.Text),
                Convert.ToDouble(z4textBox.Text));
            Zespolona result = new Zespolona();
            result = pierwsza * druga;
            if (result['u'] < 0)
            {
                z5textBox.Text = $"{result['r']}{result['u']}i";
            }
            else
            {
                z5textBox.Text = $"{result['r']}+{result['u']}i";
            }
        }

        private void dzielenieButton_Click(object sender, EventArgs e)
        {
            Zespolona pierwsza = new Zespolona(Convert.ToDouble(z1textBox.Text),
                Convert.ToDouble(z2textBox.Text));
            Zespolona druga = new Zespolona(Convert.ToDouble(z3textBox.Text),
                Convert.ToDouble(z4textBox.Text));
            Zespolona result = new Zespolona();
            result = pierwsza / druga;
            if (result['u'] < 0)
            {
                z5textBox.Text = $"{result['r']:0.000}{result['u']:0.000}i";
            }
            else
            {
                z5textBox.Text = $"{result['r']:0.000}+{result['u']:0.000}i";
            }
        }

        private void roznaButton_Click(object sender, EventArgs e)
        {
            Zespolona pierwsza = new Zespolona(Convert.ToDouble(z1textBox.Text),
                Convert.ToDouble(z2textBox.Text));
            Zespolona druga = new Zespolona(Convert.ToDouble(z3textBox.Text),
                Convert.ToDouble(z4textBox.Text));
            if(pierwsza != druga)
            {
                z5textBox.Text = $"True";
            }
            else
            {
                z5textBox.Text = $"False";
            }
        }

        private void podobnaButton_Click(object sender, EventArgs e)
        {
            Zespolona pierwsza = new Zespolona(Convert.ToDouble(z1textBox.Text),
                Convert.ToDouble(z2textBox.Text));
            Zespolona druga = new Zespolona(Convert.ToDouble(z3textBox.Text),
                Convert.ToDouble(z4textBox.Text));
            if (pierwsza == druga)
            {
                z5textBox.Text = $"True";
            }
            else
            {
                z5textBox.Text = $"False";
            }
        }

        private void mniejszaButton_Click(object sender, EventArgs e)
        {
            Zespolona pierwsza = new Zespolona(Convert.ToDouble(z1textBox.Text),
                Convert.ToDouble(z2textBox.Text));
            Zespolona druga = new Zespolona(Convert.ToDouble(z3textBox.Text),
                Convert.ToDouble(z4textBox.Text));
            if (pierwsza < druga)
            {
                z5textBox.Text = $"True";
            }
            else
            {
                z5textBox.Text = $"False";
            }
        }

        private void wiekszaButton_Click(object sender, EventArgs e)
        {
            Zespolona pierwsza = new Zespolona(Convert.ToDouble(z1textBox.Text),
                Convert.ToDouble(z2textBox.Text));
            Zespolona druga = new Zespolona(Convert.ToDouble(z3textBox.Text),
                Convert.ToDouble(z4textBox.Text));
            if (pierwsza > druga)
            {
                z5textBox.Text = $"True";
            }
            else
            {
                z5textBox.Text = $"False";
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            Zespolona pierwsza = new Zespolona(Convert.ToDouble(z1textBox.Text),
                Convert.ToDouble(z2textBox.Text));
            Zespolona druga = new Zespolona(Convert.ToDouble(z3textBox.Text),
                Convert.ToDouble(z4textBox.Text));
            if (pierwsza.Equals(druga))
            {
                z5textBox.Text = $"True";
            }
            else
            {
                z5textBox.Text = $"False";
            }
        }

        private void getHashCodeButton_Click(object sender, EventArgs e)
        {
            Zespolona pierwsza = new Zespolona(Convert.ToDouble(z1textBox.Text),
                Convert.ToDouble(z2textBox.Text));
            Zespolona druga = new Zespolona(Convert.ToDouble(z3textBox.Text),
                Convert.ToDouble(z4textBox.Text));
            int a = pierwsza.GetHashCode();
            int b = druga.GetHashCode();
            if (a == b)
            {
                z5textBox.Text = $"{a}";
            }
            else
            {
                z5textBox.Text = $"{a} i {b}";
            }
        }

        private void toDuobleButton_Click(object sender, EventArgs e)
        {
            Zespolona pierwsza = new Zespolona(Convert.ToDouble(z1textBox.Text),
                Convert.ToDouble(z2textBox.Text));
            double result = pierwsza;
            z5textBox.Text = $"{result}";
        }

        private void toZespolonaButton_Click(object sender, EventArgs e)
        {
            double liczba = Convert.ToDouble(z5textBox.Text);
            Zespolona zespolona = new Zespolona(Math.Round(liczba), Math.Round((liczba - Math.Round(liczba)) * 100));
            z1textBox.Text = $"{zespolona[0]}";
            z2textBox.Text = $"{zespolona[1]}";
        }
    }
}
