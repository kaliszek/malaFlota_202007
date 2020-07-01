using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz
{
    public class Kierowcy
    {
        private int MK_Id;
        private string MK_Imie;
        private string MK_Nazwisko;
        private string MK_Pesel;
        private string MK_Miasto;
        private string MK_Ulica;
        private string MK_KodP;
	    private string MK_Poczta;
        private string MK_NrDomu;
        private string MK_NrLokalu;
        private DateTime MK_DataUr;
        private DateTime MK_DataBadLek;
        private string MK_TEL1;
        private string MK_TEL2;
        private int MK_KatA;
        private int MK_KatB;
        private int MK_KatC;
        private int MK_KatD;
        private int MK_Upr;

        public int MkId
        {
            get { return MK_Id; }
            set { MK_Id = value; }
        }

        public string MkImie
        {
            get { return MK_Imie; }
            set { MK_Imie = value; }
        }

        public string MkNazwisko
        {
            get { return MK_Nazwisko; }
            set { MK_Nazwisko = value; }
        }

        public string MkPesel
        {
            get { return MK_Pesel; }
            set { MK_Pesel = value; }
        }

        public string MkMiasto
        {
            get { return MK_Miasto; }
            set { MK_Miasto = value; }
        }

        public string MkUlica
        {
            get { return MK_Ulica; }
            set { MK_Ulica = value; }
        }

        public string MkKodP
        {
            get { return MK_KodP; }
            set { MK_KodP = value; }
        }

        public string MkPoczta
        {
            get { return MK_Poczta; }
            set { MK_Poczta = value; }
        }

        public string MkNrDomu
        {
            get { return MK_NrDomu; }
            set { MK_NrDomu = value; }
        }

        public string MkNrLokalu
        {
            get { return MK_NrLokalu; }
            set { MK_NrLokalu = value; }
        }

        public DateTime MkDataUr
        {
            get { return MK_DataUr; }
            set { MK_DataUr = value; }
        }

        public DateTime MkDataBadLek
        {
            get { return MK_DataBadLek; }
            set { MK_DataBadLek = value; }
        }

        public string MkTel1
        {
            get { return MK_TEL1; }
            set { MK_TEL1 = value; }
        }

        public string MkTel2
        {
            get { return MK_TEL2; }
            set { MK_TEL2 = value; }
        }

        public int MkKatA
        {
            get { return MK_KatA; }
            set { MK_KatA = value; }
        }

        public int MkKatB
        {
            get { return MK_KatB; }
            set { MK_KatB = value; }
        }

        public int MkKatC
        {
            get { return MK_KatC; }
            set { MK_KatC = value; }
        }

        public int MkKatD
        {
            get { return MK_KatD; }
            set { MK_KatD = value; }
        }

        public int MkUpr
        {
            get { return MK_Upr; }
            set { MK_Upr = value; }
        }
    }
}
