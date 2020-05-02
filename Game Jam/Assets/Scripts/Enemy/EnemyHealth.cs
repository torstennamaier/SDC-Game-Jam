using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoint = 100f;
    [SerializeField] float scoreIncrease = 1f;
    [SerializeField] GameObject deathPickUp;
    [SerializeField] float timeTillDestroy = 2f;

    Transform target;
    bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>().transform;
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
            return;
        }
        hitPoint -= damage;
        BroadcastMessage("OnDamageTaken");
        if (hitPoint <= 0)
        {
            isDead = true;
            GetComponent<EnemyAI>().isDead = true;
            GetComponent<Animator>().SetTrigger("Die");
            GetComponent<CapsuleCollider>().enabled = false;
            StartCoroutine(DestroyEnemy());
            target.GetComponent<Score>().IncreaseScore(scoreIncrease);
        }
    }

    IEnumerator DestroyEnemy()
    {
        yield return new WaitForSeconds(timeTillDestroy);
        Instantiate(deathPickUp, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
