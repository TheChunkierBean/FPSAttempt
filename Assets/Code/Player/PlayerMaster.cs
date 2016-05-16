﻿using UnityEngine;
using System.Collections;

public class PlayerMaster : MonoBehaviour {

    public delegate void GeneralEventHandler();
    public event GeneralEventHandler EventInventoryChanged;
    public event GeneralEventHandler EventHandsEmpty;
    public event GeneralEventHandler EventAmmoChanged;

    public delegate void AmmoPickupEventHandler(string ammoName, int quantity);
    public event AmmoPickupEventHandler EventPickedUpAmmo;

    public delegate void PlayerHealthEventHandler(int healthChange);
    public event PlayerHealthEventHandler EventPlayerHealthDecrease;
    public event PlayerHealthEventHandler EventPlayerHealthIncrease;

    public void CallEventInventoryChanged()
    {
        if(EventInventoryChanged != null)
        {
            EventInventoryChanged();
        }
    }

    public void CallEventHandsEmpty()
    {
        if(EventHandsEmpty != null)
        {
            EventHandsEmpty();
        }
    }

    public void CallEventAmmoChanged()
    {
        if (EventAmmoChanged != null)
        {
            EventAmmoChanged();
        }
    }

    public void CallEventPickedUpAmmo(string ammoName, int quantity)
    {
        if (EventPickedUpAmmo != null)
        {
            EventPickedUpAmmo(ammoName, quantity);
        }
    }

    public void CallEventPlayerHealthDecrease(int damage)
    {
        if(EventPlayerHealthDecrease != null)
        {
            EventPlayerHealthDecrease(damage);
        }
    }

    public void CallEventPlayerHealthIncrease(int increase)
    {
        if (EventPlayerHealthDecrease != null)
        {
            EventPlayerHealthDecrease(increase);
        }
    }

}