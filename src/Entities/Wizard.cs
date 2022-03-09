namespace rpg_jogo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + "Atacou com a sua magia";
        }
        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + "Lançou Magia com bonus de ataque de " + Bonus;
            }else{
                return this.Name + "Lançou Magia com força franca com bonus de" + Bonus;
            }
        }
    }
}