using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeafioFramework.Response
{
    public class ResponseNumero : ResponseBase
    {
        public int Numero { get; set; }
        public List<int> Divisores { get; set; }
        public List<int> NumerosPrimos { get; set; }
        public string DivisoresEmLinha => EmLinha(Divisores);
        public string NumerosPrimosEmLinha => EmLinha(NumerosPrimos);

        public string EmLinha(List<int> lista)
        {
            var result = "";
            for (int i = 0; i < lista.Count; i++)
            {
                result += lista.Count != i + 1 ? lista[i] + ", " : lista[i].ToString();
            }
            return result;
        }

        public static ResponseNumero DivisoresEPrimos(int num)
        {
            var divisores = new List<int>();
            var primos = new List<int>();

            for (var NumeroDivisor = 1; NumeroDivisor <= num; NumeroDivisor++)
            {
                if (num % NumeroDivisor == 0)
                {
                    divisores.Add(NumeroDivisor);
                }
            }
            foreach (var item in divisores)
            {
                int cont = 0;
                for (int i = 1; i <= item; i++)
                {
                    if (item % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    primos.Add(item);
                }
            }
            var response = new ResponseNumero
            {
                Numero = num,
                Divisores = divisores,
                NumerosPrimos = primos
            };
            return response;
        }
    }
}
