using System;
namespace ListaDogApp
{
    public class Dog
    {
        public string nome { get; set; }
        public string raca { get; set; }
        public string idade { get; set; }

        public string DogListaIdade
        {
            get
            {
                return nome + " , " + idade;
            }
        }
        public Dog()
        {
        }
    }
}
