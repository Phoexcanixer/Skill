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
        Debug.Log("ATK: "+Ranger.passive.atk);
        Debug.Log("SPD: "+Ranger.passive.spd);
    }
}
