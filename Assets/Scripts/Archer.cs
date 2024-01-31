using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Hero
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
        upgradeCost *= 1.15f;
        getMoney+=60;
    }

    protected override IEnumerator EarnMoney()
    {
        while (true)
        {
            // 1초 대기
            yield return new WaitForSeconds(1.0f);

            // 돈 얻기
            money += getMoney;

            // UI 표시

        }
    }

    protected override void OpenHero()
    {
        heroLevel = 1;
        getMoney = 60;
        upgradeCost = 74.75f;
        StartCoroutine(EarnMoney());
    }
}
