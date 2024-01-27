using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hero
{
    protected string name;
    protected float upgradeCost;

    protected abstract void Upgrade();

    protected abstract void earnMoney();
}
