using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4E_INF_MiloLuca_GestioneArticoli.Library
{
    public class Articolo
    {
        public string Codice { get; set; }
        public string Descrizione { get; set; }

        public UnitàMisura UnitaMisura { get; set; }

        public decimal Prezzo { get; set; }

        public Articolo(string codice, string descrizione, UnitàMisura unitàMisura, decimal prezzo)
        {
            Codice = codice;
            Descrizione = descrizione;
            this.UnitaMisura = unitàMisura;
            if (prezzo >= 0)
            {
                Prezzo = (decimal)prezzo;
            }
            else
            {
                throw new ArgumentException;
            }
        }

        public Articolo(string codice, string descrizione, string unitàMisura, decimal prezzo)
        {
            Codice = codice;
            Descrizione = descrizione;

            // DA FIXARE!!!!!
            this.UnitaMisura = UnitàMisura.NR;
            if (prezzo >= 0)
            {
                Prezzo = (decimal)prezzo;
            }
            else
            {
                throw new ArgumentException;
            }
        }

        public Articolo(string codice, string descrizione, string unitàMisura, double prezzo)
        {
            Codice = codice;
            Descrizione = descrizione;

            // DA FIXARE!!!!!
            this.UnitaMisura = UnitàMisura.NR;
            if (prezzo >= 0) {
                Prezzo = (decimal)prezzo;
            } else {
                throw new ArgumentException;
            }
        }

        public Articolo(string codice, string descrizione, UnitàMisura unitàMisura, double prezzo)
        {
            Codice = codice;
            Descrizione = descrizione;
            this.UnitaMisura = unitàMisura;
            if (prezzo >= 0)
            {
                Prezzo = (decimal)prezzo;
            }
            else
            {
                throw new ArgumentException;
            }
        }

        public override string ToString()
        {
            return $"{Descrizione} {UnitaMisura} {Prezzo} ({Codice})";
        }

        public enum UnitàMisura
        {
            NR,
            KG,
            Q,
            T
        }
    }
}