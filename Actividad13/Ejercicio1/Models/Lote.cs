using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_13.Models
{
    internal class Lote
    {
        int numero;
        double[] medidas = new double[100];
        int cantidad=0;

        public Lote() { }

        public double VerMedida(int idx)
        { 
            return medidas[idx];
        }
        public void RegistrarMedida(double valor)
        {
            medidas[cantidad] = valor;
            cantidad++;
        }

        public int GetCantidad()
        {
           return cantidad;
        }

        public int GetNumero()
        { return numero; }

        public void SetNumero(int valor) 
        { numero = valor; }
    }
}
