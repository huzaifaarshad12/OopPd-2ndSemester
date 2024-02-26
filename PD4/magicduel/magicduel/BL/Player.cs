using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicduel
{
    internal class Player
    {
        public string name;
        public float health;
        public float maxHealth;
        public float energy;
        public float maxEnergy;
        public float armour;

        Stats skill=new Stats();
        public void learnskill(Stats skills)
        {
           skill.name=skills.name;
            skill.damage = skills.damage;
            skill.penetration = skills.penetration;
            skill.heal = skills.heal;
            skill.cost = skills.cost;
            skill.description = skills.description;

        }

        public string attack(Player target) {
            target.armour -= skill.penetration;
            this.energy -= skill.cost;
            float donedamage = skill.damage * ((100 - armour) / 100);
            target.health -= donedamage;
            if (skill.heal+this.health<this.maxHealth)
            {
                this.health += skill.heal;
            }
            string result = $"{this.name} used {skill.name},{skill.description} against {target.name} doing {donedamage} damage";
            return result ;
        }
    }
}
