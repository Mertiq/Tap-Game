using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour
{
    public Text MoneyText;
    public Text PlayerButtonText;


    private void Update()
    {
        MoneyText.text = Money.MainMoney.ToString();
        PlayerButtonText.text = Money.MoneyForOneTap + " ₺/TAP\nLEVEL " + Levels.PlayerLevel + "\n" + Money.MoneyForOneTapUpgradePrice + " ₺ UPGRADE";
    }

}
