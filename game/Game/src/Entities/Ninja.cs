namespace Game.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType, int ManaPotion, int HelthPotion)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.ManaPotion = ManaPotion;
            this.HealthPotion = HelthPotion;
        }
        public override string Attack(){
            return this.Name + " Atacou com sua estrela ninja";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 8)
            {
            return this.Name + " Lançou um ataque efetivo!! Seu nunchaku entrou em ação e teve bonus de " + Bonus;
            }
            else {
                return this.Name + " Lançou um ataque pouco efetivo!! Sua estrela ninja estava cega e causou um bonus de " + Bonus;
            }
        }
    }
}