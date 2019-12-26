using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArchivoEventos
{
    class LogicaEventos
    {
        public List<Evento> ObtenerListaDeEventos(string cNombreArchivo)
        {
            string cRutaHome = AppDomain.CurrentDomain.BaseDirectory;
            string cRutaArchivo = cRutaHome + "Archivo\\" + cNombreArchivo;
            using (FileStream _oFileStream = new FileStream(cRutaArchivo, FileMode.Open, FileAccess.Read))
            {

            }
                return null;
        }

        public DateTime ConvertirTextoEnFecha(string _cTextoFechaHora)
        {
            string[] lstFechaHoraAuxiliar = _cTextoFechaHora.Split("-");
            //dd/mm/yyyy
            string[] lstDiaMesAnio = lstFechaHoraAuxiliar[0].Split("/");
            string[] lstHoraMinutoSegundo = lstFechaHoraAuxiliar[1].Split(":");
            return DateTime.MinValue;
        }
    }
}
