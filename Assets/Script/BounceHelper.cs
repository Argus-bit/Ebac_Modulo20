using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BounceHelper : PowerUpBase
{
    [Header("Animation")]
    public float scaleDuration = 2f;
    public float scaleBounce = 1.2f;
    public Ease ease = Ease.OutBack;


    protected override void StartPowerUp()
    {
        base.StartPowerUp();
        PlayerController.Instance.Bounce();
        Bounce();
    }
    public void Bounce()
    {
        transform.DOScale(scaleBounce, scaleDuration).SetEase(ease).SetLoops(2, LoopType.Yoyo);
    }
}
