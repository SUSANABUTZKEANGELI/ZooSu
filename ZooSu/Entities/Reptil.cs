namespace Aula19062024.Entities
{
    internal class Reptil : Animal, ICapacidadeNadar
    {
        public bool CapacidadeNadar { get; set; }

        public int QtMetrosMergulho { get; set; }

        public void Mergulhar()
        {
            if (CapacidadeNadar)
            {
                Console.WriteLine($"{NomeEspecie} - {NomeSubEspecie} nada e mergulha até {QtMetrosMergulho} metros de profundidade.");
            }
            else
            {
                Console.WriteLine($"{NomeEspecie} - {NomeSubEspecie} não nada.");
            }
        }
    }
}
