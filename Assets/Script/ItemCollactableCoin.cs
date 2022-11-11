using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableCoin : ItemCollatableBase
{
    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins();
    }
}
