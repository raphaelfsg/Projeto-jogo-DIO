namespace Game.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int ManaPotion, int HelthPotion)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.ManaPotion = ManaPotion;
            this.HealthPotion = HelthPotion;
        }
        public override string Attack(){
            return this.Name + " Atacou com sua espada";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 8)
            {
            return this.Name + " Lançou um ataque efetivo!! Sua adaga ainda tinha veneno do último dragão derrotado e causou um bonus de " + Bonus;
            }
            else {
                return this.Name + " Lançou um ataque pouco efetivo!! Voce tropeçou no último golpe e sua adaga pegou de raspão causando bonus de " + Bonus;
            }
        }
    }
}