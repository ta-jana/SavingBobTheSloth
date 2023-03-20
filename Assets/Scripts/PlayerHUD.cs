using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] private TextMeshPro currentHealthText;

    private PlayerStats stat;

    public void UpdateHealt(int currHealth)
    {
        currentHealthText.text = currHealth.ToString();
    }

}
