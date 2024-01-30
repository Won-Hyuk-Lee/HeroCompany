using System.Collections;
using UnityEngine;

public abstract class Hero : MonoBehaviour
{
    //protected string name;
    protected float upgradeCost;
    protected int heroLevel;
    protected float getMoney;
    protected float money;



    protected abstract void Upgrade();

    protected abstract void ShowUI();

    protected abstract void OpenHero();

    protected abstract IEnumerator EarnMoney();
}
