﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Hurt : ICharacterState
{
    private StatePatternController player;
    public State_Hurt(StatePatternController controller)
    {
        player = controller;
    }

    public void OnAnimatorIK(AvatarIKGoal NonDomHand)
    {
        throw new NotImplementedException();
    }

    public void OnAnimatorMove()
    {
        throw new NotImplementedException();
    }

    public void OnTriggerEnter(Collider other)
    {
        throw new NotImplementedException();
    }

    public void OnTriggerExit(Collider other)
    {
        throw new NotImplementedException();
    }

    public void OnTriggerStay(Collider other)
    {
        throw new NotImplementedException();
    }

    public void SwitchWeapon()
    {
        throw new NotImplementedException();
    }

    public void ToCasual()
    {
        throw new NotImplementedException();
    }

    public void ToCombat()
    {
        throw new NotImplementedException();
    }

    public void ToGround()
    {
        throw new NotImplementedException();
    }

    public void ToHurt()
    {
        throw new NotImplementedException();
    }

    public void ToInteraction()
    {
        throw new NotImplementedException();
    }

    public void ToQuickTime()
    {
        throw new NotImplementedException();
    }

    public void ToRun()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}
