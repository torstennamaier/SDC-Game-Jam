using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Footstep : MonoBehaviour
{
    RigidbodyFirstPersonController player;
    bool isPlaying = false;

    [SerializeField] AudioSource footstepClip;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<RigidbodyFirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.Grounded == true && player.Velocity.magnitude > Mathf.Epsilon && isPlaying == false) 
        {
            footstepClip.Play();
            isPlaying = true;
            return;
        }
        else if (player.Velocity.magnitude <= Mathf.Epsilon)
        {
            footstepClip.Stop();
            isPlaying = false;
        }
        else if (player.Jumping)
        {
            footstepClip.Stop();
            isPlaying = false;
        }

    }
}
