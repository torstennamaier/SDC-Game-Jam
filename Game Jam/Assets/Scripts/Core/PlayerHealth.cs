using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float healthPoints = 100f;

    bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(float damage)
    {
        healthPoints -= damage;
        if (healthPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }

    public void AddHealth(float healthAdded)
    {
        healthPoints += healthAdded;
    }

    public float GetHealth()
    {
        return healthPoints;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == true) return;
        healthPoints -= Time.deltaTime;
        if (healthPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
            isDead = true;
        }
    }
}
