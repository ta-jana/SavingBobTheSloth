using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{

    private PlayerHUD hud;

    private void Start()
    {
        GetReference();
    }

    private void GetReference()
    {
        hud = GetComponent<PlayerHUD>();

    }

    public override void CheckHealth()
    {
        base.CheckHealth();
        hud.UpdateHealt(health);
    }
}
