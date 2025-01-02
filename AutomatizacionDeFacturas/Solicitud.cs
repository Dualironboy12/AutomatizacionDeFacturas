using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace AutomatizacionDeFacturas
{
    public class Solicitud
    {
        public string Paciente {  get; set; }
        public string RazonSocial { get; set; }
        public string RFC {  get; set; }
        public int Regimen { get; set; }
        public string CFDI { get; set; }
        public string Correo { get; set; }
        public int CP { get; set; }
        public DateOnly Fecha { get; set; }
        public double Monto { get; set; }
        public string FormaDePago { get; set; }
        public string Concepto { get; set; }
        public long Telefono { get; set; }
        public string Estado { get; set; }
    }
}
