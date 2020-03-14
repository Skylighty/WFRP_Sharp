using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace forms_test
{ 
    //TODO - BAZA DANYCH KLAS
    //TODO - WCZYTYWANE KLAS DO PROGRAMU
    //TODO - BAZA DANYCH RAS
    //TODO - WCZYTYWANIE KLAS DO PROGRAMU
    //TODO - INTERFEJS GRAFICZNY (NA KOŃCU)
    public partial class Form1 : Form
    {
        List<Character> Characters = new List<Character>(); //LISTA POSTACI
        public int ActiveIndex = -1; //INDEX AKTYWNY LISTY DO PRZEWIJANIA
        public int MaxIndex = -1; //INDEX MAKSYMALNY LISTY
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenClick(object sender, EventArgs e)
        {
            try
            {
                Character NewTemp = new Character();
                Characters.Add(NewTemp);
                ActiveIndex++;
                MaxIndex++;
                ShowCharacter(MaxIndex);
                ActiveIndex = MaxIndex;
            }
            catch (Exception)
            {
                throw;
            }

        } //GENEROWANIE - DONE
        
        private void BtnNextClick(object sender, EventArgs e)
        {
            try
            {
                ActiveIndex++;
                ShowCharacter(ActiveIndex);
            }
            catch (Exception)
            {
                ActiveIndex = MaxIndex;
                MessageBox.Show("To już ostatnia postać na liście! Stwórz nową lub się cofnij!", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }//PRZEWIJANIE DO PROZDU - DONE
        
        private void BtnPrevClick(object sender, EventArgs e)
        {
            try
            {
                ActiveIndex--;
                ShowCharacter(ActiveIndex);
            }
            catch (Exception)
            {
                ActiveIndex = 0;
                MessageBox.Show("To pierwsza postać na liście! Stwórz nową lub idz dalej!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } //PRZEWIJANIE DO TYLU - DONE

        private void ShowCharacter(int idx)
        {
            TbWW.Text = Characters[idx].WW.ToString();
            TbUS.Text = Characters[idx].US.ToString();
            TbK.Text = Characters[idx].K.ToString();
            TbODP.Text = Characters[idx].ODP.ToString();
            TbZR.Text = Characters[idx].ZR.ToString();
            TbINTE.Text = Characters[idx].INTE.ToString();
            TbSW.Text = Characters[idx].SW.ToString();
            TbOGD.Text = Characters[idx].OGD.ToString();
            TbA.Text = Characters[idx].A.ToString();
            TbZYW.Text = Characters[idx].ZYW.ToString();
            TbS.Text = Characters[idx].S.ToString();
            TbWT.Text = Characters[idx].WT.ToString();
            TbSZ.Text = Characters[idx].SZ.ToString();
            TbMAG.Text = Characters[idx].MAG.ToString();
            TbPO.Text = Characters[idx].PO.ToString();
            TbPP.Text = Characters[idx].PP.ToString();
            TbRace.Text = Characters[idx].Race;
            TbClas.Text = Characters[idx].Clas;
        } //FUNKCJA WYRZUCAJACA POSTAC DO TB PROGRAMU - DONE


    }
}
