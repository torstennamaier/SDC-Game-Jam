using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] float healthAdded = 10f;

    PlayerHealth target;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnShot()
    {
        target.AddHealth(healthAdded);
        Destroy(gameObject);
    }
}
