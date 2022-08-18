using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolko_krzyzyk_p4_zaliczenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //zmiene
        bool gracz1 = true;//zawsze jest kółkiem gracz 1
        int ruch = 0;
        private string connectString = @"Data Source=DESKTOP-5648FP4;Initial Catalog=KółkoKrzyżyk;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //przywracamy wszystko do stanu początkowego
        private void btnRestartuj_Click(object sender, EventArgs e)
        {
            Restartuj();
            
            wynikO.Text = "0";
            wynikX.Text = "0";
            lblKto.Text = "O";
            gracz1 = true;

        }
        //czysci elementy zwiazane z przyciskami gry
        private void Restartuj()
        {
            ruch = 0;
            //tablica wszystkich  przycisków 
            Button[] all = new Button[9];
            all[0] = btn1;
            all[1] = btn2;
            all[2] = btn3;
            all[3] = btn4;
            all[4] = btn5;
            all[5] = btn6;
            all[6] = btn7;
            all[7] = btn8;
            all[8] = btn9;
            //petla dla wszystkich przycisków odblokuwujące je oraz czyszczone text
            foreach (Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
                b.BackColor = Color.FromArgb(255,240,240,240);

            }
           

        }
        //funkcja sprawdza czy ktoreś z 3 pól nie ma tego samego znaku oraz czy nie zapełniono planszy
        private void Sprawdz()
        {
            if ((btn1.Text !="")&(btn1.Text==btn2.Text)&(btn2.Text==btn3.Text))
            {
               
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                Wygrana();
                
            }
            else if((btn4.Text!="")&(btn4.Text==btn5.Text)&(btn5.Text==btn6.Text))
            {
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn6.BackColor = Color.Green;

                Wygrana();
            }
            else if ((btn7.Text!="")&(btn7.Text==btn8.Text)&(btn8.Text==btn9.Text))
            {
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                Wygrana();
            }
            else if ((btn1.Text!="") &(btn1.Text==btn4.Text)&(btn4.Text==btn7.Text))
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;

                Wygrana();
            }
            else if ((btn2.Text!="")&(btn2.Text==btn5.Text)&(btn5.Text==btn8.Text))
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;

                Wygrana();
            }
            else if((btn3.Text!="")&(btn3.Text==btn6.Text)&(btn6.Text==btn9.Text))
            {
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                Wygrana();
            }
            else if ((btn1.Text!="")&(btn1.Text==btn5.Text)&(btn5.Text==btn9.Text))
            {
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                Wygrana();
            }
            else if((btn7.Text!="")&(btn7.Text==btn5.Text)&(btn5.Text==btn3.Text))
            {
                btn7.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn3.BackColor = Color.Green;

                Wygrana();
            }
            else if (ruch ==9)
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restartuj();
            }
        }
        //funkcja pokazuje wiadomosc wygranej
        //oraz zwieksza wynik o 1 restartujac plansze
        private void Wygrana()
        {
            MessageBox.Show("Wygrana gracz:" + (gracz1 ? "O" : "X"), "Wygrana gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (gracz1)
            {
                wynikO.Text = ((int.Parse(wynikO.Text)) + 1).ToString();
            }
            else
            {
                wynikX.Text = ((int.Parse(wynikX.Text)) + 1).ToString();
            }
            Restartuj();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ruch++;
            //konwersja sender(wysłany obiect) ktory wiemy ze jest przyciskiem
            //zmiana textu oraz blokowanie przycisku
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            //sprawdzanie czy ktos wygrał od 5 ruchu
            if (ruch >=5)
            {
                Sprawdz();
            }
            //zmiana ruchu
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O":"X";


        }


        private void btn2_Click(object sender, EventArgs e)
        {
            ruch++;
            //konwersja sender(wysłany obiect) ktory wiemy ze jest przyciskiem
            //zmiana textu oraz blokowanie przycisku
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            //sprawdzanie czy ktos wygrał od 5 ruchu
            if (ruch >= 5)
            {
                Sprawdz();
            }
            //zmiana ruchu
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ruch++;
            //konwersja sender(wysłany obiect) ktory wiemy ze jest przyciskiem
            //zmiana textu oraz blokowanie przycisku
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            //sprawdzanie czy ktos wygrał od 5 ruchu
            if (ruch >= 5)
            {
                Sprawdz();
            }
            //zmiana ruchu
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";


        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ruch++;
            //konwersja sender(wysłany obiect) ktory wiemy ze jest przyciskiem
            //zmiana textu oraz blokowanie przycisku
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            //sprawdzanie czy ktos wygrał od 5 ruchu
            if (ruch >= 5)
            {
                Sprawdz();
            }
            //zmiana ruchu
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ruch++;
            //konwersja sender(wysłany obiect) ktory wiemy ze jest przyciskiem
            //zmiana textu oraz blokowanie przycisku
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            //sprawdzanie czy ktos wygrał od 5 ruchu
            if (ruch >= 5)
            {
                Sprawdz();
            }
            //zmiana ruchu
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ruch++;
            //konwersja sender(wysłany obiect) ktory wiemy ze jest przyciskiem
            //zmiana textu oraz blokowanie przycisku
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            //sprawdzanie czy ktos wygrał od 5 ruchu
            if (ruch >= 5)
            {
                Sprawdz();
            }
            //zmiana ruchu
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";


        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ruch++;
            //konwersja sender(wysłany obiect) ktory wiemy ze jest przyciskiem
            //zmiana textu oraz blokowanie przycisku
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            //sprawdzanie czy ktos wygrał od 5 ruchu
            if (ruch >= 5)
            {
                Sprawdz();
            }
            //zmiana ruchu
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";


        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ruch++;
            //konwersja sender(wysłany obiect) ktory wiemy ze jest przyciskiem
            //zmiana textu oraz blokowanie przycisku
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            //sprawdzanie czy ktos wygrał od 5 ruchu
            if (ruch >= 5)
            {
                Sprawdz();
            }
            //zmiana ruchu
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";


        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ruch++;
            //konwersja sender(wysłany obiect) ktory wiemy ze jest przyciskiem
            //zmiana textu oraz blokowanie przycisku
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
       
            //sprawdzanie czy ktos wygrał od 5 ruchu
            if (ruch >= 5)
            {
                Sprawdz();
            }
            //zmiana ruchu
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";


        }

        private void txtBoxO_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxO.Text == "Podaj Nazwe")
            {
                txtBoxO.Text = "";
            }
           
        }

        private void txtBoxX_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxX.Text == "Podaj Nazwe")
            {
                txtBoxX.Text = "";
            }
            
        }
        private void Zapisz()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                sqlCon.Open();
                var command = new SqlCommand("insert into Wyniki([Gracz O],[Wynik O],[Gracz X],[Wynik X],[Data])  " +
                     "  values(@GraczO,@WynikO,@GraczX,@WynikX,@Data)", sqlCon);

                command.Parameters.AddWithValue("GraczO", txtBoxO.Text);
                command.Parameters.AddWithValue("WynikO", int.Parse(wynikO.Text));
                command.Parameters.AddWithValue("GraczX", txtBoxX.Text);
                command.Parameters.AddWithValue("WynikX", int.Parse(wynikX.Text));
                command.Parameters.AddWithValue("Data", DateTime.Now);
                command.ExecuteNonQuery();

            }

            MessageBox.Show("Zapisano wyniki!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBoxX.Text = "Podaj Nazwe";
            txtBoxO.Text = "Podaj Nazwe";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            Zapisz();
        }
        private void OtworzWynik()
        {
            Wyniki okno = new Wyniki();
            okno.Show();
        }
        private void btnWyniki_Click(object sender, EventArgs e)
        {
            OtworzWynik();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtworzWynik();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapisz();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restartuj();

            wynikO.Text = "0";
            wynikX.Text = "0";
            lblKto.Text = "O";
            gracz1 = true;
            txtBoxO.Text = "Podaj Nazwe";
            txtBoxX.Text = "Podaj Nazwe";
        }

        
    }
}
