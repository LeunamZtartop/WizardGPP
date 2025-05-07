using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(menuName = "ScriptableObjects/Class")]
public class ClassWizard : ScriptableObject
{
    public int maxMana = 100;
    [System.NonSerialized]
    public int maxHealth = 100;
    [System.NonSerialized]
    public float health, mana;
    public float movementSpeed = 5;

    WizardClass()
    {
        mana = maxMana;
        health = maxHealth;
    }

    public float HealthPercentage()
    {
        return health / maxHealth;
    }
}
