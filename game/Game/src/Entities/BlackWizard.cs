namespace Game.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int ManaPotion, int HelthPotion)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.ManaPotion = ManaPotion;
            this.HealthPotion = HelthPotion;
        }
        public override string Attack(){
            return this.Name + " Atacou com sua magia negra";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 8)
            {
            return this.Name + " Lançou um ataque efetivo!! Voce descobriu a necromancia e seu novo exército causou dano além da magia causando bonus de " + Bonus;
            }
            else {
                return this.Name + " Lançou um ataque pouco efetivo!! Magia lançada com bonus de " + Bonus;
            }
        }
    }
}