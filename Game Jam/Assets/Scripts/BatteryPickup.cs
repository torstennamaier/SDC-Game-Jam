using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float angleAmount = 70f;
    [SerializeField] float intensityAmount = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<Flashlight>().RestoreLightAngle(angleAmount);
            FindObjectOfType<Flashlight>().RestoreLightIntensity(intensityAmount);
            Destroy(gameObject);
        }
    }
}
