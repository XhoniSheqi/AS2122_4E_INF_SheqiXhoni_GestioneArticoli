namespace AS2122_4E_INF_SheqiXhoni_GestioneArticoli_Library
{
    public class Articolo
    {
        string codice;
        string descrizione;
        string unitaDiMisura;
        string prezzo;

        public string Codice {get{return codice;} }
        public string Descrizione { get { return descrizione; } }
        public string UnitaDiMisura { get { return unitaDiMisura; } }
        public string Prezzo { get { return prezzo; } }

        public Articolo(string codice, string descrizione, string unitaDiMisura, string prezzo)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitaDiMisura = unitaDiMisura;
            this.prezzo = prezzo;
        }

        public override string ToString() {
            return $"{descrizione} {unitaDiMisura} {prezzo} ({codice})";
        }
    }
}