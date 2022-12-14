using System;

namespace oop._01Heranca.ClasseBase
{
    public class MeioTransporte
    {
        //Estado
        public int CapacidadeMax { get; set; }

        //Comportamento
        public void Locomover()
        {
            Console.WriteLine("Objeto está se locomovendo");
        }
    }
}