using System;
using System.Collections.Generic;
using System.Text;

namespace ArchivoEventos
{
    class Evento
    {
        private string _cTituloEvento;
        private DateTime _dtFechaEvento;

        public string Titulo
        {
            get { return _cTituloEvento; }
            set { this._cTituloEvento = value; }
        }

        public DateTime Fecha
        {
            get { return _dtFechaEvento; }
            set { this._dtFechaEvento = value; }
        }

        public Evento(string cTituloEvento, DateTime dtFechaEvento)
        {
            this.Titulo = cTituloEvento;
            this.Fecha = dtFechaEvento;
        }

        ~Evento(){

        }

        /// <summary>
        /// Método que retorna la cantidad de días de diferencia
        /// entre la fecha de hoy y la fecha del evento
        /// </summary>
        /// <returns></returns>
        public int DiferenciaDeDias()
        {
            int iDiferenciaDeDias = 0;
            int iIndiceComparacion = DateTime.Compare(DateTime.Now, this.Fecha);
            if(iIndiceComparacion < 0)
            {
                iDiferenciaDeDias = (int)this.Fecha.Subtract(DateTime.Now).TotalDays;
            }else if(iIndiceComparacion > 0)
            {
                iDiferenciaDeDias = (int)DateTime.Now.Subtract(this.Fecha).TotalDays;
            }
            else
            {
                Console.WriteLine("Es Hoy! Es Hoy!");
            }
            return iDiferenciaDeDias;
        }
    }
}
