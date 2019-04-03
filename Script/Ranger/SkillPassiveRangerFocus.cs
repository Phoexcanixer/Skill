namespace Skill
{
    using UnityEngine;
    using System;

    //[CreateAssetMenu(fileName = "Focus", menuName = "Skill/Ranger")]
    public class SkillPassiveRangerFocus : PassiveSkill<Tuple<float, float>>
    {
        public float atk { get; set; }
        public float spd { get; set; }

        float _atk = 5f, _spd = 5f;

        public SkillPassiveRangerFocus()
        {
            names = "Focus";
            discription = String.Format("Increase ATK by {0}% /n Increase SPD by {1}% ",_atk,_spd);
            skillType = SkillType.self;
            damageType = DamageType.buff;
        }


        public override Tuple<float, float> CalculateParameterFromSkill(Tuple<float, float> tkey)
        {
            atk = tkey.Item1 * (_atk / 100f);
            spd = tkey.Item2 * (_spd / 100f);
            return new Tuple<float, float> (atk, spd);
        }
    }

}
