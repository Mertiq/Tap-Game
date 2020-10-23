using System;
using UnityEngine;

public class Money : MonoBehaviour
{

    public static int MainMoney = 0;
    public static int MoneyForOneTap = 1;
    public static int MoneyForOneTapUpgradePrice = 0;
    public static int ProfitFromOneTap = 0;


    public static int ProfitToastShop = 0;
    public static int MoneyForToastShopUpgradePrice = 1000;
    public static bool UpgradeToast = false;
    public static bool ToastBought = false;
    public static float ToastShopTimer = 0;
    public static int NecessaryTimeForToastShop = 10;

    public static int ProfitDonerShop = 0;
    public static int MoneyForDonerShopUpgradePrice = 5000;
    public static bool UpgradeDoner = false;
    public static bool DonerBought = false;
    public static float DonerShopTimer = 0;
    public static int NecessaryTimeForDonerShop = 20;

    public static int ProfitCigkofteShop = 0;
    public static int MoneyForCigkofteShopUpgradePrice = 15000;
    public static bool UpgradeCigkofte = false;
    public static bool CigkofteBought = false;
    public static float CigkofteShopTimer = 0;
    public static int NecessaryTimeForCigkofteShop = 30;

    public static int ProfitLahmacunShop = 0;
    public static int MoneyForLahmacunShopUpgradePrice = 25000;
    public static bool UpgradeLahmacun = false;
    public static bool LahmacunBought = false;
    public static float LahmacunShopTimer = 0;
    public static int NecessaryTimeForLahmacunShop = 40;

    public static int ProfitKebabShop = 0;
    public static int MoneyForKebabShopUpgradePrice = 50000;
    public static bool UpgradeKebab = false;
    public static bool KebabBought = false;
    public static float KebabShopTimer = 0;
    public static int NecessaryTimeForKebabShop = 50;

    private void Start()
    {

     //UpdatePlayerInfos();

        MainMoney = PlayerPrefs.GetInt("MainMoney");
        if(PlayerPrefs.GetInt("MoneyForOneTap") != 1)
            MoneyForOneTap = PlayerPrefs.GetInt("MoneyForOneTap");  
        MoneyForOneTapUpgradePrice = PlayerPrefs.GetInt("MoneyForOneTapUpgradePrice");
        ProfitFromOneTap = PlayerPrefs.GetInt("ProfitFromOneTap");

        ProfitToastShop = PlayerPrefs.GetInt("ProfitToastShop");
        if(PlayerPrefs.GetInt("MoneyForToastShopUpgradePrice") != 0)
            MoneyForToastShopUpgradePrice = PlayerPrefs.GetInt("MoneyForToastShopUpgradePrice");
        UpgradeToast = intToBool(PlayerPrefs.GetInt("UpgradeToast"));
        ToastBought = intToBool(PlayerPrefs.GetInt("ToastBought"));
        ToastShopTimer = PlayerPrefs.GetFloat("ToastShopTimer");
        if(PlayerPrefs.GetInt("NecessaryTimeForToastShop") != 0)
            NecessaryTimeForToastShop = PlayerPrefs.GetInt("NecessaryTimeForToastShop");

        ProfitDonerShop = PlayerPrefs.GetInt("ProfitDonerShop");
        if(PlayerPrefs.GetInt("MoneyForDonerShopUpgradePrice") != 0)
            MoneyForDonerShopUpgradePrice = PlayerPrefs.GetInt("MoneyForDonerShopUpgradePrice");
        UpgradeDoner = intToBool(PlayerPrefs.GetInt("UpgradeDoner"));
        DonerBought = intToBool(PlayerPrefs.GetInt("DonerBought"));
        DonerShopTimer = PlayerPrefs.GetFloat("DonerShopTimer");
        if(PlayerPrefs.GetInt("NecessaryTimeForDonerShop") != 0)
            NecessaryTimeForDonerShop = PlayerPrefs.GetInt("NecessaryTimeForDonerShop");

        ProfitCigkofteShop = PlayerPrefs.GetInt("ProfitCigkofteShop");
        if(PlayerPrefs.GetInt("MoneyForCigkofteShopUpgradePrice") != 0)
            MoneyForCigkofteShopUpgradePrice = PlayerPrefs.GetInt("MoneyForCigkofteShopUpgradePrice");
        UpgradeCigkofte = intToBool(PlayerPrefs.GetInt("UpgradeCigkofte"));
        CigkofteBought = intToBool(PlayerPrefs.GetInt("CigkofteBought"));
        CigkofteShopTimer = PlayerPrefs.GetFloat("CigkofteShopTimer");
        if(PlayerPrefs.GetInt("NecessaryTimeForCigkofteShop") != 0)
            NecessaryTimeForCigkofteShop = PlayerPrefs.GetInt("NecessaryTimeForCigkofteShop");

        ProfitLahmacunShop = PlayerPrefs.GetInt("ProfitLahmacunShop");
        if (PlayerPrefs.GetInt("MoneyForLahmacunShopUpgradePrice") != 0)
            MoneyForLahmacunShopUpgradePrice = PlayerPrefs.GetInt("MoneyForLahmacunShopUpgradePrice");
        UpgradeLahmacun = intToBool(PlayerPrefs.GetInt("UpgradeLahmacun"));
        LahmacunBought = intToBool(PlayerPrefs.GetInt("LahmacunBought"));
        LahmacunShopTimer = PlayerPrefs.GetFloat("LahmacunShopTimer");
        if(PlayerPrefs.GetInt("NecessaryTimeForLahmacunShop") != 0)
            NecessaryTimeForLahmacunShop = PlayerPrefs.GetInt("NecessaryTimeForLahmacunShop");

        ProfitKebabShop = PlayerPrefs.GetInt("ProfitKebabShop");
        if (PlayerPrefs.GetInt("MoneyForKebabShopUpgradePrice") != 0)
            MoneyForKebabShopUpgradePrice = PlayerPrefs.GetInt("MoneyForKebabShopUpgradePrice");
        UpgradeKebab = intToBool(PlayerPrefs.GetInt("UpgradeKebab"));
        KebabBought = intToBool(PlayerPrefs.GetInt("KebabBought"));
        KebabShopTimer = PlayerPrefs.GetFloat("KebabShopTimer");
        if(PlayerPrefs.GetInt("NecessaryTimeForKebabShop") != 0)
            NecessaryTimeForKebabShop = PlayerPrefs.GetInt("NecessaryTimeForKebabShop");

//        PlayerPrefs.DeleteAll();
    }
    
