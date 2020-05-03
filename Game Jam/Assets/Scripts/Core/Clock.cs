using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] float healthAdded = 10f;
    [SerializeField] float turnSpeed = 5f;
    [SerializeField] AudioClip clockShotSound;

    PlayerHealth target;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        FaceTarget();
    }

    public void OnShot()
    {
        target.AddHealth(healthAdded);
        AudioSource.PlayClipAtPoint(clockShotSound, target.transform.position);
        Destroy(gameObject);
    }

    private void FaceTarget()
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, direction.y, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
    }
}
