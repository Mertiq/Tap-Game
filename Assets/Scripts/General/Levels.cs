using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public static int PlayerLevel = 1;
    public static int ToastShopLevel = 0;
    public static int DonerShopLevel = 0;
    public static int CigkofteShopLevel = 0;
    public static int LahmacunShopLevel = 0;
    public static int KebabShopLevel = 0;

    private void Start()
    {
        if(PlayerPrefs.GetInt("PlayerLevel") != 0)
            PlayerLevel = PlayerPrefs.GetInt("PlayerLevel");
        ToastShopLevel = PlayerPrefs.GetInt("ToastShopLevel");
        DonerShopLevel = PlayerPrefs.GetInt("DonerShopLevel");
        CigkofteShopLevel = PlayerPrefs.GetInt("CigkofteShopLevel");
        LahmacunShopLevel = PlayerPrefs.GetInt("LahmacunShopLevel");
        KebabShopLevel = PlayerPrefs.GetInt("KebabShopLevel");
    }

    private void Update()
    {
        int x = PlayerLevel;
        PlayerPrefs.SetInt("PlayerLevel",x );
        x = ToastShopLevel;
        PlayerPrefs.SetInt("ToastShopLevel", x);
        x = DonerShopLevel;
        PlayerPrefs.SetInt("DonerShopLevel", x);
        x = CigkofteShopLevel;
        PlayerPrefs.SetInt("CigkofteShopLevel", x);
        x = LahmacunShopLevel;
        PlayerPrefs.SetInt("LahmacunShopLevel", x);
        x = KebabShopLevel;
        PlayerPrefs.SetInt("KebabShopLevel", x);
    }
}
