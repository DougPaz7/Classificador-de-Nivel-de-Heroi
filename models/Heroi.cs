using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classificador_de_Nivel_de_Heroi.models
{
    public class Heroi
    {
        // Validação para o nome não ser vazio.
        private string _nome;
        public string Nome 
        {
            get => _nome;
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value;
            } 
        }

        // Validação para o XP não ser negativo.
        private int _xp;
        public int XP
        {
            get => _xp;
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O XP não pode ser negativo.");
                }

                _xp = value;
            } 
        }

        // Método para exibir nome e XP do herói.
        public void NivelDoHeroi(string nivel)
        {
            if (XP < 1000)
            {
                nivel = "-FERRO-";
                Console.WriteLine($"O Herói de nome {Nome} está no nível de {nivel}");
            }
            else if (XP >= 1000 && XP < 2000)
            {
                nivel = "-BRONZE-";
                Console.WriteLine($"O Herói de nome {Nome} está no nível de {nivel}");
            }
            else if (XP >= 2000 && XP < 5000)
            {
                nivel = "-PRATA-";
                Console.WriteLine($"O Herói de nome {Nome} está no nível de {nivel}");
            }
            else if (XP >= 5000 && XP < 7000)
            {
                nivel = "-OURO-";
                Console.WriteLine($"O Herói de nome {Nome} está no nível de {nivel}");
            }
            else if (XP >= 7000 && XP < 8000)
            {
                nivel = "-PLATINA-";
                Console.WriteLine($"O Herói de nome {Nome} está no nível de {nivel}");
            }
            else if (XP >= 8000 && XP < 9000)
            {
                nivel = "-ASCENDENTE-";
                Console.WriteLine($"O Herói de nome {Nome} está no nível de {nivel}");
            }
            else if (XP >= 9000 && XP < 10000)
            {
                nivel = "-IMORTAL-";
                Console.WriteLine($"O Herói de nome {Nome} está no nível de {nivel}");
            }
            else
            {
                nivel = "-RADIANTE-";
                Console.WriteLine($"O Herói de nome {Nome} está no nível de {nivel}");
            }
        }
    }
}        