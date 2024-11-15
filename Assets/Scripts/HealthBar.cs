using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private PlayerHealth playerHealth_Script;
    [SerializeField] private Slider healthBar;
    [SerializeField] private Gradient gradient;
    [SerializeField] private Image Fill;

    private void Update()
    {
        health = playerHealth_Script.health;
        healthBar.value = health;
        Fill.color = gradient.Evaluate(healthBar.normalizedValue);
    }
}
