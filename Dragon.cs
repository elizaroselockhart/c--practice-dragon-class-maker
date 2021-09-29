using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Class
{
    class Dragon
    {
        public Dragon (string age, string color)
        {
            if (age == "wyrmling")
            {
                this.Age = "wyrmling";
                this.Health = random.Next(40, 120);
                this.Armor = 17;
                this.WalkingSpeed = 30;
                this.FlyingSpeed = 60;
                this.BiteAttackRaw = random.Next(9, 13);
                this.BiteAttackElemental = random.Next(6, 10);
                this.ClawAttack = 0;
                this.NumberofClawAttacks = 0;
                this.FrightfulPresence = false;
                this.BreathWeaponDamage = random.Next(24, 40);
            }
            else if (age == "young")
            {
                this.Age = "young";
                this.Health = random.Next(176, 240);
                this.Armor = 18;
                this.WalkingSpeed = 40;
                this.FlyingSpeed = 80;
                this.BiteAttackRaw = random.Next(17, 25);
                this.BiteAttackElemental = random.Next(12, 20);
                this.ClawAttack = random.Next(13, 17);
                this.NumberofClawAttacks = 1;
                this.FrightfulPresence = false;
                this.BreathWeaponDamage = random.Next(40, 80);
            }
            else if (age == "adult")
            {
                this.Age = "adult";
                this.Health = random.Next(208, 288);
                this.Armor = 19;
                this.WalkingSpeed = 40;
                this.FlyingSpeed = 80;
                this.BiteAttackRaw = random.Next(19, 27);
                this.BiteAttackElemental = random.Next(12, 20);
                this.ClawAttack = random.Next(15, 19);
                this.NumberofClawAttacks = 2;
                this.FrightfulPresence = true;
                this.BreathWeaponDamage = random.Next(72, 120);
            }
            else if (age == "ancient")
            {
                this.Age = "ancient";
                this.Health = random.Next(594, 616);
                this.Armor = 22;
                this.WalkingSpeed = 40;
                this.FlyingSpeed = 80;
                this.BiteAttackRaw = random.Next(21, 29);
                this.BiteAttackElemental = random.Next(20, 32);
                this.ClawAttack = random.Next(16, 20);
                this.NumberofClawAttacks = 2;
                this.FrightfulPresence = true;
                this.BreathWeaponDamage = random.Next(96, 160);
            }
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            if (color == "black")
            {
                this.DamageImmunity = "acid";
                this.BreathWeaponType = "acid";
                this.Color = "black";
            }
            else if (color == "blue")
            {
                this.DamageImmunity = "lightning";
                this.BreathWeaponType = "lightning";
                this.Color = "blue";

            }
            else if (color == "green")
            {
                this.DamageImmunity = "poison";
                this.BreathWeaponType = "poison";
                this.Color = "green";
            }
            else if (color == "red")
            {
                this.DamageImmunity = "fire";
                this.BreathWeaponType = "fire";
                this.Color = "red";
            }
            else if (color == "white")
            {
                this.DamageImmunity = "white";
                this.BreathWeaponType = "white";
                this.Color = "white";
            }
        }
        public static Random random = new Random();
        private string Name { get; set; }
        private string Age { get; set; }
        private string Color { get; set; }
        private int Armor { get; set; }
        private int Health { get; set; }
        private int WalkingSpeed { get; set; }
        private int FlyingSpeed { get; set; }
        private string DamageImmunity { get; set; }
        private int BiteAttackRaw { get; set; }
        private int BiteAttackElemental { get; set; }
        private int ClawAttack { get; set; }
        private int NumberofClawAttacks { get; set; }
        private bool FrightfulPresence { get; set; }
        private int BreathWeaponDamage { get; set; }
        private string BreathWeaponType { get; set; }
        public void SetName(string name) { this.Name = name; }
        public string GetName() { return this.Name; }
        public string GetAge() { return this.Age; }
        public string GetColor() { return this.Color; }
        public int GetArmor() { return this.Armor; }
        public int GetHealth() { return this.Health; }
        public int GetWalkingSpeed() { return this.WalkingSpeed; }
        public int GetFlyingSpeed() { return this.FlyingSpeed; }
        public string GetDamageImmunity() { return this.DamageImmunity; }
        public int GetBiteAttackRaw() { return this.BiteAttackRaw; }
        public int GetBiteAttackElemental() { return this.BiteAttackElemental; }
        public int GetClawAttack() { return this.ClawAttack; }
        public int GetNumberofClawAttacks() { return this.NumberofClawAttacks; }
        public bool GetFrightfulPresence() { return this.FrightfulPresence; }
        public int GetBreathWeaponDamage() { return this.BreathWeaponDamage; }
        public string GetBreathWeaponType() { return this.BreathWeaponType; }

        public void ViewStats()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Your {this.GetAge()} {this.GetColor()} dragon has the following statistics...");
            Console.Write("\nName: "); Console.ForegroundColor = ConsoleColor.Green; Console.Write($"{this.GetName()}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nHealth: "); Console.ForegroundColor = ConsoleColor.Green; Console.Write($"{this.GetHealth()}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nArmor: "); Console.ForegroundColor = ConsoleColor.Green; Console.Write($"{this.GetArmor()}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nWalking Speed: "); Console.ForegroundColor = ConsoleColor.Green; Console.Write($"{this.GetWalkingSpeed()} feet");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nFlying Speed: "); Console.ForegroundColor = ConsoleColor.Green; Console.Write($"{this.GetFlyingSpeed()} feet.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"\nYour dragon has a bite attack that deals {this.GetBiteAttackRaw()} points of piercing damage plus {this.GetBiteAttackElemental()} points of {this.GetBreathWeaponType()} damage.");
            Console.Write($"\nYour dragon has {this.GetNumberofClawAttacks()} claw attack(s) that deal {this.GetClawAttack()} points of slashing damage.");
            if (this.GetFrightfulPresence() is true)
            { Console.Write("\nYour dragon has the ability Frightful Presence."); }
            Console.Write($"\nYour dragon has a breath weapon that deals {this.GetBreathWeaponDamage()} points of {this.GetBreathWeaponType()} damage.");
        }
    }
}
