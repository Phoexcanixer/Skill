using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Skill;

public class Player : MonoBehaviour
{
    RangerClassSkill Ranger = new RangerClassSkill(10,20);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1234");
        Debug.Log("ATK: "+Ranger.SkillPassiveFocus.atk);
        Debug.Log("SPD: "+Ranger.SkillPassiveFocus.spd);
        Debug.Log("Name: "+Ranger.SkillPassiveFocus.names);
        Debug.Log("Discription: "+Ranger.SkillPassiveFocus.discription);
        Debug.Log("SkillType: "+Ranger.SkillPassiveFocus.skillType);
        Debug.Log("DamageType: "+Ranger.SkillPassiveFocus.damageType);
    }
}
