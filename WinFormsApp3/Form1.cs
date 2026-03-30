using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static WinFormsApp3.Form1;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        List<Ucenik> ucenici = new List<Ucenik>();
        List<Profil> profili = new List<Profil>();
        public Form1()
        {
            InitializeComponent();
            buttonSacuvajIzmenu.Enabled = false;
            comboBoxprofilnaziv1.Enabled = false;
            comboBoxprofilnaziv2.Enabled = false;
            comboBoxprofilnaziv3.Enabled = false;
            comboBoxnaziv1.Enabled = false;
            comboBoxnaziv2.Enabled = false;
            comboBoxnaziv3.Enabled = false;
            comboBoxskola.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxnaziv1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxnaziv2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxnaziv3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxodeljenje.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxjezik.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxtip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxprofiljezik.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxprofiltip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxprofilnaziv1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxprofilnaziv2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxprofilnaziv3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIzaberiProfil.DropDownStyle = ComboBoxStyle.DropDownList;


            comboBoxjezik.Items.AddRange(new string[] { "Srpski jezik",
                                                        "Albanski jezik",
                                                        "Bosanski jezik",
                                                        "Bugarski jezik",
                                                        "Madjarski jezik",
                                                        "Rumunski jezik",
                                                        "Rusinski jezik",
                                                        "Slovacki jezik",
                                                        "Hrvatski jezik"});

            comboBoxprofiljezik.Items.AddRange(new string[] { "Srpski jezik",
                                                        "Albanski jezik",
                                                        "Bosanski jezik",
                                                        "Bugarski jezik",
                                                        "Madjarski jezik",
                                                        "Rumunski jezik",
                                                        "Rusinski jezik",
                                                        "Slovacki jezik",
                                                        "Hrvatski jezik"});

            comboBoxodeljenje.Items.AddRange(new string[] { "IV-1",
                                                            "IV-2",
                                                            "IV-3",
                                                            "IV-4",
                                                            "IV-5",
                                                            "IV-6",
                                                            "IV-7",
                                                            "IV-8",
                                                            "IV-9",
                                                            "IV-10",
                                                            "III-1",
                                                            "III-2",
                                                            "III-3",
                                                            "III-4",
                                                            "III-5",
                                                            "III-6",
                                                            "III-7",
                                                            "III-8",
                                                            "III-9",
                                                            "III-10"});

            comboBoxskola.Items.AddRange(new string[]
            {
                "Prva beogradska gimnazija",
                "Druga beogradska gimnazija",
                "Treca beogradska gimnazija",
                "Cetvrta beogradska gimnazija",
                "Peta beogradska gimnazija",
                "Sesta beogradska gimnazija",
                "Sedma beogradska gimnazija",
                "Osma beogradska gimnazija",
                "Deveta gimnazija Mihailo Petrovic Alas",
                "Deseta gimnazija Mihajlo Pupin",
                "Trinaesta beogradska gimnazija",
                "Cetrnaesta beogradska gimnazija",
                "Petnaesta beogradska gimnazija",
                "Matematicka gimnazija",
                "Filoloska gimnazija",
                "Prva ekonomska skola",
                "Druga ekonomska skola",
                "Pravno-poslovna skola Beograd",
                "Elektrotehnicka skola Nikola Tesla",
                "Elektrotehnicka skola Rade Koncar",
                "Vazduhoplovna akademija",
                "Medicinska skola Zvezdara",
                "Medicinska skola Beograd",
                "Srednja farmaceutsko-fizioterapeutska skola",
                "Građevinska tehnicka skola Branko zezelj",
                "Arhitektonska tehnicka skola",
                "Masinska skola Radoje Dakic",
                "Saobracajno-tehnicka skola Zemun",
                "PTT skola",
                "Trgovacka skola Beograd",
                "Ugostiteljsko-turisticka skola",
                "Skola za dizajn",
                "Tehnoart Beograd",
                "Hemijsko-prehrambena tehnoloska skola",
                "Graficka skola"
            });

            comboBoxtip.Items.AddRange(new string[]
            {
                "Opsta",
                "Strucna",
                "Umetnicka"
            });

            comboBoxprofiltip.Items.AddRange(new string[]
            {
                "Opsta",
                "Strucna",
                "Umetnicka"
            });
        }

        private void Sacuvaju()
        {
            using (StreamWriter sw = new StreamWriter("ucenici.csv"))
            {
                foreach (Ucenik u in ucenici)
                {
                    string linija = $"{u.ime};{u.prezime};{u.skola};{u.odeljenje};{u.tip};{u.jezik};{u.naziv1};{u.naziv2};{u.naziv3}";
                    sw.WriteLine(linija);
                }
            }
        }

        private void Sacuvajp()
        {
            using (StreamWriter sw = new StreamWriter("profili.csv"))
            {
                foreach (Profil p in profili)
                {
                    string linija = $"{p.profil};{p.tip};{p.jezik};{p.naziv1};{p.naziv2};{p.naziv3}";
                    sw.WriteLine(linija);
                }
            }
        }

        private void comboBoxtip_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxnaziv1.Items.Clear();
            comboBoxnaziv2.Items.Clear();
            comboBoxnaziv3.Items.Clear();

            if (comboBoxtip.SelectedItem == null)
            {
                comboBoxnaziv1.Enabled = false;
                comboBoxnaziv2.Enabled = false;
                comboBoxnaziv3.Enabled = false;
                return;
            }

            comboBoxnaziv1.Enabled = true;
            comboBoxnaziv2.Enabled = true;
            comboBoxnaziv3.Enabled = true;

            comboBoxnaziv1.Items.AddRange(new string[] { "Srpski jezik i knjizevnost",
                                                             "Albanski jezik i knjizevnost",
                                                             "Bosanski jezik i knjizevnost",
                                                             "Bugarski jezik i knjizevnost",
                                                             "Madjarski jezik i knjizevnost",
                                                             "Rumunski jezik i knjizevnost",
                                                             "Rusinski jezik i knjizevnost",
                                                             "Slovacki jezik i knjizevnost",
                                                             "Hrvatski jezik i knjizevnost"});
            comboBoxnaziv2.Items.AddRange(new string[] { "Matematika" });
            comboBoxnaziv2.SelectedIndex = 0;

            if (comboBoxtip.SelectedItem.ToString() == "Opsta")
            {
                comboBoxnaziv3.Items.AddRange(new string[] { "Biologija",
                                                             "Geografija",
                                                             "Engleski jezik",
                                                             "Istorija",
                                                             "Italijanski jezik",
                                                             "Nemacki jezik",
                                                             "Ruski jezik",
                                                             "Srpski kao nematernji jezik",
                                                             "Fizika",
                                                             "Francuski jezik",
                                                             "Hemija",
                                                             "Spanski jezik" });
            }
            else if (comboBoxtip.SelectedItem.ToString() == "Strucna")
            {
                comboBoxnaziv3.Items.AddRange(new string[] { "Zootehnicar",
"Tehnicar za biotehnologiju",
"Tehnicar poljoprivredne tehnike",
"Tehnicar hortikulture",
"Tehnicar za pejzaznu arhitekturu",
"Sumarski tehnicar",
"Geoloski tehnicar za geotehniku i hidrogeologiju",
"Geoloski tehnicar za istrazivanje mineralnih sirovina",
"Rudarski tehnicar",
"Rudarski tehnicar za pripremu mineralnih sirovina",
"Brodomasinski tehnicar",
"Masinski tehnicar za kompjutersko konstruisanje",
"Masinski tehnicar merne i regulacione tehnike",
"Masinski tehnicar motornih vozila",
"Tehnicar grejanja i klimatizacije",
"Tehnicar za kompjutersko upravljanje (CNC) masina",
"Tehnicar za robotiku",
"Tehnicar masinske energetike",
"Tehnicar optike",
"Elektrotehnicar automatike",
"Elektrotehnicar elektromotornih pogona",
"Elektrotehnicar elektronike",
"Elektrotehnicar energetike",
"Elektrotehnicar za termicke i rashladne uređaje",
"Elektrotehnicar informacionih tehnologija",
"Elektrotehnicar procesnog upravljanja",
"Elektrotehnicar racunara",
"Tehnicar graficke dorade",
"Tehnicar za zastitu zivotne sredine",
"Tehnicar za industrijsku farmaceutsku tehnologiju",
"Tehnicar stampe",
"Fotograf",
"Hemijski laborant",
"Hemijsko-tehnoloski tehnicar",
"Tekstilni tehnicar",
"Građevinski tehnicar za laboratorijska ispitivanja",
"Građevinski tehnicar za hidrogradnju",
"Izvođac instalaterskih i zavrsnih građevinskih radova",
"Nauticki tehnicar - recni smer",
"Saobracajno-transportni tehnicar",
"Tehnicar vuce",
"Tehnicar PTT saobracaja",
"Tehnicar unutrasnjeg transporta",
"Transportni komercijalista",
"Kulinarski tehnicar",
"Ugostiteljski tehnicar",
"Ekonomski tehnicar",
"Finansijski tehnicar",
"Carinski tehnicar",
"Ginekolosko-akuserska sestra",
"Zubni tehnicar",
"Medicinska sestra - vaspitac",
"Pedijatrijska sestra - tehnicar",
"Sanitarno-ekoloski tehnicar",
"Scenski masker i vlasuljar"});
            }

            else if (comboBoxtip.SelectedItem.ToString() == "Umetnicka")
            {

                comboBoxnaziv3.Items.AddRange(new string[] { "Soleđo", "Harmonija" });
            }
        }

        public class Profil
        {
            public string profil { get; set; }
            public string tip { get; set; }
            public string naziv1 { get; set; }
            public string naziv2 { get; set; }
            public string naziv3 { get; set; }
            public string jezik { get; set; }

            public Profil()
            {
                profil = "";
                tip = "";
                naziv1 = "";
                naziv2 = "";
                naziv3 = "";
                jezik = "";
            }
        }

        public class Ucenik
        {
            public string ime { get; set; }
            public string prezime { get; set; }
            public string odeljenje { get; set; }
            public string skola { get; set; }
            public string tip { get; set; }
            public string jezik { get; set; }
            public string naziv1 { get; set; }
            public string naziv2 { get; set; }
            public string naziv3 { get; set; }

            public Ucenik()
            {
                ime = "";
                prezime = "";
                odeljenje = "";
                skola = "";
                tip = "";
                jezik = "";
                naziv1 = "";
                naziv2 = "";
                naziv3 = "";
            }
        }

        private void buttonpotvrdi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxime.Text) ||
            string.IsNullOrWhiteSpace(textBoxprezime.Text) ||
            comboBoxskola.SelectedIndex == -1 ||
            comboBoxodeljenje.SelectedIndex == -1 ||
            comboBoxjezik.SelectedIndex == -1 ||
            comboBoxtip.SelectedIndex == -1 ||
            comboBoxnaziv1.SelectedIndex == -1 ||
            comboBoxnaziv2.SelectedIndex == -1 ||
            comboBoxnaziv3.SelectedIndex == -1)
            {
                MessageBox.Show("Sva polja moraju biti popunjena!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Ucenik ucenik = new Ucenik();
            ucenik.ime = textBoxime.Text;
            ucenik.prezime = textBoxprezime.Text;
            ucenik.odeljenje = comboBoxodeljenje.Text;
            ucenik.skola = comboBoxskola.Text;
            ucenik.jezik = comboBoxjezik.Text;
            ucenik.tip = comboBoxtip.Text;
            ucenik.naziv1 = comboBoxnaziv1.Text;
            ucenik.naziv2 = comboBoxnaziv2.Text;
            ucenik.naziv3 = comboBoxnaziv3.Text;

            dataGridViewUcenici.Rows.Add(ucenik.ime, ucenik.prezime, ucenik.skola, ucenik.odeljenje, ucenik.tip, ucenik.jezik, ucenik.naziv1, ucenik.naziv2, ucenik.naziv3);

            ucenici.Add(ucenik);
            Sacuvaju();

            textBoxime.Text = "";
            textBoxprezime.Text = "";
            comboBoxodeljenje.SelectedIndex = -1;
            comboBoxskola.SelectedIndex = -1;
            comboBoxjezik.SelectedIndex = -1;
            comboBoxtip.SelectedIndex = -1;
            comboBoxnaziv1.SelectedIndex = -1;
            comboBoxnaziv2.SelectedIndex = -1;
            comboBoxnaziv3.SelectedIndex = -1;
            cmbIzaberiProfil.SelectedIndex = 0;
            dataGridViewUcenici.ClearSelection();
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {
            selektovaniIndeksUcenika = -1;
            buttonSacuvajIzmenu.Enabled = false;
            dataGridViewUcenici.ClearSelection();

            textBoxime.Text = "";
            textBoxprezime.Text = "";
            comboBoxodeljenje.SelectedIndex = -1;
            comboBoxskola.SelectedIndex = -1;
            comboBoxjezik.SelectedIndex = -1;
            comboBoxtip.SelectedIndex = -1;
            comboBoxnaziv1.SelectedIndex = -1;
            comboBoxnaziv2.SelectedIndex = -1;
            comboBoxnaziv3.SelectedIndex = -1;
            cmbIzaberiProfil.SelectedIndex = 0;
        }
        private void buttonobrisi_Click(object sender, EventArgs e)
        {

            if (dataGridViewUcenici.SelectedRows.Count > 0)
            {
                DataGridViewRow izabraniRed = dataGridViewUcenici.SelectedRows[0];

                if (izabraniRed.IsNewRow) return;

                int selektovaniIndeks = izabraniRed.Index;
                if (selektovaniIndeks < ucenici.Count)
                {
                    ucenici.RemoveAt(selektovaniIndeks);
                }
                dataGridViewUcenici.Rows.RemoveAt(selektovaniIndeks);
                Sacuvaju();
            }
            selektovaniIndeksUcenika = -1;
            buttonSacuvajIzmenu.Enabled = false;
            textBoxime.Text = "";
            textBoxprezime.Text = "";
            comboBoxodeljenje.SelectedIndex = -1;
            comboBoxjezik.SelectedIndex = -1;
            comboBoxtip.SelectedIndex = -1;
            comboBoxnaziv1.SelectedIndex = -1;
            comboBoxnaziv2.SelectedIndex = -1;
            comboBoxnaziv3.SelectedIndex = -1;
            comboBoxskola.SelectedIndex = -1;
            cmbIzaberiProfil.SelectedIndex = 0;
        }

        private void comboBoxprofiltip_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxprofilnaziv1.Items.Clear();
            comboBoxprofilnaziv2.Items.Clear();
            comboBoxprofilnaziv3.Items.Clear();

            if (comboBoxprofiltip.SelectedItem == null)
            {
                comboBoxprofilnaziv1.Enabled = false;
                comboBoxprofilnaziv2.Enabled = false;
                comboBoxprofilnaziv3.Enabled = false;
                return;
            }

            comboBoxprofilnaziv1.Enabled = true;
            comboBoxprofilnaziv2.Enabled = true;
            comboBoxprofilnaziv3.Enabled = true;

            comboBoxprofilnaziv1.Items.AddRange(new string[] { "Srpski jezik i knjizevnost",
                                                             "Albanski jezik i knjizevnost",
                                                             "Bosanski jezik i knjizevnost",
                                                             "Bugarski jezik i knjizevnost",
                                                             "Madjarski jezik i knjizevnost",
                                                             "Rumunski jezik i knjizevnost",
                                                             "Rusinski jezik i knjizevnost",
                                                             "Slovacki jezik i knjizevnost",
                                                             "Hrvatski jezik i knjizevnost"});
            comboBoxprofilnaziv2.Items.AddRange(new string[] { "Matematika" });

            if (comboBoxprofiltip.SelectedItem.ToString() == "Opsta")
            {
                comboBoxprofilnaziv3.Items.AddRange(new string[] { "Biologija",
                                                             "Geografija",
                                                             "Engleski jezik",
                                                             "Istorija",
                                                             "Italijanski jezik",
                                                             "Nemacki jezik",
                                                             "Ruski jezik",
                                                             "Srpski kao nematernji jezik",
                                                             "Fizika",
                                                             "Francuski jezik",
                                                             "Hemija",
                                                             "Spanski jezik" });
            }
            else if (comboBoxprofiltip.SelectedItem.ToString() == "Strucna")
            {
                comboBoxprofilnaziv3.Items.AddRange(new string[] { "Zootehnicar",
"Tehnicar za biotehnologiju",
"Tehnicar poljoprivredne tehnike",
"Tehnicar hortikulture",
"Tehnicar za pejzaznu arhitekturu",
"Sumarski tehnicar",
"Geoloski tehnicar za geotehniku i hidrogeologiju",
"Geoloski tehnicar za istrazivanje mineralnih sirovina",
"Rudarski tehnicar",
"Rudarski tehnicar za pripremu mineralnih sirovina",
"Brodomasinski tehnicar",
"Masinski tehnicar za kompjutersko konstruisanje",
"Masinski tehnicar merne i regulacione tehnike",
"Masinski tehnicar motornih vozila",
"Tehnicar grejanja i klimatizacije",
"Tehnicar za kompjutersko upravljanje (CNC) masina",
"Tehnicar za robotiku",
"Tehnicar masinske energetike",
"Tehnicar optike",
"Elektrotehnicar automatike",
"Elektrotehnicar elektromotornih pogona",
"Elektrotehnicar elektronike",
"Elektrotehnicar energetike",
"Elektrotehnicar za termicke i rashladne uređaje",
"Elektrotehnicar informacionih tehnologija",
"Elektrotehnicar procesnog upravljanja",
"Elektrotehnicar racunara",
"Tehnicar graficke dorade",
"Tehnicar za zastitu zivotne sredine",
"Tehnicar za industrijsku farmaceutsku tehnologiju",
"Tehnicar stampe",
"Fotograf",
"Hemijski laborant",
"Hemijsko-tehnoloski tehnicar",
"Tekstilni tehnicar",
"Građevinski tehnicar za laboratorijska ispitivanja",
"Građevinski tehnicar za hidrogradnju",
"Izvođac instalaterskih i zavrsnih građevinskih radova",
"Nauticki tehnicar - recni smer",
"Saobracajno-transportni tehnicar",
"Tehnicar vuce",
"Tehnicar PTT saobracaja",
"Tehnicar unutrasnjeg transporta",
"Transportni komercijalista",
"Kulinarski tehnicar",
"Ugostiteljski tehnicar",
"Ekonomski tehnicar",
"Finansijski tehnicar",
"Carinski tehnicar",
"Ginekolosko-akuserska sestra",
"Zubni tehnicar",
"Medicinska sestra - vaspitac",
"Pedijatrijska sestra - tehnicar",
"Sanitarno-ekoloski tehnicar",
"Scenski masker i vlasuljar"});
            }
            else if (comboBoxprofiltip.SelectedItem.ToString() == "Umetnicka")
            {
                comboBoxprofilnaziv3.Items.AddRange(new string[] { "Soleđo", "Harmonija" });
            }
        }

        private void buttonprofilobrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfil.SelectedRows.Count > 0)
            {
                DataGridViewRow izabraniRed = dataGridViewProfil.SelectedRows[0];

                if (izabraniRed.IsNewRow) return;

                int selektovaniIndeks = izabraniRed.Index;
                if (selektovaniIndeks < profili.Count)
                {
                    profili.RemoveAt(selektovaniIndeks);
                }
                dataGridViewProfil.Rows.RemoveAt(selektovaniIndeks);
                Sacuvajp();
            }
            textBoxprofil.Text = "";
            comboBoxprofiljezik.SelectedIndex = -1;
            comboBoxprofiltip.SelectedIndex = -1;
            comboBoxprofilnaziv1.SelectedIndex = -1;
            comboBoxprofilnaziv2.SelectedIndex = -1;
            comboBoxprofilnaziv3.SelectedIndex = -1;
        }

        private void buttonprofilsacuvaj_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.profil = textBoxprofil.Text;
            profil.jezik = comboBoxprofiljezik.Text;
            profil.tip = comboBoxprofiltip.Text;
            profil.naziv1 = comboBoxprofilnaziv1.Text;
            profil.naziv2 = comboBoxprofilnaziv2.Text;
            profil.naziv3 = comboBoxprofilnaziv3.Text;

            dataGridViewProfil.Rows.Add(profil.profil, profil.tip, profil.jezik, profil.naziv1, profil.naziv2, profil.naziv3);
            profili.Add(profil);
            Sacuvajp();

            textBoxprofil.Text = "";
            comboBoxprofiljezik.SelectedIndex = -1;
            comboBoxprofiltip.SelectedIndex = -1;
            comboBoxprofilnaziv1.SelectedIndex = -1;
            comboBoxprofilnaziv2.SelectedIndex = -1;
            comboBoxprofilnaziv3.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewUcenici.ColumnCount = 9;
            dataGridViewUcenici.Columns[0].Name = "Ime";
            dataGridViewUcenici.Columns[1].Name = "Prezime";
            dataGridViewUcenici.Columns[2].Name = "skola";
            dataGridViewUcenici.Columns[3].Name = "Odeljenje";
            dataGridViewUcenici.Columns[4].Name = "Tip mature";
            dataGridViewUcenici.Columns[5].Name = "Jezik";
            dataGridViewUcenici.Columns[6].Name = "Prvi predmet";
            dataGridViewUcenici.Columns[7].Name = "Drugi predmet";
            dataGridViewUcenici.Columns[8].Name = "Treci predmet";

            dataGridViewProfil.ColumnCount = 6;
            dataGridViewProfil.Columns[0].Name = "Naziv";
            dataGridViewProfil.Columns[1].Name = "Tip mature";
            dataGridViewProfil.Columns[2].Name = "Jezik";
            dataGridViewProfil.Columns[3].Name = "Prvi predmet";
            dataGridViewProfil.Columns[4].Name = "Drugi predmet";
            dataGridViewProfil.Columns[5].Name = "Treci predmet";

            if (File.Exists("profili.csv"))
            {
                string[] linije1 = File.ReadAllLines("profili.csv");

                foreach (string linija1 in linije1)
                {
                    if (string.IsNullOrWhiteSpace(linija1)) continue;
                    string[] podaci1 = linija1.Split(';');

                    if (podaci1.Length == 6)
                    {
                        dataGridViewProfil.Rows.Add(podaci1[0], podaci1[1], podaci1[2], podaci1[3], podaci1[4], podaci1[5]);
                        Profil p = new Profil();
                        p.profil = podaci1[0];
                        p.tip = podaci1[1];
                        p.jezik = podaci1[2];
                        p.naziv1 = podaci1[3];
                        p.naziv2 = podaci1[4];
                        p.naziv3 = podaci1[5];
                        profili.Add(p);
                    }
                }
            }
            if (File.Exists("ucenici.csv"))
            {
                string[] linije = File.ReadAllLines("ucenici.csv");

                foreach (string linija in linije)
                {
                    if (string.IsNullOrWhiteSpace(linija)) continue;
                    string[] podaci = linija.Split(';');

                    if (podaci.Length == 9)
                    {
                        dataGridViewUcenici.Rows.Add(podaci[0], podaci[1], podaci[2], podaci[3], podaci[4], podaci[5], podaci[6], podaci[7], podaci[8]);
                        Ucenik u = new Ucenik();
                        u.ime = podaci[0];
                        u.prezime = podaci[1];
                        u.skola = podaci[2];
                        u.odeljenje = podaci[3];
                        u.tip = podaci[4];
                        u.jezik = podaci[5];
                        u.naziv1 = podaci[6];
                        u.naziv2 = podaci[7];
                        u.naziv3 = podaci[8];

                        ucenici.Add(u);
                    }
                }
            }
            OsveziComboBoxProfila();
            cmbIzaberiProfil.SelectedIndex = 0;
            dataGridViewUcenici.ClearSelection();
        }
        private int selektovaniIndeksUcenika = -1;
        private void dataGridViewUcenici_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUcenici.SelectedRows.Count == 0) return;

            DataGridViewRow izabraniRed = dataGridViewUcenici.SelectedRows[0];
            if (izabraniRed.IsNewRow || izabraniRed.Cells[0].Value == null) return;

            int x = izabraniRed.Index;
            if (x >= ucenici.Count) return;

            selektovaniIndeksUcenika = x;
            buttonSacuvajIzmenu.Enabled = true;

            Ucenik u = ucenici[x];

            textBoxime.Text = u.ime;
            textBoxprezime.Text = u.prezime;
            comboBoxskola.SelectedIndex = comboBoxskola.FindStringExact(u.skola);
            comboBoxodeljenje.SelectedIndex = comboBoxodeljenje.FindStringExact(u.odeljenje);
            comboBoxjezik.SelectedIndex = comboBoxjezik.FindStringExact(u.jezik);
            comboBoxtip.SelectedIndex = comboBoxtip.FindStringExact(u.tip);
            comboBoxnaziv1.SelectedIndex = comboBoxnaziv1.FindStringExact(u.naziv1);
            comboBoxnaziv2.SelectedIndex = comboBoxnaziv2.FindStringExact(u.naziv2);
            comboBoxnaziv3.SelectedIndex = comboBoxnaziv3.FindStringExact(u.naziv3);
        }
        private void buttonSacuvajIzmenu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxime.Text) ||
                string.IsNullOrWhiteSpace(textBoxprezime.Text) ||
                comboBoxskola.SelectedIndex == -1 ||
                comboBoxodeljenje.SelectedIndex == -1 ||
                comboBoxjezik.SelectedIndex == -1 ||
                comboBoxtip.SelectedIndex == -1 ||
                comboBoxnaziv1.SelectedIndex == -1 ||
                comboBoxnaziv2.SelectedIndex == -1 ||
                comboBoxnaziv3.SelectedIndex == -1)
            {
                MessageBox.Show("Sva polja moraju biti popunjena!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selektovaniIndeksUcenika < 0 || selektovaniIndeksUcenika >= ucenici.Count) return;

            Ucenik u = ucenici[selektovaniIndeksUcenika];
            u.ime = textBoxime.Text;
            u.prezime = textBoxprezime.Text;
            u.skola = comboBoxskola.Text;
            u.odeljenje = comboBoxodeljenje.Text;
            u.jezik = comboBoxjezik.Text;
            u.tip = comboBoxtip.Text;
            u.naziv1 = comboBoxnaziv1.Text;
            u.naziv2 = comboBoxnaziv2.Text;
            u.naziv3 = comboBoxnaziv3.Text;

            var red = dataGridViewUcenici.Rows[selektovaniIndeksUcenika];
            red.Cells[0].Value = u.ime;
            red.Cells[1].Value = u.prezime;
            red.Cells[2].Value = u.skola;
            red.Cells[3].Value = u.odeljenje;
            red.Cells[4].Value = u.tip;
            red.Cells[5].Value = u.jezik;
            red.Cells[6].Value = u.naziv1;
            red.Cells[7].Value = u.naziv2;
            red.Cells[8].Value = u.naziv3;

            Sacuvaju();

            selektovaniIndeksUcenika = -1;
            buttonSacuvajIzmenu.Enabled = false;
            dataGridViewUcenici.ClearSelection();

            textBoxime.Text = "";
            textBoxprezime.Text = "";
            comboBoxodeljenje.SelectedIndex = -1;
            comboBoxskola.SelectedIndex = -1;
            comboBoxjezik.SelectedIndex = -1;
            comboBoxtip.SelectedIndex = -1;
            comboBoxnaziv1.SelectedIndex = -1;
            comboBoxnaziv2.SelectedIndex = -1;
            comboBoxnaziv3.SelectedIndex = -1;
            cmbIzaberiProfil.SelectedIndex = 0;
        }

        private void OsveziComboBoxProfila()
        {
            cmbIzaberiProfil.Items.Clear();

            cmbIzaberiProfil.Items.Add("---");

            foreach (DataGridViewRow red in dataGridViewProfil.Rows)
            {
                string nazivProfila = red.Cells[0].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(nazivProfila))
                {
                    cmbIzaberiProfil.Items.Add(nazivProfila);
                }
            }
            cmbIzaberiProfil.SelectedIndex = 0;
        }
        private void cmbIzaberiProfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbIzaberiProfil.Focused) return;
            if (cmbIzaberiProfil.SelectedIndex == -1) return;

            string izabraniProfil = cmbIzaberiProfil.SelectedItem.ToString();

            if (izabraniProfil == "---")
            {
                comboBoxtip.SelectedIndex = -1;
                comboBoxjezik.SelectedIndex = -1;
                comboBoxnaziv1.SelectedIndex = -1;
                comboBoxnaziv2.SelectedIndex = -1;
                comboBoxnaziv3.SelectedIndex = -1;
                return;
            }

            Profil nadjenProfil = profili.FirstOrDefault(p => p.profil.Trim() == izabraniProfil.Trim());

            if (nadjenProfil == null) return;

            comboBoxtip.SelectedIndex = comboBoxtip.FindStringExact(nadjenProfil.tip);

            comboBoxjezik.SelectedIndex = comboBoxjezik.FindStringExact(nadjenProfil.jezik);
            comboBoxnaziv1.SelectedIndex = comboBoxnaziv1.FindStringExact(nadjenProfil.naziv1);
            comboBoxnaziv2.SelectedIndex = comboBoxnaziv2.FindStringExact(nadjenProfil.naziv2);
            comboBoxnaziv3.SelectedIndex = comboBoxnaziv3.FindStringExact(nadjenProfil.naziv3);
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                OsveziComboBoxProfila();
            }
        }
    }
}
