using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitrotti.Placucci._4H.Tris
{
    class Giocatore
    {
        private int NMosse;                         //Se il MOD di NMosse è 0(pari) allora inizierà il g0 (X), fatta la mossa NMosse 
                                                    //diventerà dispari   
        private int Turno;                          //|TURNO VA A VERIFICARE SE IL MODULO DI NMosse è 0| {Turno = Mod(NMosse)}
                                                    //Se (Turno) MOD NMosse è 0(pari) deve giocare (g0) con X. 
                                                    //Se (Turno) MOD NMosse NON è 0(dispari) deve giocare (g1) con O.
        

        public Giocatore()
        {
            NMosse = 0;
            Turno = 0;
           
        }

        private void Mossa()
        {

        }
    }
}
