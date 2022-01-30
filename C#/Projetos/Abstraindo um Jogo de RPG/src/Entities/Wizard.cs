namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class Wizard: Character //Herança do Classe pai Character para a Classe filha Wizard
    {

        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack() //Polimorfismo do método ataque
        { 
            return this.Name + " usou magia";
        }
    
         public string Attack(int Bonus)
        { 
            if (Bonus > 5)   //Encapsulamento, essa mudança só ocorre aqui 
            {
                return this.Name + " usou magia super efetiva com bonus de " + Bonus;
            }
            else{
                return this.Name + " usou magia com bonus de " + Bonus;
            }
            
            
        }
    }
}