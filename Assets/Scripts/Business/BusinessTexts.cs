using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BusinessTexts : MonoBehaviour
{
    public Text ToastUpgradeButtonText;
    public Text ToastShopText;

    public Text DonerUpgradeButtonText;
    public Text DonerShopText;

    public Text CigkofteUpgradeButtonText;
    public Text CigkofteShopText;

    public Text LahmacunUpgradeButtonText;
    public Text LahmacunShopText;

    public Text KebabUpgradeButtonText;
    public Text KebabShopText;

    private void Update()
    {
        ToastShopText.text = "TOAST SHOP\n" + "Level " + Levels.ToastShopLevel + "\nIn " + Money.NecessaryTimeForToastShop + " Seconds Earn " + Money.ProfitToastShop + " ₺\nUpgrade " + Money.MoneyForToastShopUpgradePrice + " ₺";

        if (Money.ToastBought)
        {
            ToastUpgradeButtonText.text = "UPGRADE";
            if(Money.NecessaryTimeForToastShop == 1)
            {
                ToastUpgradeButtonText.text = "FULL"; 
                ToastShopText.text = "TOAST SHOP\n" + "Level " + Levels.ToastShopLevel + "\nIn " + Money.NecessaryTimeForToastShop + " Seconds Earn " + Money.ProfitToastShop + " ₺";
            }
        }

        DonerShopText.text = "DONER SHOP\n" + "Level " + Levels.DonerShopLevel + "\nIn " + Money.NecessaryTimeForDonerShop + " Seconds Earn " + Money.ProfitDonerShop + " ₺\nUpgrade " + Money.MoneyForDonerShopUpgradePrice + " ₺";

        if (Money.DonerBought)
        {
            DonerUpgradeButtonText.text = "UPGRADE";
            if (Money.NecessaryTimeForDonerShop == 1)
            {
                DonerUpgradeButtonText.text = "FULL"; 
                DonerShopText.text = "DONER SHOP\n" + "Level " + Levels.DonerShopLevel + "\nIn " + Money.NecessaryTimeForDonerShop + " Seconds Earn " + Money.ProfitDonerShop + " ₺";
            }
        }

        CigkofteShopText.text = "CIGKOFTE SHOP\n" + "Level " + Levels.CigkofteShopLevel + "\nIn " + Money.NecessaryTimeForCigkofteShop + " Seconds Earn " + Money.ProfitCigkofteShop + " ₺\nUpgrade " + Money.MoneyForCigkofteShopUpgradePrice + " ₺";

        if (Money.CigkofteBought)
        {
            CigkofteUpgradeButtonText.text = "UPGRADE";
            if (Money.NecessaryTimeForLahmacunShop == 1)
            {
                CigkofteUpgradeButtonText.text = "FULL";
                CigkofteShopText.text = "CIGKOFTE SHOP\n" + "Level " + Levels.CigkofteShopLevel + "\nIn " + Money.NecessaryTimeForCigkofteShop + " Seconds Earn " + Money.ProfitCigkofteShop + " ₺";
            }
        }

        LahmacunShopText.text = "LAHMACUN SHOP\n" + "Level " + Levels.LahmacunShopLevel + "\nIn " + Money.NecessaryTimeForLahmacunShop + " Seconds Earn " + Money.ProfitLahmacunShop + " ₺\nUpgrade " + Money.MoneyForLahmacunShopUpgradePrice + " ₺";

        if (Money.LahmacunBought)
        {
            LahmacunUpgradeButtonText.text = "UPGRADE";
            if (Money.NecessaryTimeForLahmacunShop == 1)
            {
                LahmacunUpgradeButtonText.text = "FULL";
                LahmacunShopText.text = "LAHMACUN SHOP\n" + "Level " + Levels.LahmacunShopLevel + "\nIn " + Money.NecessaryTimeForLahmacunShop + " Seconds Earn " + Money.ProfitLahmacunShop + " ₺";
            }
        }

        KebabShopText.text = "KEBAB SHOP\n" + "Level " + Levels.KebabShopLevel + "\nIn " + Money.NecessaryTimeForKebabShop + " Seconds Earn " + Money.ProfitKebabShop + " ₺\nUpgrade " + Money.MoneyForKebabShopUpgradePrice + " ₺";

        if (Money.KebabBought)
        {
            KebabUpgradeButtonText.text = "UPGRADE";
            if (Money.NecessaryTimeForKebabShop == 1)
            {
                KebabUpgradeButtonText.text = "FULL";
                KebabShopText.text = "KEBAB SHOP\n" + "Level " + Levels.KebabShopLevel + "\nIn " + Money.NecessaryTimeForKebabShop + " Seconds Earn " + Money.ProfitKebabShop + " ₺";
            }
        }
    }
}
