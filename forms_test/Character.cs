using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace forms_test
{
    class Character
    {
        private Random rnd = new Random();
        public Dictionary<string,int> Attributes = new Dictionary<string, int>();
        public string Race;
        public string Clas;
        public int WW;
        public int US;
        public int K;
        public int ODP;
        public int ZR;
        public int INTE;
        public int SW;
        public int OGD;
        public int A;
        public int ZYW;
        public int S;
        public int WT;
        public int SZ;
        public int MAG;
        public int PO;
        public int PP;

        private int K10()
        {
            return rnd.Next(10) + 1;
        }

        private int K100()
        {
            return rnd.Next(100) + 1;
        }

        private int DK10()
        {
            return K10() + K10();
        }

        private int DivStat(int s)
        {
            return (s / 10);
        }
        private void HP_Roll()

        {
            int roll = K10();
            if (roll <= 3) ZYW = 10;
            else if (roll >= 4 && roll < 7) ZYW = 11;
            else if (roll >= 7 && roll <= 9) ZYW = 12;
            else ZYW = 13;
            if (Race == "Krasnolud") ZYW++;
            else if (Race == "Elf") ZYW--;
            else if (Race == "Niziołek") ZYW -= 2;
        }

        private void PP_Roll()
        {
            int roll = K10();
            if (Race == "Człowiek")
            {
                if (roll <= 4) PP = 2;
                else PP = 3;
            }
            else if (Race == "Krasnolud")
            {
                if (roll <= 4) PP = 1;
                else if (roll > 4 && roll <= 7) PP = 2;
                else PP = 3;
            }
            else if (Race == "Elf")
            {
                if (roll <= 4) PP = 1;
                else PP = 2;
            }
            else
            {
                if (roll <= 7) PP = 2;
                else PP = 3;
            }
        }

        private void Speed_Roll()
        {
            if (Race == "Elf") SZ = 5;
            else if (Race == "Krasnolud") SZ = 3;
            else SZ = 4;
        }

        private void Race_Roll()
        {
            int roll = K10();
            if (roll <= 3) Race = "Człowiek";
            else if (roll > 3 && roll <= 5) Race = "Elf";
            else if (roll > 5 && roll <= 8) Race = "Krasnolud";
            else Race = "Niziołek";
        }

        private void Stat_Roll()
        {
            WW = 20 + DK10();
            US = 20 + DK10();
            K = 20 + DK10();
            ODP = 20 + DK10();
            ZR = 20 + DK10();
            INTE = 20 + DK10();
            SW = 20 + DK10();
            OGD = 20 + DK10();
            A = 1;
            MAG = 0;
            PO = 0;
            if (Race == "Elf")
            {
                US += 10;
                ZR += 10;
            }
            else if (Race == "Krasnolud")
            {
                WW += 10;
                ODP += 10;
                OGD -= 10;
                ZR -= 10;
            }
            else if (Race == "Niziołek")
            {
                WW -= 10;
                K -= 10;
                ODP -= 10;
                US += 10;
                ZR += 10;
                OGD += 10;
            }
            S = DivStat(K);
            WT = DivStat(ODP);
        }

        public Character()
        {
            Race_Roll();
            Stat_Roll();
            HP_Roll();
            PP_Roll();
            Speed_Roll();
            Attributes.Add("WW", WW);
            Attributes.Add("US",US);
            Attributes.Add("K",K);
            Attributes.Add("ODP",ODP);
            Attributes.Add("ZR",ZR);
            Attributes.Add("INT", INTE);
            Attributes.Add("SW",SW);
            Attributes.Add("OGD",OGD);
            Attributes.Add("A",A);
            Attributes.Add("ZYW",ZYW);
            Attributes.Add("S",S);
            Attributes.Add("WT",WT);
            Attributes.Add("SZ",SZ);
            Attributes.Add("MAG",MAG);
            Attributes.Add("PO",PO);
            Attributes.Add("PP",PP);
        }
    }
}
