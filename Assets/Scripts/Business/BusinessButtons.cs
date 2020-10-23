using UnityEngine;
using UnityEngine.UI;

public class BusinessButtons : MonoBehaviour
{
    public Button ToastButton;
    public Button DonerButton;
    public Button CigkofteButton;
    public Button LahmacunButton;
    public Button KebabButton;
    private void Update()
    {
        CheckForButtonsClicable();
    }

    private void CheckForButtonsClicable()
    {
        if (Money.MainMoney < Money.MoneyForToastShopUpgradePrice || Money.NecessaryTimeForToastShop == 1)
        {
            ToastButton.enabled = false;
        }
        else
        {
            ToastButton.enabled = true;
        }
        if (Money.MainMoney < Money.MoneyForDonerShopUpgradePrice || Money.NecessaryTimeForDonerShop == 1)
        {
            DonerButton.enabled = false;
        }
        else
        {
            DonerButton.enabled = true;
        }
        if (Money.MainMoney < Money.MoneyForCigkofteShopUpgradePrice || Money.NecessaryTimeForCigkofteShop == 1)
        {
            CigkofteButton.enabled = false;
        }
        else
        {
            CigkofteButton.enabled = true;
        }
        if (Money.MainMoney < Money.MoneyForLahmacunShopUpgradePrice || Money.NecessaryTimeForLahmacunShop == 1)
        {
            LahmacunButton.enabled = false;
        }
        else
        {
            LahmacunButton.enabled = true;
        }
        if (Money.MainMoney < Money.MoneyForKebabShopUpgradePrice || Money.NecessaryTimeForKebabShop == 1)
        {
            KebabButton.enabled = false;
        }
        else
        {
            KebabButton.enabled = true;
        }
    }

    public void ToastUpgrade()
    {
        if (!Money.ToastBought)
        {
            Money.ToastBought = true;
            Money.ProfitToastShop = 5;
            Levels.ToastShopLevel++;
            Money.MainMoney -= Money.MoneyForToastShopUpgradePrice;
        }
        else
        {
            if(Money.NecessaryTimeForToastShop != 1)
            {
                Money.UpgradeToast = true;
                Levels.ToastShopLevel++;
                Money.MainMoney -= Money.MoneyForToastShopUpgradePrice;
                Money.ProfitToastShop += 5;
                Money.NecessaryTimeForToastShop--;
            }
        }
        
    }

    public void DonerUpgrade()
    {
        if (!Money.DonerBought)
        {
            Money.DonerBought = true;
            Money.ProfitDonerShop = 10;
            Levels.DonerShopLevel++;
            Money.MainMoney -= Money.MoneyForDonerShopUpgradePrice;
        }
        else
        {
            if (Money.NecessaryTimeForDonerShop != 1)
            {
                Money.UpgradeDoner = true;
                Levels.DonerShopLevel++;
                Money.MainMoney -= Money.MoneyForDonerShopUpgradePrice;
                Money.ProfitDonerShop += 10;
                Money.NecessaryTimeForDonerShop--;
            }
        }
    }

    public void CigkofteUpgrade()
    {
        if (!Money.CigkofteBought)
        {
            Money.CigkofteBought = true;
            Money.ProfitCigkofteShop = 20;
            Levels.CigkofteShopLevel++;
            Money.MainMoney -= Money.MoneyForCigkofteShopUpgradePrice;
        }
        else
        {
            if (Money.NecessaryTimeForCigkofteShop != 1)
            {
                Money.UpgradeCigkofte = true;
                Levels.CigkofteShopLevel++;
                Money.MainMoney -= Money.MoneyForCigkofteShopUpgradePrice;
                Money.ProfitCigkofteShop += 15;
                Money.NecessaryTimeForCigkofteShop--;
            }
        }

    }
    public void LahmacunUpgrade()
    {
        if (!Money.LahmacunBought)
        {
            Money.LahmacunBought = true;
            Money.ProfitLahmacunShop = 25;
            Levels.LahmacunShopLevel++;
            Money.MainMoney -= Money.MoneyForLahmacunShopUpgradePrice;
        }
        else
        {
            if (Money.NecessaryTimeForLahmacunShop != 1)
            {
                Money.UpgradeLahmacun = true;
                Levels.LahmacunShopLevel++;
                Money.MainMoney -= Money.MoneyForLahmacunShopUpgradePrice;
                Money.ProfitLahmacunShop += 20;
                Money.NecessaryTimeForLahmacunShop--;
            }
        }

    }
    public void KebabUpgrade()
    {
        if (!Money.KebabBought)
        {
            Money.KebabBought = true;
            Money.ProfitKebabShop = 50;
            Levels.KebabShopLevel++;
            Money.MainMoney -= Money.MoneyForKebabShopUpgradePrice;
        }
        else
        {
            if (Money.NecessaryTimeForKebabShop != 1)
            {
                Money.UpgradeKebab = true;
                Levels.KebabShopLevel++;
                Money.MainMoney -= Money.MoneyForKebabShopUpgradePrice;
                Money.ProfitKebabShop += 25;
                Money.NecessaryTimeForKebabShop--;
            }
        }

    }
}
