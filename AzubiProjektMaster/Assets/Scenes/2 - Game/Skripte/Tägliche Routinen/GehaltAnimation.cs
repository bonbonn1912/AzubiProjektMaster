using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GehaltAnimation : MonoBehaviour
{
    private int oldBalance;
    public ParticleSystem balancePlusAnimation;
    public AudioSource moneySound;
    // Start is called before the first frame update
    void Start()
    {
        oldBalance = GlobalVariables.balance;
    }

    // Update is called once per frame
    void Update()
    {
        if (oldBalance > GlobalVariables.balance)
        {
            balancePlusAnimation.Play();
            moneySound.Play();
            oldBalance = GlobalVariables.balance;
        }
        else if (oldBalance < GlobalVariables.balance) {
            balancePlusAnimation.Play();
            moneySound.Play();
            oldBalance = GlobalVariables.balance;
        }
    }
}
