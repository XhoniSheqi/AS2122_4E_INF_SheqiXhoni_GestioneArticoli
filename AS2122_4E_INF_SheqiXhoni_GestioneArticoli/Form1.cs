using AS2122_4E_INF_SheqiXhoni_GestioneArticoli_Library;
namespace AS2122_4E_INF_SheqiXhoni_GestioneArticoli
{
    public partial class Form1 : Form
    {
        Dictionary<string , Articolo> articoli;
        public Form1()
        {
            InitializeComponent();
            articoli = new Dictionary<string , Articolo>();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (articoli.ContainsKey(txtCodice.Text))
            {
                articoli[txtCodice.Text] = new Articolo(txtCodice.Text, cmbUnitaMisura.Text, txtDescrizione.Text, txtPrezzo.Text);
            }
            else
            {
                articoli.Add(txtCodice.Text, new Articolo(txtCodice.Text, cmbUnitaMisura.Text, txtDescrizione.Text, txtPrezzo.Text));
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string , Articolo> a in articoli) {
                lstVisualizza.Items.Add(a.ToString());
            }
        }
    }
}