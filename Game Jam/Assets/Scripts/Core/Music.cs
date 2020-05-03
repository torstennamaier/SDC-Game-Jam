using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource lowIntensityMusic;
    [SerializeField] AudioSource highIntensityMusic;
    [SerializeField] float timeToChange = 30f;

    GameObject player;
    bool isLowIntensity = true;
    bool isHighIntensity = false;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        lowIntensityMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        float health = player.GetComponent<PlayerHealth>().GetHealth();
        if (health < timeToChange && isHighIntensity == false) 
        {
            highIntensityMusic.time = Mathf.Floor(lowIntensityMusic.time * (40.417f / 53.889f));
            highIntensityMusic.Play();
            lowIntensityMusic.Stop();
            isLowIntensity = false;
            isHighIntensity = true;
        }
        if (health > timeToChange && isLowIntensity == false)
        {
            lowIntensityMusic.time = Mathf.Floor(highIntensityMusic.time * (53.889f / 40.417f));
            lowIntensityMusic.Play();
            highIntensityMusic.Stop();
            isLowIntensity = true;
            isHighIntensity = false;
        }
    }
}
