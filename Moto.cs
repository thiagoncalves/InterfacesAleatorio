using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Moto : IAutomovel
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Renavam { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }

        public void AbrirBagageiro() { }

        public void AbrirPortaMalas()
        {
            throw new NotImplementedException();
        }

        public void Acelerar()
        {
            throw new NotImplementedException();
        }

        public void Empinar() { }

        public void Frear()
        {
            throw new NotImplementedException();
        }

        public void LigarLanterna()
        {
            throw new NotImplementedException();
        }
    }
}
