namespace Abstraindo_um_Jogo_de_RPG.src.Entities;

public abstract class Character
{
    public Character(string Name, int Level, string HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }
    public string Name {get;set;}
    public int Level {get;set;}
    public string HeroType {get;set;}


    public override string ToString(){
        return this.Name + ", " + this.Level + ", " + this.HeroType;
    }

    public virtual string Attack(){
        return this.Name + " atacou";
    }
}
