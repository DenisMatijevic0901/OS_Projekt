using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace os_projekt
{
    public partial class FormPocetna : Form
    {
        private string putanjaDatoteke;

        public FormPocetna()
        {
            InitializeComponent();
        }

        private void FormPocetna_Load(object sender, EventArgs e)
        {
            tbUcitaniTekst.Enabled = false;
            tbKriptiraniTekst.Enabled = false;
            tbDekriptiraniTekst.Enabled = false;
            tbSazetak.Enabled = false;
            tbDigitalniPotpis.Enabled = false;
            btnDekriptiraj.Enabled = false;
            rbRSA.Enabled = false;
            rbAES.Enabled = false;
        }

        private void btnOdaberiDatoteku_Click(object sender, EventArgs e)
        {
            openFileDialogOdaberiDatoteku.ShowDialog();
            string datoteka = openFileDialogOdaberiDatoteku.FileName;
            putanjaDatoteke = datoteka;
            string tekstDatoteke = File.ReadAllText(datoteka);
            tbUcitaniTekst.Text = tekstDatoteke;
        }

        private void btnGenerirajKljuceve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(putanjaDatoteke))
            {
                MessageBox.Show("Potrebno je odabrati datoteku!");
            }
            else
            {
                using (RSA rsa = RSA.Create())
                {
                    string privatniKljuc = rsa.ToXmlString(true);
                    string javniKljuc = rsa.ToXmlString(false);

                    File.WriteAllText("privatni_kljuc.txt", privatniKljuc);
                    File.WriteAllText("javni_kljuc.txt", javniKljuc);
                }

                using (Aes aes = Aes.Create())
                {
                    byte[] tajniKljuc = aes.Key;
                    byte[] inicijalizacijskiVektor = aes.IV;

                    File.WriteAllText("tajni_kljuc.txt", Convert.ToBase64String(tajniKljuc) + Environment.NewLine + Convert.ToBase64String(inicijalizacijskiVektor));
                }
                MessageBox.Show("Ključevi su generirani.");
                rbRSA.Enabled = true;
                rbAES.Enabled = true;
            }    
        }

        private void kriptirajRSA()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string javniKljucXml = File.ReadAllText("javni_kljuc.txt");
            rsa.FromXmlString(javniKljucXml);

            byte[] ucitaniTekstByte = File.ReadAllBytes(putanjaDatoteke);
            byte[] kriptiraniTekstByte = rsa.Encrypt(ucitaniTekstByte, false);
            File.WriteAllBytes("kriptirani_tekst.txt", kriptiraniTekstByte);
            tbKriptiraniTekst.Text = Convert.ToBase64String(kriptiraniTekstByte);
        }

        private void dekriptirajRSA()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string putanjaKriptiraniTekstTxt = "C:\\Users\\Admin\\source\\repos\\os_projekt\\os_projekt\\bin\\Debug\\kriptirani_tekst.txt";
            string privatniKljucXml = File.ReadAllText("privatni_kljuc.txt");
            rsa.FromXmlString(privatniKljucXml);

            byte[] kriptiraniTekstByte = File.ReadAllBytes(putanjaKriptiraniTekstTxt);
            byte[] dekriptiraniTekstByte = rsa.Decrypt(kriptiraniTekstByte, false);
            File.WriteAllBytes("dekriptirani_tekst.txt", dekriptiraniTekstByte);
            tbDekriptiraniTekst.Text = Encoding.ASCII.GetString(dekriptiraniTekstByte);
        }


        private void kriptirajAES()
        {
            Aes aes = Aes.Create();
            string[] linije = File.ReadLines("tajni_kljuc.txt").ToArray();
            string prvaLinijaKey = linije[0];
            string drugaLinijaInicijalizacijskiVektor = linije[1];

            aes.Key = Convert.FromBase64String(prvaLinijaKey);
            aes.IV = Convert.FromBase64String(drugaLinijaInicijalizacijskiVektor);

            byte[] ucitaniTekst = Encoding.UTF8.GetBytes(tbUcitaniTekst.Text);
            byte[] kriptiraniTekstAESByte;

            ICryptoTransform kriptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using (MemoryStream msObjekt = new MemoryStream())
            {
                using (CryptoStream csObjekt = new CryptoStream(msObjekt, kriptor, CryptoStreamMode.Write))
                {
                    csObjekt.Write(ucitaniTekst, 0, ucitaniTekst.Length);
                    csObjekt.FlushFinalBlock();
                    kriptiraniTekstAESByte = msObjekt.ToArray();
                }
            }
            
            string kriptiraniTekstAES = Convert.ToBase64String(kriptiraniTekstAESByte);
            tbKriptiraniTekst.Text = kriptiraniTekstAES;
            File.WriteAllBytes("kriptirani_tekst.txt", kriptiraniTekstAESByte);
        }

        private void dekriptirajAES()
        {
            Aes aes = Aes.Create();
            string[] linije = File.ReadLines("tajni_kljuc.txt").ToArray();
            string prvaLinijaKey = linije[0];
            string drugaLinijaInicijalizacijskiVektor = linije[1];

            aes.Key = Convert.FromBase64String(prvaLinijaKey);
            aes.IV = Convert.FromBase64String(drugaLinijaInicijalizacijskiVektor);

            byte[] kriptiraniTekstAESByte = File.ReadAllBytes("kriptirani_tekst.txt");
            byte[] dekriptiraniTekstByte;

            ICryptoTransform dekriptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using (MemoryStream msObjekt = new MemoryStream(kriptiraniTekstAESByte))
            {
                using (CryptoStream csObjekt = new CryptoStream(msObjekt, dekriptor, CryptoStreamMode.Read))
                {
                    dekriptiraniTekstByte = new byte[kriptiraniTekstAESByte.Length];
                    csObjekt.Read(dekriptiraniTekstByte, 0, dekriptiraniTekstByte.Length);
                }
            }

            tbDekriptiraniTekst.Text = Encoding.ASCII.GetString(dekriptiraniTekstByte);
            File.WriteAllBytes("dekriptirani_tekst.txt", dekriptiraniTekstByte);
        }

        private void btnKriptiraj_Click(object sender, EventArgs e)
        {
            if (rbRSA.Checked == false && rbAES.Checked == false)
            {
                MessageBox.Show("Potrebno je odabrati algoritam kriptiranja!");
            }
            else
            {
                if (rbRSA.Checked == true)
                {
                    kriptirajRSA();
                    btnDekriptiraj.Enabled = true;
                    rbAES.Enabled = false;
                }

                if (rbAES.Checked == true)
                {
                    kriptirajAES();
                    btnDekriptiraj.Enabled = true;
                    rbRSA.Enabled = false;
                }
                btnKriptiraj.Enabled = false;
            }
        }

        private void btnDekriptiraj_Click(object sender, EventArgs e)
        {
            if (btnKriptiraj.Enabled == false)
            {
                if (rbRSA.Checked == true)
                {
                    dekriptirajRSA();
                    rbAES.Enabled = false;
                }
                if (rbAES.Checked == true)
                {
                    dekriptirajAES();
                    rbRSA.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Prvo je potrebno kriptirati tekst!");
            }
        }

        private byte[] izracunajSazetak(string putanja, HashAlgorithm hashAlgoritam)
        {
            using (var stream = new FileStream(putanja, FileMode.Open))
            {
                return hashAlgoritam.ComputeHash(stream);
            }
        }

        private void btnIzracunajSazetak_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(putanjaDatoteke))
            {
                MessageBox.Show("Potrebno je odabrati datoteku!");
            }
            else
            {
                byte[] hash = izracunajSazetak(putanjaDatoteke, SHA256.Create());
                File.WriteAllText("sazetak.txt", Convert.ToBase64String(hash));
                tbSazetak.Text = Convert.ToBase64String(hash);
            } 
        }

        private byte[] izracunajDigitalniPotpis(RSACryptoServiceProvider rsa)
        {
            string putanjaSazetak = "C:\\Users\\Admin\\source\\repos\\os_projekt\\os_projekt\\bin\\Debug\\sazetak.txt";
            string sazetakString = File.ReadAllText(putanjaSazetak);
            byte[] sazetakByte = Convert.FromBase64String(sazetakString);
            return rsa.SignHash(sazetakByte, CryptoConfig.MapNameToOID("SHA256"));
        }

        private void btnIzracunajDigitalniPotpis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(putanjaDatoteke))
            {
                MessageBox.Show("Potrebno je odabrati datoteku!");
            }
            else
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    string privatniKljucXml = File.ReadAllText("privatni_kljuc.txt");
                    rsa.FromXmlString(privatniKljucXml);

                    byte[] digitalniPotpis = izracunajDigitalniPotpis(rsa);
                    File.WriteAllText("digitalni_potpis.txt", Convert.ToBase64String(digitalniPotpis));
                    tbDigitalniPotpis.Text = Convert.ToBase64String(digitalniPotpis);
                }
            }
        }

        private void btnProvjeriDigitalniPotpis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(putanjaDatoteke))
            {
                MessageBox.Show("Potrebno je odabrati datoteku!");
            }
            else
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    string javniKljucXml = File.ReadAllText("javni_kljuc.txt");
                    rsa.FromXmlString(javniKljucXml);

                    try
                    {
                        byte[] digitalniPotpis = Convert.FromBase64String(File.ReadAllText("digitalni_potpis.txt"));
                        if (provjeriPotpis(putanjaDatoteke, digitalniPotpis, rsa))
                        {
                            MessageBox.Show("Digitalni potpis je valjan!");
                        }
                        else
                        {
                            MessageBox.Show("Digitalni potpis nije valjan!");
                        }
                    }
                    catch (Exception )
                    {

                        MessageBox.Show("Digitalni potpis nije valjan!");
                    }     
                }
            }
        }

        private bool provjeriPotpis(string putanjaDatoteke, byte[] digitalniPotpis, RSACryptoServiceProvider rsa)
        {
            byte[] sazetak = izracunajSazetak(putanjaDatoteke, SHA256.Create());
            return rsa.VerifyHash(sazetak, CryptoConfig.MapNameToOID("SHA256"), digitalniPotpis);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbUcitaniTekst.Clear();
            tbKriptiraniTekst.Clear();
            tbDekriptiraniTekst.Clear();
            tbSazetak.Clear();
            tbDigitalniPotpis.Clear();
            rbRSA.Checked = false;
            rbAES.Checked = false;
            rbRSA.Enabled = false;
            rbAES.Enabled = false;
            File.Delete("javni_kljuc.txt");
            File.Delete("privatni_kljuc.txt");
            File.Delete("tajni_kljuc.txt");
            File.Delete("kriptirani_tekst.txt");
            File.Delete("dekriptirani_tekst.txt");
            File.Delete("sazetak.txt");
            File.Delete("digitalni_potpis.txt");
            btnKriptiraj.Enabled = true;
            btnDekriptiraj.Enabled = false;
            putanjaDatoteke = "";
        }
    }
}
