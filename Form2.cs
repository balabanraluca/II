using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Diagnostics;

namespace L1_Tema
{
    public partial class Form2 : Form
    {
        private object image;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Metoda.SelectedItem.ToString())
            {
                case "Procesare uscata":
                    pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\Ralluxiss\\Downloads\\Anul_3\\Anul_3\\Sem II\\II\\Laboratorul_2\\L1_Tema\\uscata2.jpg");
                    break;
                case "Washed":
                    //pictureBox2.Image = System.Drawing.Image.FromFile("C:\\Users\\Ralluxiss\\Downloads\\Anul_3\\Anul_3\\Sem II\\II\\Laboratorul_2\\L1_Tema\\forza.jpg");
                    pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\Ralluxiss\\Downloads\\Anul_3\\Anul_3\\Sem II\\II\\Laboratorul_2\\L1_Tema\\fully-washed-vs-smi-washed-coffee-beans.png");
                    break;
                case "Honey":
                    pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\Ralluxiss\\Downloads\\Anul_3\\Anul_3\\Sem II\\II\\Laboratorul_2\\L1_Tema\\HoneyCoconutLatte_2.jpg");

                    break;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Metoda.Items.Add("Procesare uscata");
            Metoda.Items.Add("Washed");
            Metoda.Items.Add("Honey");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A masterpiece of taste!" + "\n" + "The order has been taken!");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            switch (Metoda.SelectedItem.ToString())
            {
                case "Procesare uscata":
                    pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\Ralluxiss\\Downloads\\Anul_3\\Anul_3\\Sem II\\II\\Laboratorul_2\\L1_Tema\\uscata2.jpg");
                    MessageBox.Show("Prin aceasta metoda , fructul de cafea este cules iar apoi este uscat complet intact,ca fruct intreg. Rezultatul este previzibil: " +
                        "o cafea exotica, fructata, care este in general mai dulce decat cafelele procesate diferit.Pentru a ajunge la umiditatea dorita de 10%-12%,timpul " +
                        "de uscare este intre  2-4 saptamani.Odata uscata, cafeaua ramane inca in invelisul de fruct, pana si in etapa de odihna.Cafeaua procesata natural este," +
                        " in general, mai inconsistenta in ceea ce priveste calitatea,deoarece fiecare boaba este inchisa in propriul ei mediu cu nivele diferite de zaharuri " +
                        "si alcool. Pentru a lucra cu aceste variabile in parametri precisi este nevoie de mult timp si multa munca.De aceea cele mai bune cafele procesate " +
                        "natural sunt foarte apreciate in lume.\r\n");
                    break;
                case "Washed":
                    //pictureBox2.Image = System.Drawing.Image.FromFile("C:\\Users\\Ralluxiss\\Downloads\\Anul_3\\Anul_3\\Sem II\\II\\Laboratorul_2\\L1_Tema\\forza.jpg");
                    pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\Ralluxiss\\Downloads\\Anul_3\\Anul_3\\Sem II\\II\\Laboratorul_2\\L1_Tema\\fully-washed-vs-smi-washed-coffee-beans.png");
                    MessageBox.Show("Acesta e cel mai utilizat mod de procesare a cafelei, prin combinarea a diversilor pasi din care rezulta o cafea ce este o expresie atat " +
                        "a soiului, cat si a regiunii. Aceasta metoda de procesare este folosita pentru majoritatea cafelelor lumii.\r\nDupa ce fructul de cafea este cules, " +
                        "pulpa este indepartata si separata de boabe intr-o masina numita “pulper”. Ce ramane este o boaba acoperita cu un strat subtire si dulce de mucilagiu." +
                        " Cea mai comuna metoda de indepartare a mucilagiului este prin fermentatie.\r\nPrin fermentatie, cafeaua este turnata intr-un bazin curat unde sta in " +
                        "suc propriu in timp ce bacteriile si enzimele formate natural dizolva stratul de mucilagiu. Acest proces se poate face cu sau fara apa, si dureaza intre" +
                        " 6 si 72 de ore. Dupa ce mucilaciul se poate indeparta usor de mana, cafeaua este clatita pentru a se indeparta restul reziduurilor.\r\nIn acest stadiu," +
                        " cafeaua este denumita “pergament” , acesta fiind restul de strat protector care invaluie boaba verde, si care este uscat in mai multefeluri. Dupa ce " +
                        "“pergamentul” ajunge la umiditatea dorita, intre 10%- 12% , boabele sunt lasate sa se odihneasca. Dupa perioada de odihna, “pergamentul” este indepartat" +
                        " de pe boabe intr-o moara uscata, iar rezultatul obtinut este o boaba de cafea verde, curata, gata pentru prajit.");
                    break;

                case "Honey":
                    pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\Ralluxiss\\Downloads\\Anul_3\\Anul_3\\Sem II\\II\\Laboratorul_2\\L1_Tema\\HoneyCoconutLatte_2.jpg");
                    MessageBox.Show("Aceasta metoda urmeaza aceiasi pasi ca procesarea spalata, numai ca mucilagiul ramas nu este indepartat, ci este lasat la uscat. " +
                        "Nu toate cafelele honey sar cu totul peste procesul de indepartare a mucilagiului. Unele sunt lasate sa fermenteze un pic, apoi clatite, ca apoi " +
                        "sa fie lasate la uscat. Altele sunt lasate pana cand fermentarea este aproape completa si sunt uscate cand mai au aproape 10% mucilagiu ramas pe boabe." +
                        " Aceasta metoda de procesare este foarte populara in Costa Rica si a inceput sa se intinda si in celelelte tari ale Americii Centrale.\r\nSunt trei " +
                        "niveluri pe care poate sa le atinga cafeaua procesata honey: Yellow. Red si Black.\r\nCafeaua Yellow Honey are cel mai rapid timp de uscare, " +
                        "de aproximativ 8 zile, boabele primesc mult soare ceea ce le face sa ajunga la o culoare galbuie pana cand ajung la nivelul dorit de umiditate.\r\n" +
                        "Cafeaua Red Honey are un timp de uscare mai lung de aproape 12 zile, si este obtinut mai ales in timpul in care cerul este acoperit cu nori.\r\n" +
                        "Cafeaua Black Honey se obtine cel mai greu, si are un timp de uscare de mai mult de o saptamana; boabele sunt acoperite de o prelata neagra in timp " +
                        "ce sunt invartite pe paturile africane inaltate. Cafeaua Black Honey este cea mai complexa, bogata in aroma, fiind si cea mai scumpa.");
                    break;
            }

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (radioButton1.Checked && radioButton1.Text == "L'OR ESPRESSO RISTRETTO ")
            {
                MessageBox.Show("                                             " + "INTENSITATE 11 \n" + "\n" +
                "Acest Ristretto îți va captiva simțurile. " +
                "Complex și cu aromă de nuci, tinde spre perfecțiune. " +
                "O ceașcă mică de cafea tare. Gustul bogat din Ristretto se datorează exclusiv boabelor de cafea Arabica.");


            }
            else
            if (radioButton2.Checked && radioButton2.Text == "L'OR ESPRESSO SUPREMO")
            {
                MessageBox.Show("                                             " + "INTENSITATE 10 \n" + "\n" +
                  "Supremo, puternic și picant, este nemaipomenit datorită notelor complexe de ciocolată neagră," +
                  " stejar și nuci, rotunjite cu un strat de cremă pentru o plăcere intensă a cafelei " +
                  "- pentru un espresso desăvârșit.");
            }
            else
            if (radioButton3.Checked && radioButton3.Text == "L'OR ESPRESSO FORZA ")

            {
                MessageBox.Show("                                             " + "INTENSITATE 9 \n" + "\n" + "Un espresso de rasă pură, cu o intensitate neîngrădită." +
              " Aromă complexă de stejar și lemn dulce, iluminată de nuanțe de chihlimbar care" +
              " dansează pe un strat delicat de cremă.");
            }
            else
            {
                MessageBox.Show("                                             " + "INTENSITATE 9 \n" + "\n" + "Un espresso de rasă pură, cu o intensitate neîngrădită." +
              " Aromă complexă de stejar și lemn dulce, iluminată de nuanțe de chihlimbar care" +
              " dansează pe un strat delicat de cremă.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newform = new Form1();
            newform.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}