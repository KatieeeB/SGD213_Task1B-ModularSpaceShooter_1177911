﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : DetectCollisionBase
{
    [SerializeField]
    private int damageToDeal;

    protected override void ProcessCollision(GameObject other)
    {
        base.ProcessCollision(other);
        if (other.GetComponent<IHealth>() != null) //Deal damage if the other object has a IHealth Component attached
        {
            other.GetComponent<IHealth>().TakeDamage(damageToDeal);
        } 
        else
        {
            Debug.Log(other.name + " does not have an IHealth component");
        }

        Destroy(gameObject); //destroy object
    }
}
