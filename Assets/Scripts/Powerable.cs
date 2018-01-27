﻿using UnityEngine;
using UnityEngine.Events;

public class Powerable : MonoBehaviour
{
    public int RequiredPower;
    public UnityEvent OnPowerUp;
    public UnityEvent OnPowerDown;

    private bool isPowered;

    public void Awake()
    {
        OnPowerDown.Invoke();
        isPowered = false;
    }

    public void OnPowerChange(int ammount)
    {
        if (ammount < RequiredPower)
        {
            isPowered = false;
            OnPowerDown.Invoke();
        }
        else if (ammount >= RequiredPower)
        {
            isPowered = true;
            OnPowerUp.Invoke();
        }
    }

}