namespace Skill
{
    using UnityEngine;
    public enum SkillType { self, selectTarget, area, projectile }
    public enum DamageType { patk, matk, heal, buff, None }

    public abstract class PassiveSkill<T>
    {
        public string names;
        public string discription;
        public SkillType skillType;
        public DamageType damageType;

        public abstract T CalculateParameterFromSkill(T tkey);
    }
}
