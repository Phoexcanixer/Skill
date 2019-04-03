namespace Skill
{
    using UnityEngine;
    using System;
    using System.Collections.Generic;

    public interface ISkillModifier
    {
        IDictionary<KeyCode, Action> getKey { get; set; }
        KeyCode Execute();

        //void EnablePassive();
        //void EnableSkill01();
        //void EnableSkill02();
        //void EnableSkill03();
    }
}
