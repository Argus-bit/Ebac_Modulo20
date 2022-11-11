using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EBAC.Core.Singleton;
using TMPro;

public class UiInGameManager : Singleton<UiInGameManager>
{
    public TextMeshProUGUI uiTextCoins;
    public TextMeshProUGUI uiTextFruit;
    public static void UpdateTextFruit(string s)
    {
        Instance.uiTextFruit.text = s;
    }
    public static void UpdateTextCoins(string s)
    {
        Instance.uiTextCoins.text = s;
    }
}