namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class Knight: Character
    {
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        }

        public override string Attack(){
        return this.Name + " atacou com uma espada";
        }
    }
}