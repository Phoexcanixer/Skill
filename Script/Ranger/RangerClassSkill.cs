namespace Skill
{
    using System;

    public class RangerClassSkill
    {
        public SkillPassiveRangerFocus SkillPassiveFocus = new SkillPassiveRangerFocus();
        public SkillActiveRangerFrostShot SkillActiveFrostShot = new SkillActiveRangerFrostShot();

        public RangerClassSkill(float atk,float spd)
        {
            //------------------------------ Passive Focus --------------------------------//
            Tuple<float, float> _key = new Tuple<float, float>(atk, spd);
            SkillPassiveFocus.atk = SkillPassiveFocus.CalculateParameterFromSkill(_key).Item1;
            SkillPassiveFocus.spd = SkillPassiveFocus.CalculateParameterFromSkill(_key).Item2;

            //------------------------------ Active FrostShot --------------------------------//
        }
    }
}
