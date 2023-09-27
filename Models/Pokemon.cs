using Pokedex_API.Models.Enums;

namespace Pokedex_API.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PokemonType> Type { get; set; }
        public int Hp { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public int AtaqueEspecial { get; set; }
        public int DefesaEspecial { get; set; }
        public int Velocidade { get; set; }

        public Pokemon(int id, int number, string name,
            string description, List<PokemonType> type, int hp, 
            int ataque, int defesa, int ataqueEspecial, int defesaEspecial, int velocidade)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Hp = hp;
            Ataque = ataque;
            Defesa = defesa;
            AtaqueEspecial = ataqueEspecial;
            DefesaEspecial = defesaEspecial;
            Velocidade = velocidade;
        }
    }
}
