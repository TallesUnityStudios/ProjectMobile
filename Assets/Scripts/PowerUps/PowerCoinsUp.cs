using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCoinsUp : PowerUpBase
{
    [Header("PowerCoinsUp Settings")]
    public float sizeAmount = 7;

    protected override void StartPowerUp()
    {
        base.StartPowerUp();
        PlayerController.Instance.ChangeCoinsCollectorSize(sizeAmount);
    }

    protected override void EndPowerUp()
    {
        base.EndPowerUp();
        PlayerController.Instance.ChangeCoinsCollectorSize(1);
    }
}
