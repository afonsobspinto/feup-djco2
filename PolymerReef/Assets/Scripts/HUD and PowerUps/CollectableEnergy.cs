﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableEnergy : Collectable
{
    [SerializeField]
    private float amount = 0;

    public override void Interact()
    {
        PlayerController controller = player.GetComponent<PlayerController>();
        
        controller.increaseEnergy(amount);
        base.Interact();
    }
}
