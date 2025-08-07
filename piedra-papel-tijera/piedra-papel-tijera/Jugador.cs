using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piedra_papel_tijera
{
    internal class Jugador
    {
        private string nombre;

        private int puntos;
        private double porcpapel=0;
        private double porcpiedra=0;
        private double porctijera=0;
        static Random elegir = new Random();

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }
        public Jugador(string nombre) 
        {
            this.nombre = nombre;
            puntos = 0;
        }

        public void Jugar(int elemento) 
        {
            switch (elemento) 
            {
                case 0:
                    porcpiedra++;
                    break;

                    case 1:
                    porcpapel++;
                    break;

                    case 2:
                    porctijera++;
                    break;

                default:
                    
                    break;
                
                    
            }
        }
              
    }
}
