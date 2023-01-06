using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCoin : PowerUpBase
{
    public float sizeAmount = 7;
    protected override void EndPowerUp()
    {
        base.EndPowerUp();
        PlayerController.Instance.ChangeCoinCollactorSize(1);
    }
}
