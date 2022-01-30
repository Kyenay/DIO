namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class Ninja: Character
    {
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        }

        public override string Attack(){
        return this.Name + " atacou com shurikens";
        }

          public string Attack(int Bonus1)
        { 
            if (Bonus1 > 5)
            {
                return this.Name + " acerto crítico com bonus de " + Bonus1;
            }            
            
        }
    }
}