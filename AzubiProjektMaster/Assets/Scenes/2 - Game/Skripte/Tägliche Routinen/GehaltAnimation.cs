﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GehaltAnimation : MonoBehaviour
{
    private int oldBalance;
    public ParticleSystem balancePlusAnimation;
    public ParticleSystem balanceMinusAnimation;
    public AudioSource moneySound;
    float time = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        oldBalance = GlobalVariables.balance;
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
            oldBalance = GlobalVariables.balance;
        }
        else
        {
            if (oldBalance < GlobalVariables.balance)
            {
                balancePlusAnimation.Play();
                moneySound.Play();
                oldBalance = GlobalVariables.balance;
            }
            else if (oldBalance > GlobalVariables.balance)
            {
                balanceMinusAnimation.Play();
                moneySound.Play();
                oldBalance = GlobalVariables.balance;
            }
        }
        
    }
}
