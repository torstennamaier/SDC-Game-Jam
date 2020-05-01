using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoint = 100f;

    bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        if (isDead == true)
        {
            enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;

        }
        hitPoint -= damage;
        BroadcastMessage("OnDamageTaken");
        if (hitPoint <= 0)
        {
            isDead = true;
            GetComponent<EnemyAI>().isDead = true;
            GetComponent<Animator>().SetTrigger("Die");
        }
    }
}
