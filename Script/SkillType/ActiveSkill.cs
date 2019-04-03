namespace Skill
{
    public abstract class ActiveSkill<T> : PassiveSkill<T>
    {
        public float cost;
        public float recast;
    }
}
