using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Zespolona
    {
        double[] tablica = new double[2];

        public Zespolona()
        {
            tablica[0] = 0;
            tablica[1] = 0;
        }

        public Zespolona(double a, double b)
        {
            tablica[0] = a;
            tablica[1] = b;
        }

        public double this[int nr]
        {
            get { return tablica[nr % 2]; }
            set { tablica[nr % 2] = value; }
        }

        public double this[char symbol]
        {
            get {
                if (symbol.Equals('r'))
                {
                    return tablica[0];
                }
                else if (symbol.Equals('u'))
                {
                    return tablica[1];
                }
                return 0;
            }
            set {
                if (symbol.Equals('r'))
                {
                    tablica[0] = value;
                }
                else if (symbol.Equals('u'))
                {
                    tablica[1] = value;
                }
            }
        }

        public static Zespolona operator +(Zespolona z1, Zespolona z2)
        {
            Zespolona suma = new Zespolona();
            suma.tablica[0] = z1.tablica[0] + z2.tablica[0];
            suma.tablica[1] = z1.tablica[1] + z2.tablica[1];
            return suma;
        }

        public static Zespolona operator -(Zespolona z1, Zespolona z2)
        {
            Zespolona roznica = new Zespolona();
            roznica.tablica[0] = z1.tablica[0] - z2.tablica[0];
            roznica.tablica[1] = z1.tablica[1] - z2.tablica[1];
            return roznica;
        }

        public static Zespolona operator *(Zespolona z1, Zespolona z2)
        {
            Zespolona mnozenie = new Zespolona();
            mnozenie.tablica[0] = z1.tablica[0] * z2.tablica[0];
            mnozenie.tablica[1] = (z1.tablica[0] * z2.tablica[1]) + (z1.tablica[1] * z2.tablica[0]);
            double rto2 = -(z1.tablica[1] * z2.tablica[1]);//i^2
            mnozenie.tablica[0] = mnozenie.tablica[0] + rto2;
            return mnozenie;
        }

        public static Zespolona operator /(Zespolona z1, Zespolona z2)
        {
            Zespolona dzelenie = new Zespolona();
            double dz = z2[0] * z2[0] + -(z2[1] * (-z2[1]));

            dzelenie.tablica[0] = z1.tablica[0] * z2.tablica[0];
            dzelenie.tablica[1] = (z1.tablica[0] * z2.tablica[1]) + (z1.tablica[1] * z2.tablica[0]);

            double rto2 = -(z1.tablica[1] * z2.tablica[1]);//i^2
            dzelenie.tablica[0] = (dzelenie.tablica[0] + rto2) / dz;
            dzelenie.tablica[1] /= dz;
            return dzelenie;
        }

        public static bool operator !=(Zespolona z1, Zespolona z2)
        {
            if (z1[0] != z2[0] || z1[1] != z2[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Zespolona z1, Zespolona z2)
        {
            if (z1[0] == z2[0] && z1[1] == z2[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Zespolona z1, Zespolona z2)
        {
            double modul1 = Math.Sqrt(Math.Pow(z1[0], 2) + Math.Pow(z1[1], 2));
            double modul2 = Math.Sqrt(Math.Pow(z2[0], 2) + Math.Pow(z2[1], 2));
            if (modul1 > modul2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Zespolona z1, Zespolona z2)
        {
            double modul1 = Math.Sqrt(Math.Pow(z1[0], 2) + Math.Pow(z1[1], 2));
            double modul2 = Math.Sqrt(Math.Pow(z2[0], 2) + Math.Pow(z2[1], 2));
            if (modul1 < modul2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Zespolona))
            {
                return false;
            }
            Zespolona z = (Zespolona)obj;
            return tablica[0] == z[0] & tablica[1] == z[1];
        }

        public override int GetHashCode()
        {
            return Tuple.Create(tablica[0], tablica[1]).GetHashCode();
        }

        public static implicit operator double(Zespolona z)
        {
            return z[0] + z[1] / 100.0;
        }

        public static implicit operator Zespolona(double liczba)
        {
            return (new Zespolona(((double)((int)liczba)), (liczba - ((double)((int)liczba))) * 100));
        }
    }
}
