using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Pessoa : IAcasalamento
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public double Tamanho { get; set; }
        public string CorDaPele { get; set; }
        public int Idade { get; set; }

        public void Acordar() { }
        public void FazerExercicio() { }
        public void Comer() { }
        public void Dormir() { }
        public void Trabalhar() { }

        public void Trepar()
        {
            throw new NotImplementedException();
        }
    }
}
