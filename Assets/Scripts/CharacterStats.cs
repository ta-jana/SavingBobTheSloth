using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    [SerializeField] protected int health;
    [SerializeField] protected int maxHealth;

    [SerializeField] protected bool isDead;

    private void Start()
    {
        InitVariables();
    }

    public virtual void CheckHealth()
    {
        if(health <= 0)
        {
            health = 0;
            Die();

        }else if(health >= maxHealth)
        {
            health = maxHealth;
        }

    }

    public void Die()
    {
        isDead = true;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        CheckHealth();
    }

    public void InitVariables()
    {
        maxHealth = 100;
        health = 100;
        isDead = false;
    }
}
