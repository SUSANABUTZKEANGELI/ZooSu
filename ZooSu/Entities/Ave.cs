namespace Aula19062024.Entities
{
    internal class Ave : Animal, ICapacidadeVoar, ICapacidadeNadar
    {
        public bool CapacidadeVoar { get; set; }

        public bool CapacidadeNadar { get; set; }

        public int QtMetrosMergulho { get; set; }

        public void LevantarVoo()
        {
            if (CapacidadeVoar)
            {
                Console.WriteLine($"{NomeEspecie} - {NomeSubEspecie} voa.");
            }
            else
            {
                Console.WriteLine($"{NomeEspecie} - {NomeSubEspecie} não voa.");
            }
        }

        public void Pousar()
        {
            if (CapacidadeVoar)
            {
                Console.WriteLine($"{NomeEspecie} - {NomeSubEspecie} pousa.");
            }
            else
            {
                Console.WriteLine($"{NomeEspecie} - {NomeSubEspecie} não pousa.");
            }
        }
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
