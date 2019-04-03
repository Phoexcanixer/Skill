using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Skill;
using System;

public class UserInput : MonoBehaviour, ISkillModifier
{
    public IDictionary<KeyCode, Action> getKey { get; set; }

    public void Awake()
    {
        getKey = new Dictionary<KeyCode, Action>();

        getKey[KeyCode.Q] = () => EnableSkill01();
        getKey[KeyCode.E] = () => EnableSkill02();
        getKey[KeyCode.R] = () => EnableSkill03();
    }

    public void Update()
    {
        if (Input.anyKeyDown)
        {
            if (string.IsNullOrWhiteSpace(Input.inputString) || !getKey.ContainsKey(Execute()))
            {
                Debug.Log("!!! No Action !!!");
            }
            else getKey[Execute()]?.Invoke();
        }

    }

    public void EnablePassive() { Debug.Log("Passive"); }
    public void EnableSkill01() { Debug.Log("EnableSkill01"); }
    public void EnableSkill02() { Debug.Log("EnableSkill02"); }
    public void EnableSkill03() { Debug.Log("EnableSkill03"); }

    public KeyCode Execute()
    {
        Enum.TryParse<KeyCode>(Input.inputString.ToUpper(), out KeyCode inputKey);
        return inputKey;
    }
}
