namespace UDatentypen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            string UserName, Stra�e, Stadt;
            int HausNr, PostLeitzahl, Age;
            double Gehalt;

            UserName = "Hannes Kasel";
            Stra�e = "K�rntnerstra�e";
            HausNr = 33;
            PostLeitzahl = 6020;
            Stadt = "Elbental";
            Age = 34;
            Gehalt = 0.0;

            LblAusgabe.Text =
                $"Adresse:\n" +
                $"{UserName}\n" +
                $"{Stra�e} {HausNr}\n" +
                $"{PostLeitzahl} {Stadt}\n\n" +
                $"Alter: {Age}\n" +
                $"Gehalt: {Gehalt} �";
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}