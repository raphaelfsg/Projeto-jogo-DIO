namespace Game.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, int ManaPotion, int HelthPotion)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.ManaPotion = ManaPotion;
            this.HealthPotion = HelthPotion;
        }
        
        public Hero(){
            
        }

        public string Name { get; set; }
        public int level { get; set; }
        public string HeroType { get; set; }
        public int ManaPotion { get; set; }
        public int HealthPotion { get; set; }


        public override string ToString(){
            return this.Name + " " + this.level + " " + this.HeroType + " " + this.ManaPotion + " " + this.HealthPotion;
        }

        public virtual string Attack(){
            return this.Name + " Atacou";
        }
    }
}