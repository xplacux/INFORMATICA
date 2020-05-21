using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placucci.Gabriele._4H.Rubrica


{
    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Citta { get; set; }
        public int Cap { get; set; }
        public string NTelefono { get; set; }
        public int Eta { get { return DateTime.Now.Year - _dataNascita.Year; } }

        private DateTime _dataNascita;

        //Costruttore di default
        public Persona()
        {
            Nome = "";
            Cognome = "";
            Citta = "";
            NTelefono = "";
        }

        //Costruttore standard
        public Persona(string riga)
        {

            string[] elemeti = riga.Split(';');
            if (elemeti.Length != 6)
            {
                throw new Exception("ERORE:riga csv non valida");
            }
            Nome = elemeti[0];
            Cognome = elemeti[1];
            Citta = elemeti[2];
            Cap = Convert.ToInt16(elemeti[3]);
            NTelefono = elemeti[4];
            _dataNascita = Convert.ToDateTime(elemeti[5]);


        }
        //metodo molto utile
        public override string ToString()
        {
            return $"{Nome};{Cognome};{Citta};{Cap};{NTelefono};{Eta}";
        }
    }
}