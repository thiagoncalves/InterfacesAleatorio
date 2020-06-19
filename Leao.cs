using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Leao : IFelinos, IAcasalamento
    {
        public string Sexo { get; set; }
        public int QtdeFilhotes { get; set; }
        public double Tamanho { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }

        public void Cacar()
        {
            throw new NotImplementedException();
        }

        public void Comer()
        {
            throw new NotImplementedException();
        }

        public void Correr()
        {
            throw new NotImplementedException();
        }

        public void Dormir()
        {
            throw new NotImplementedException();
        }

        public void Pular()
        {
            throw new NotImplementedException();
        }

        public void Trepar()
        {
            throw new NotImplementedException();
        }
    }
}
