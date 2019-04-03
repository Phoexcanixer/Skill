namespace Skill
{
    using System;

    public class SkillActiveRangerFrostShot : ActiveSkill<float>
    {
        public float atk { get; set; }

        float _atk = 30f;

        public SkillActiveRangerFrostShot()
        {
            names = "Focus";
            discription = String.Format("Increase ATK by {0}% for {1} second", _atk);
            skillType = SkillType.self;
            damageType = DamageType.buff;
        }

        public override float CalculateParameterFromSkill(float tkey)
        {
            return atk;
        }
    }
}
