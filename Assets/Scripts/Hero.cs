using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    public Slider healthbarSlider;
    public Slider staminabarSlider;
    public float maxHealth = 100;
    public float maxStamina = 100;
    public float minimumHealth;
    public float minimumStamina;
    public float damage;

    private float currentHealth;
    private float currentStamina;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        currentStamina = maxStamina;
        healthbarSlider.value = currentHealth / maxHealth; //set it to max health
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //handle what happens when we get to zero
    public void OnDamageClick()
    {
        currentHealth -= damage;
        healthbarSlider.value = currentHealth / maxHealth;
    }

    public void OnHealthChanged()
    {
        Debug.Log("Health has changed." + healthbarSlider.value.ToString());
    }

    public void OnStaminaChanged()
    {
        Debug.Log("Stamina has changed." + staminabarSlider.value.ToString());
    }
}