    private void Update()
    {
        SetMoneyForOneTapUpgradePrice();
        SetProfitFromOneTap();
        SetMoneyForToastShopUpgradePrice();
        GetToastShopProfit();
        SetMoneyForDonerShopUpgradePrice();
        GetDonerShopProfit();
        SetMoneyForCigkofteShopUpgradePrice();
        GetCigkofteShopProfit();
        SetMoneyForLahmacunShopUpgradePrice();
        GetLahmacunShopProfit();
        SetMoneyForKebabShopUpgradePrice();
        GetKebabShopProfit();

       UpdatePlayerInfos();
    }
   
    private void SetMoneyForOneTapUpgradePrice()
    {
        MoneyForOneTapUpgradePrice = Convert.ToInt32(MoneyForOneTap * 7.43);
    }

    private void SetProfitFromOneTap()
    {
        ProfitFromOneTap = MoneyForOneTap;
    }

    private void SetMoneyForToastShopUpgradePrice()
    {
        if (UpgradeToast)
        {
            int x = MoneyForToastShopUpgradePrice;
            MoneyForToastShopUpgradePrice = Convert.ToInt32(x * 3);
            UpgradeToast = false;
        }
    }

    private void GetToastShopProfit()
    {
        if (ToastBought)
        {
            ToastShopTimer+=Time.deltaTime;
            Debug.Log(ToastShopTimer);
            if (ToastShopTimer >= NecessaryTimeForToastShop)
            {
                MainMoney += ProfitToastShop;
                ToastShopTimer = 0;
            }
        }
    }

    private void SetMoneyForDonerShopUpgradePrice()
    {
        if (UpgradeDoner)
        {
            int x = MoneyForDonerShopUpgradePrice;
            MoneyForDonerShopUpgradePrice = Convert.ToInt32(x * 4);
            UpgradeDoner = false;
        }
    }

    private void GetDonerShopProfit()
    {
        if (DonerBought)
        {
            DonerShopTimer += Time.deltaTime;
            if (DonerShopTimer >= NecessaryTimeForDonerShop)
            {
                MainMoney += ProfitDonerShop;
                DonerShopTimer = 0;
            }
        }
    }

    private void SetMoneyForCigkofteShopUpgradePrice()
    {
        if (UpgradeCigkofte)
        {
            int x = MoneyForCigkofteShopUpgradePrice;
            MoneyForCigkofteShopUpgradePrice = Convert.ToInt32(x * 4);
            UpgradeCigkofte = false;
        }
    }

    private void GetCigkofteShopProfit()
    {
        if (CigkofteBought)
        {
            CigkofteShopTimer += Time.deltaTime;
            if (CigkofteShopTimer >= NecessaryTimeForCigkofteShop)
            {
                MainMoney += ProfitCigkofteShop;
                CigkofteShopTimer = 0;
            }
        }
    }

    private void SetMoneyForLahmacunShopUpgradePrice()
    {
        if (UpgradeLahmacun)
        {
            int x = MoneyForLahmacunShopUpgradePrice;
            MoneyForLahmacunShopUpgradePrice = Convert.ToInt32(x * 4);
            UpgradeLahmacun = false;
        }
    }

    private void GetLahmacunShopProfit()
    {
        if (LahmacunBought)
        {
            LahmacunShopTimer += Time.deltaTime;
            if (LahmacunShopTimer >= NecessaryTimeForLahmacunShop)
            {
                MainMoney += ProfitLahmacunShop;
                LahmacunShopTimer = 0;
            }
        }
    }

