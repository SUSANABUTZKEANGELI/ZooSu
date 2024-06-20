using Aula19062024.Entities;

    List<Animal> zoo = new List<Animal>
        {
            new Ave { 
                NomeEspecie = "Ave", 
                NomeSubEspecie = "Papagaio",
                CapacidadeVoar = true 
            },
            new Mamifero {
                NomeEspecie = "Mamifero",
                NomeSubEspecie = "Hipopotamo",
                CapacidadeNadar = true,
                CapacidadeVoar = false,
                QtMetrosMergulho = 1
            },
            new Mamifero {
                NomeEspecie = "Mamifero",
                NomeSubEspecie = "Morcego",
                CapacidadeNadar = true,
                CapacidadeVoar = true,
                QtMetrosMergulho = 20
            },
            new Peixe {
                NomeEspecie = "Peixe",
                NomeSubEspecie = "Peixe-voador",
                CapacidadeNadar = true,
                CapacidadeVoar = true,
                QtMetrosMergulho = 50
            },
            new Peixe {
                NomeEspecie = "Peixe",
                NomeSubEspecie = "Tilápia",
                CapacidadeNadar = true,
                CapacidadeVoar = false,
                QtMetrosMergulho = 1
            },
            new Anfibio {
                NomeEspecie = "Anfibio",
                NomeSubEspecie = "Sapo voador de Wallace",
                CapacidadeNadar = true,
                CapacidadeVoar = true,
                QtMetrosMergulho = 1
            },
            new Anfibio {
                NomeEspecie = "Anfibio",
                NomeSubEspecie = "Axolote",
                CapacidadeNadar = true,
                CapacidadeVoar = false,
                QtMetrosMergulho = 1
            },
            new Ave {
                NomeEspecie = "Ave",
                NomeSubEspecie = "Pinguim",
                CapacidadeVoar = false,
                CapacidadeNadar = true,
                QtMetrosMergulho = 5
            },
            new Reptil {
                NomeEspecie = "Reptil",
                NomeSubEspecie = "Cobra",
                CapacidadeNadar = true,
                QtMetrosMergulho = 2
            },
        };

foreach (var animal in zoo)
{
    if (animal is ICapacidadeVoar voador)
    {
        voador.LevantarVoo();
        voador.Pousar();
    }

    if (animal is ICapacidadeNadar nadador)
    {
        nadador.Mergulhar();
    }
}
