namespace Skill
{
    using System;
    using UnityEngine;

    public class RangerClassSkill
    {
        public SkillPassiveRangerFocus passive = new SkillPassiveRangerFocus();

        public RangerClassSkill(float atk,float spd)
        {
            Tuple<float, float> _key = new Tuple<float, float>(atk, spd);
            passive.atk = passive.CalculateParameterFromSkill(_key).Item1;
            passive.spd = passive.CalculateParameterFromSkill(_key).Item2;
        }
    }
}
