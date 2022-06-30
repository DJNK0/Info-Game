using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthbar;

    public void UpdateHealth(float fraction)
    {
        healthbar.fillAmount = fraction;
        Debug.Log(healthbar.fillAmount);
    }
}
