namespace Game.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType, int ManaPotion, int HelthPotion)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.ManaPotion = ManaPotion;
            this.HealthPotion = HelthPotion;
        }
        public override string Attack(){
            return this.Name + " Atacou com sua magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 8)
            {
            return this.Name + " Lançou um ataque efetivo!! Vocce pegou a varinha do Harry Potter por engano e lançou magia com bonus de " + Bonus;
            }
            else {
                return this.Name + " Lançou um ataque pouco efetivo!! Sua varinha de bambo não era tão legal assim e o inimigo riu do seu ataque. Magia lançada com bonus de " + Bonus;
            }
        }
    }
}