using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button PlayerButton;
    
    private void Update()
    {
        CheckForButtonsClicable();
    }

    public void IncreaseMoney()
    {
        Money.MainMoney += Money.MoneyForOneTap;
    }

    private void CheckForButtonsClicable()
    {
        if(Money.MainMoney < Money.MoneyForOneTapUpgradePrice)
        {
            PlayerButton.enabled = false;
        }
        else
        {
            PlayerButton.enabled = true;
        }
    }

    public void PlayerUpgrade()
    {
        Levels.PlayerLevel++;
        Money.MainMoney -= Money.MoneyForOneTapUpgradePrice;
        Money.MoneyForOneTap++;
    }

    
}
