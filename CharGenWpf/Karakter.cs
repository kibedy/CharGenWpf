using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharGenWpf
{
    public class Karakter: INotifyPropertyChanged
    {
        string név;
        private int asz;
        public int HM_osz, KÉ, TÉ, VÉ, CÉ, KÉ_alap, TÉ_alap, VÉ_alap, CÉ_alap;
        public int KP, KP_szint, KP_ügy, KP_int;
        private int ép_alap;
        private int er;
        private int gy;
        private int ü;
        private int áK;
        private int eg;
        private int sz;
        private int @int;
        private int aE;
        private int ép;
        private int fp;
        private int fp_szint;
        private string fp_szint_kiir;
        private int fp_alap;
        private int tSz;
        private bool nagydobás;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Er
        {
            get
            {
                return er;
            }

            set
            {
                er = value;
                OnPropertyChanged("Er");
            }
        }

        public int Gy
        {
            get
            {
                return gy;
            }

            set
            {
                gy = value;
                OnPropertyChanged("Gy");                
            }
        }

        public int Ü
        {
            get
            {
                return ü;
            }

            set
            {
                ü = value;
                OnPropertyChanged("Ü");
            }
        }

        public int ÁK
        {
            get
            {
                return áK;
            }

            set
            {
                áK = value;
                fp = fp_alap + tizfeletti(ÁK) + tizfeletti(AE) + K6(TSz);
                OnPropertyChanged("ÁK");                                
            }
        }

        public int Eg
        {
            get
            {
                return eg;
            }

            set
            {
                eg = value;
                Ép = Ép_alap + tizfeletti(eg);
                OnPropertyChanged("Eg");
               
                ;
            }
        }

        public int Sz
        {
            get
            {
                return sz;
            }

            set
            {               
                sz = value;
                OnPropertyChanged("Sz");
            }
        }

        public int Int
        {
            get
            {
                return @int;
            }

            set
            {
                @int = value;
                OnPropertyChanged("Int");
            }
        }

        public int AE
        {
            get
            {
                return aE;
            }

            set
            {
                aE = value;
                fp = fp_alap + tizfeletti(ÁK) + tizfeletti(AE) + K6(TSz);
                OnPropertyChanged("AE");
            }
        }

        public int Asz
        {
            get
            {
                return asz;
            }

            set
            {
                asz = value;
                OnPropertyChanged("Asz");
            }
        }

        public int Ép
        {
            get
            {
                return ép;
            }

            set
            {
                ép = value;
                OnPropertyChanged("Ép");
            }
        }

        public int Fp_szint
        {
            get
            {
                return fp_szint;
            }

            set
            {                
                fp_szint = value;
                fp = fp_alap + tizfeletti(ÁK) + tizfeletti(AE) + K6(TSz);
                Fp_szint_kiir = "K6+" + fp_szint.ToString();
                OnPropertyChanged("Fp_szint");
                OnPropertyChanged("Fp");
            }
        }

        public string Fp_szint_kiir
        {
            get
            {
                return fp_szint_kiir;
            }

            set
            {
                fp_szint_kiir = value;
                OnPropertyChanged("Fp_szint_kiir");
            }
        }

        public int Fp_alap
        {
            get
            {
                return fp_alap;
            }

            set
            {
                fp_alap = value;
                OnPropertyChanged("Fp_alap");
            }
        }

        public int Ép_alap
        {
            get
            {
                return ép_alap;
            }

            set
            {
                ép_alap = value;
                OnPropertyChanged("Ép_alap");
            }
        }

        public int Fp
        {
            get
            {
                return fp;
            }

            set
            {
                fp = value;
                OnPropertyChanged("Fp");
                ;
            }
        }

        public int TSz
        {
            get
            {
                return tSz;
            }

            set
            {
                tSz = value;
                OnPropertyChanged("TSz");
            }
        }

        public bool Nagydobás
        {
            get
            {
                return nagydobás;
            }

            set
            {
                nagydobás = value;
                OnPropertyChanged("Nagydobás");
            }
        }

        public void Recalculate()
        {
            
            ;
           // this.Ép_max_label.Content = karakter.Ép.ToString();
        }

        public int K6(int szint)
        {
            Random random = new Random();
            
            int k6=0;
            if (nagydobás == true)
            {
                for (int i = 0; i < szint; i++)
                {
                    k6 += random.Next(1, 3) + 4 + fp_szint;
                }
            }
            else
            {
                for (int i = 0; i < szint; i++)
                {
                    k6 += random.Next(1, 7) + fp_szint;
                }
            }
            return k6;
        }
        


     

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public int tizfeletti(int érték)
        {
            if (érték > 10)
            {
                return érték - 10;
            }
            else return 0;
        }
        public Karakter()
        {
            //Nagydobás = true;
        }
    }//class
}
