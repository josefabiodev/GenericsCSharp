using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public class ServicoDeImpressao<T>
    {
        private T[] _valores = new T[10];
        private int _contador = 0;

        public void AdiconarValor(T valor) 
        {
            if(_contador == 10)
                throw new InvalidOperationException("Serviço de impressão Full.");

            _valores[_contador] = valor;
            _contador++;
        }

        public T PrimeiroElemento() 
        {
            if(_contador == 0)
                throw new InvalidOperationException("Serviço de impressão está vazio.");

            return _valores.First();
        }

        public void Imprimir() 
        {
            Console.Write("[");
            for (int i =0; i < _contador - 1; i++)
            {
                Console.Write(_valores[i] + ", ");
            }
            if (_contador > 0) 
            {
                Console.Write(_valores[_contador - 1]);
            }
            Console.WriteLine("]");
        }
    }    
}