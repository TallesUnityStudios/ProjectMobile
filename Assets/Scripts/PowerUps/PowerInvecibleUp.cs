using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerInvecibleUp : PowerUpBase
{
    protected override void StartPowerUp()
    {
        base.StartPowerUp();
        PlayerController.Instance.SetPowerUpText("Invecible");
        PlayerController.Instance.SetInvincible(true);
    }

    protected override void EndPowerUp()
    {
        base.EndPowerUp();
        PlayerController.Instance.SetInvincible(false);
        PlayerController.Instance.SetPowerUpText("");
    }
}