    private void SetMoneyForKebabShopUpgradePrice()
    {
        if (UpgradeKebab)
        {
            int x = MoneyForKebabShopUpgradePrice;
            MoneyForKebabShopUpgradePrice = Convert.ToInt32(x * 4);
            UpgradeKebab = false;
        }
    }

    private void GetKebabShopProfit()
    {
        if (KebabBought)
        {
            KebabShopTimer += Time.deltaTime;
            if (KebabShopTimer >= NecessaryTimeForKebabShop)
            {
                MainMoney += ProfitKebabShop;
                KebabShopTimer = 0;
            }
        }
    }

    int boolToInt(bool val)
    {
        if (val)
            return 1;
        else
            return 0;
    }

    bool intToBool(int val)
    {
        if (val != 0)
            return true;
        else
            return false;
    }
   
    void UpdatePlayerInfos()
    {
        Debug.Log(MoneyForOneTap);
        int x = MainMoney;
        PlayerPrefs.SetInt("MainMoney", x);
        x = MoneyForOneTap;
        PlayerPrefs.SetInt("MoneyForOneTap", x);
        x = MoneyForOneTapUpgradePrice;
        PlayerPrefs.SetInt("MoneyForOneTapUpgradePrice", x);
        x = ProfitFromOneTap;
        PlayerPrefs.SetInt("ProfitFromOneTap", x);

        x = ProfitToastShop;
        PlayerPrefs.SetInt("ProfitToastShop", x);
        x = MoneyForToastShopUpgradePrice;
        PlayerPrefs.SetInt("MoneyForToastShopUpgradePrice", x);
        bool b = UpgradeToast;
        PlayerPrefs.SetInt("UpgradeToast", boolToInt(b));
        b = ToastBought;
        PlayerPrefs.SetInt("ToastBought", boolToInt(b));
        float f = ToastShopTimer;
        PlayerPrefs.SetFloat("ToastShopTimer", f);
        x = NecessaryTimeForToastShop;
        PlayerPrefs.SetInt("NecessaryTimeForToastShop", x);

        x = ProfitDonerShop;
        PlayerPrefs.SetInt("ProfitDonerShop", x);
        x = MoneyForDonerShopUpgradePrice;
        PlayerPrefs.SetInt("MoneyForDonerShopUpgradePrice", x);
        b = UpgradeDoner;
        PlayerPrefs.SetInt("UpgradeDoner", boolToInt(b));
        b = DonerBought;
        PlayerPrefs.SetInt("DonerBought", boolToInt(b));
        f = DonerShopTimer;
        PlayerPrefs.SetFloat("DonerShopTimer", f);
        x = NecessaryTimeForDonerShop;
        PlayerPrefs.SetInt("NecessaryTimeForDonerShop", x);

        x = ProfitCigkofteShop;
        PlayerPrefs.SetInt("ProfitCigkofteShop", x);
        x = MoneyForCigkofteShopUpgradePrice;
        PlayerPrefs.SetInt("MoneyForCigkofteShopUpgradePrice", x);
        b = UpgradeCigkofte;
        PlayerPrefs.SetInt("UpgradeCigkofte", boolToInt(b));
        b = CigkofteBought;
        PlayerPrefs.SetInt("CigkofteBought", boolToInt(b));
        f = CigkofteShopTimer;
        PlayerPrefs.SetFloat("CigkofteShopTimer", f);
        x = NecessaryTimeForCigkofteShop;
        PlayerPrefs.SetInt("NecessaryTimeForCigkofteShop", x);

        x = ProfitLahmacunShop;
        PlayerPrefs.SetInt("ProfitLahmacunShop", x);
        x = MoneyForLahmacunShopUpgradePrice;
        PlayerPrefs.SetInt("MoneyForLahmacunShopUpgradePrice", x);
        b = UpgradeLahmacun;
        PlayerPrefs.SetInt("UpgradeLahmacun", boolToInt(b));
        b = LahmacunBought;
        PlayerPrefs.SetInt("LahmacunBought", boolToInt(b));
        f = LahmacunShopTimer;
        PlayerPrefs.SetFloat("LahmacunShopTimer", f);
        x = NecessaryTimeForLahmacunShop;
        PlayerPrefs.SetInt("NecessaryTimeForLahmacunShop", x);

        x = ProfitKebabShop;
        PlayerPrefs.SetInt("ProfitKebabShop", x);
        x = MoneyForKebabShopUpgradePrice;
        PlayerPrefs.SetInt("MoneyForKebabShopUpgradePrice", x);
        b = UpgradeKebab;
        PlayerPrefs.SetInt("UpgradeKebab", boolToInt(b));
        b = KebabBought;
        PlayerPrefs.SetInt("KebabBought", boolToInt(b));
        f = KebabShopTimer;
        PlayerPrefs.SetFloat("KebabShopTimer", f);
        x = NecessaryTimeForKebabShop;
        PlayerPrefs.SetInt("NecessaryTimeForKebabShop", x);
    }
}


