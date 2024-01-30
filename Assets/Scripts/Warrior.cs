using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Warrior : Hero
{
    [SerializeField] Text text;

    private void Awake()
    {
        OpenHero();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Upgrade();
        }
        text.text = money.ToString("F2");
    }

    protected override void Upgrade()
    {
        money -= upgradeCost;
        upgradeCost *= 1.07f;
        getMoney++;
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

    protected override void ShowUI()
    {

    }

    protected override void OpenHero()
    {
        heroLevel = 1;
        getMoney = 1;
        upgradeCost = 4;
        StartCoroutine(EarnMoney());
    }


}
