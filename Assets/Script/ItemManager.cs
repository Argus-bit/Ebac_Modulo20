using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EBAC.Core.Singleton;

public class ItemManager : Singleton<ItemManager>
{
    public SOint coins;
    public TextMeshProUGUI uiTextCoins;
    public TextMeshProUGUI uiTextFruit;

    private void Start()
    {
        Reset();
    }

    /*private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else Destroy(gameObject);
    }*/
    private void Reset()
    {
        coins.value = 0;
        coins.fruit = 0;
        UpdateUI();
    }
    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
        UpdateUI();
    }
    public void AddSberry(int amount = 1)
    {
        coins.fruit += amount;
        UpdateUI();
    }
    private void UpdateUI()
    {
        //uiTextCoins.text = coins.value.ToString();
        //UiInGameManager.UpdateTextCoins(coins.value.ToString());
    }
}