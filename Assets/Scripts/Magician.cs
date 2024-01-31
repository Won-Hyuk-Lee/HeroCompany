using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magician : Hero
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Upgrade()
    {
        money -= upgradeCost;
        upgradeCost *= 1.14f;
        getMoney+=540;
    }

    protected override IEnumerator EarnMoney()
    {
        while (true)
        {
            // 1�� ���
            yield return new WaitForSeconds(1.0f);

            // �� ���
            money += getMoney;

            // UI ǥ��

        }
    }

    protected override void OpenHero()
    {
        heroLevel = 1;
        getMoney = 540;
        upgradeCost = 826.5f;
        StartCoroutine(EarnMoney());
    }

}
