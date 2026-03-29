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
                "Treća beogradska gimnazija",
                "Četvrta beogradska gimnazija",
                "Peta beogradska gimnazija",
                "Šesta beogradska gimnazija",
                "Sedma beogradska gimnazija",
                "Osma beogradska gimnazija",
                "Deveta gimnazija Mihailo Petrović Alas",
                "Deseta gimnazija Mihajlo Pupin",
                "Trinaesta beogradska gimnazija",
                "Četrnaesta beogradska gimnazija",
                "Petnaesta beogradska gimnazija",
                "Matematička gimnazija",
                "Filološka gimnazija",
                "Prva ekonomska škola",
                "Druga ekonomska škola",
                "Pravno-poslovna škola Beograd",
                "Elektrotehnička škola Nikola Tesla",
                "Elektrotehnička škola Rade Končar",
                "Vazduhoplovna akademija",
                "Medicinska škola Zvezdara",
                "Medicinska škola Beograd",
                "Srednja farmaceutsko-fizioterapeutska škola",
                "Građevinska tehnička škola Branko Žeželj",
                "Arhitektonska tehnička škola",
                "Mašinska škola Radoje Dakić",
                "Saobraćajno-tehnička škola Zemun",
                "PTT škola",
                "Trgovačka škola Beograd",
                "Ugostiteljsko-turistička škola",
                "Škola za dizajn",
                "Tehnoart Beograd",
                "Hemijsko-prehrambena tehnološka škola",
                "Grafička škola"
            });

            comboBoxtip.Items.AddRange(new string[]
            {
                "Opšta",
                "Stručna",
                "Umetnička"
            });

            comboBoxprofiltip.Items.AddRange(new string[]
            {
                "Opšta",
                "Stručna",
                "Umetnička"
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
                    string linija = $"{p.profil};{p.tip};{p.naziv1};{p.naziv2};{p.naziv3};{p.jezik}";
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

            if (comboBoxtip.SelectedItem.ToString() == "Opšta")
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
            else if (comboBoxtip.SelectedItem.ToString() == "Stručna")
            {
                comboBoxnaziv3.Items.AddRange(new string[] { "Zootehnicar",
                                                            "Tehnicar za biotehnologiju",
                                                            "Tehnicar poljoprivredne tehnike",
                                                            "Tehnicar hortikuture",
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
                                                            "Elektrotehnicar za termicke i rashladne uredjaje",
                                                            "Elektrotehnicar informacionih tehnologija",
                                                            "Elektrotehnicar procesnog upravljanja",
                                                            "Elektrotehnicar racunara",
                                                            "Tehnicar graficke dorade",
                                                            "Tehnicar za zastitu zivotne sredine",
                                                            "Tehnicar za industrijsku farmaceutsku tehnologiju",
                                                            "Tehnicar stampе",
                                                            "Fotograf",
                                                            "Hemijski laborant",
                                                            "Hemijsko-tehnoloski tehnicar",
                                                            "Tekstilni tehnicar",
                                                            "Gradjevinski tehnicar za laboratorijska ispitivanja",
                                                            "Gradjevinski tehnicar za hidrogradnju",
                                                            "Izvodjac instalaterskih i zavrsnih gradjevinskih radova",
                                                            "Nauticki tehnicar - recni smer",
                                                            "Saobracajno-transportni tehnicar",
                                                            "Tehnicar vuce",
                                                            "Tehnicar PTT saobracaja",
                                                            "Tehnicar unutrasnjeg transporta",
                                                            "Transportni komercialista",
                                                            "Kulinarskі tehnicar",
                                                            "Ugostiteljski tehnicar",
                                                            "Ekonomski tehnicar",
                                                            "Finansijski tehnicar",
                                                            "Carinski tehnicar",
                                                            "Ginekolosko-akuserska sestra",
                                                            "Zubni tehnicar",
                                                            "Medicinska sestra - vaspitac",
                                                            "Pedijatrijska sestra - tehnicar",
                                                            "Sanitarno-ekoloski tehnicar",
                                                            "Scenski masker i vlasuljаr"});
            }

            else if (comboBoxtip.SelectedItem.ToString() == "Umetnička")
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
        }

        private void buttonobrisi_Click(object sender, EventArgs e)
        {

            if(dataGridViewUcenici.SelectedRows.Count > 0)
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
            textBoxime.Text = "";
            textBoxprezime.Text = "";
            comboBoxodeljenje.SelectedIndex = -1;
            comboBoxjezik.SelectedIndex = -1;
            comboBoxtip.SelectedIndex = -1;
            comboBoxnaziv1.SelectedIndex = -1;
            comboBoxnaziv2.SelectedIndex = -1;
            comboBoxnaziv3.SelectedIndex = -1;
            comboBoxskola.SelectedIndex = -1;
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

            if (comboBoxprofiltip.SelectedItem.ToString() == "Opšta")
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
            else if (comboBoxprofiltip.SelectedItem.ToString() == "Stručna")
            {
                comboBoxprofilnaziv3.Items.AddRange(new string[] { "Zootehnicar",
                                                            "Tehnicar za biotehnologiju",
                                                            "Tehnicar poljoprivredne tehnike",
                                                            "Tehnicar hortikuture",
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
                                                            "Elektrotehnicar za termicke i rashladne uredjaje",
                                                            "Elektrotehnicar informacionih tehnologija",
                                                            "Elektrotehnicar procesnog upravljanja",
                                                            "Elektrotehnicar racunara",
                                                            "Tehnicar graficke dorade",
                                                            "Tehnicar za zastitu zivotne sredine",
                                                            "Tehnicar za industrijsku farmaceutsku tehnologiju",
                                                            "Tehnicar stampе",
                                                            "Fotograf",
                                                            "Hemijski laborant",
                                                            "Hemijsko-tehnoloski tehnicar",
                                                            "Tekstilni tehnicar",
                                                            "Gradjevinski tehnicar za laboratorijska ispitivanja",
                                                            "Gradjevinski tehnicar za hidrogradnju",
                                                            "Izvodjac instalaterskih i zavrsnih gradjevinskih radova",
                                                            "Nauticki tehnicar - recni smer",
                                                            "Saobracajno-transportni tehnicar",
                                                            "Tehnicar vuce",
                                                            "Tehnicar PTT saobracaja",
                                                            "Tehnicar unutrasnjeg transporta",
                                                            "Transportni komercialista",
                                                            "Kulinarskі tehnicar",
                                                            "Ugostiteljski tehnicar",
                                                            "Ekonomski tehnicar",
                                                            "Finansijski tehnicar",
                                                            "Carinski tehnicar",
                                                            "Ginekolosko-akuserska sestra",
                                                            "Zubni tehnicar",
                                                            "Medicinska sestra - vaspitac",
                                                            "Pedijatrijska sestra - tehnicar",
                                                            "Sanitarno-ekoloski tehnicar",
                                                            "Scenski masker i vlasuljаr"});
            }
            else if (comboBoxprofiltip.SelectedItem.ToString() == "Umetnička")
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
            dataGridViewUcenici.Columns[2].Name = "Škola";
            dataGridViewUcenici.Columns[3].Name = "Odeljenje";
            dataGridViewUcenici.Columns[4].Name = "Tip mature";
            dataGridViewUcenici.Columns[5].Name = "Jezik";
            dataGridViewUcenici.Columns[6].Name = "Prvi predmet";
            dataGridViewUcenici.Columns[7].Name = "Drugi predmet";
            dataGridViewUcenici.Columns[8].Name = "Treći predmet";

            dataGridViewProfil.ColumnCount = 6;
            dataGridViewProfil.Columns[0].Name = "Naziv";
            dataGridViewProfil.Columns[1].Name = "Tip mature";
            dataGridViewProfil.Columns[2].Name = "Jezik";
            dataGridViewProfil.Columns[3].Name = "Prvi predmet";
            dataGridViewProfil.Columns[4].Name = "Drugi predmet";
            dataGridViewProfil.Columns[5].Name = "Treći predmet";

            if (File.Exists("profili.csv"))
            {
                string[] linije1 = File.ReadAllLines("profili.csv");

                foreach (string linija1 in linije1)
                {
                    if (string.IsNullOrWhiteSpace(linija1)) continue;
                    string[] podaci1 = linija1.Split(';');

                    if (podaci1.Length == 6)
                    {
                        dataGridViewProfil.Rows.Add(podaci1);
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
                        dataGridViewUcenici.Rows.Add(podaci);
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
        }
        private void dataGridViewUcenici_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUcenici.SelectedRows.Count > 0)
            {
                DataGridViewRow izabraniRed = dataGridViewUcenici.SelectedRows[0];
                if (izabraniRed.Cells[0].Value != null)
                {
                    textBoxime.Text = izabraniRed.Cells[0].Value.ToString();
                    textBoxprezime.Text = izabraniRed.Cells[1].Value.ToString();
                    comboBoxskola.Text = izabraniRed.Cells[2].Value.ToString();
                    comboBoxodeljenje.Text = izabraniRed.Cells[3].Value.ToString();
                    comboBoxtip.Text = izabraniRed.Cells[4].Value.ToString();
                    comboBoxjezik.Text = izabraniRed.Cells[5].Value.ToString();
                    comboBoxnaziv1.Text = izabraniRed.Cells[6].Value.ToString();
                    comboBoxnaziv2.Text = izabraniRed.Cells[7].Value.ToString();
                    comboBoxnaziv3.Text = izabraniRed.Cells[8].Value.ToString();
                }
            }
        }

        private void OsveziComboBoxProfila()
        {
            cmbIzaberiProfil.Items.Clear();

            foreach (DataGridViewRow red in dataGridViewProfil.Rows)
            {
                string nazivProfila = red.Cells[0].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(nazivProfila))
                {
                    cmbIzaberiProfil.Items.Add(nazivProfila);
                }
            }
        }
        private void cmbIzaberiProfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIzaberiProfil.SelectedIndex == -1) return;

            string izabraniProfil = cmbIzaberiProfil.SelectedItem.ToString();
            foreach (DataGridViewRow row in dataGridViewProfil.Rows)
            {
                string trenutniProfil = row.Cells[0].Value?.ToString();
                if (trenutniProfil == izabraniProfil)
                {
                    string tipmature = row.Cells["Tip mature"].Value?.ToString();

                    if (!string.IsNullOrWhiteSpace(tipmature))
                    {
                        comboBoxtip.SelectedItem = tipmature;
                    }
                    string jezikmature = row.Cells["Jezik"].Value?.ToString();

                    if (!string.IsNullOrWhiteSpace(jezikmature))
                    {
                        comboBoxtip.SelectedItem = jezikmature;
                    }
                    string prvimature = row.Cells["Prvi predmet"].Value?.ToString();

                    if (!string.IsNullOrWhiteSpace(prvimature))
                    {
                        comboBoxtip.SelectedItem = prvimature;
                    }
                    string drugimature = row.Cells["Drugi predmet"].Value?.ToString();

                    if (!string.IsNullOrWhiteSpace(drugimature))
                    {
                        comboBoxtip.SelectedItem = drugimature;
                    }
                    string trecimature = row.Cells["Treci predmet"].Value?.ToString();

                    if (!string.IsNullOrWhiteSpace(trecimature))
                    {
                        comboBoxtip.SelectedItem = trecimature;
                    }
                    break;
                }
            }
        }
        private void dataGridViewProfil_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProfil.SelectedRows.Count > 0)
            {
                DataGridViewRow izabraniRed = dataGridViewUcenici.SelectedRows[0];
                if (izabraniRed.Cells[0].Value != null)
                {
                    textBoxprofil.Text = izabraniRed.Cells[0].Value.ToString();
                    comboBoxtip.Text = izabraniRed.Cells[1].Value.ToString();
                    comboBoxjezik.Text = izabraniRed.Cells[2].Value.ToString();
                    comboBoxnaziv1.Text = izabraniRed.Cells[3].Value.ToString();
                    comboBoxnaziv2.Text = izabraniRed.Cells[4].Value.ToString();
                    comboBoxnaziv3.Text = izabraniRed.Cells[5].Value.ToString();
                }
            }
        }
    }
}
