using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Dash : MonoBehaviour
{
    float dashForce = 100f;
    float dashCooldown = 1f;
    float timeTillSelfDestruct = 20f;

    RigidbodyFirstPersonController target;
    bool isDashing = false;
    Rigidbody m_RigidBody;
    GameObject dashCanvas;
    AudioSource dashSound;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>().GetComponent<RigidbodyFirstPersonController>();
        m_RigidBody = target.GetComponent<Rigidbody>();
        StartCoroutine(SelfDestruct());
        FindObjectOfType<DashCanvas>().Enable();
        dashSound = FindObjectOfType<JumpDashSound>().GetComponent<AudioSource>();
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(timeTillSelfDestruct);
        FindObjectOfType<DashCanvas>().Disable();
        Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            if(isDashing == false)
            {
                m_RigidBody.drag = 0f;
                m_RigidBody.AddRelativeForce(new Vector3(0f, 0f, dashForce), ForceMode.Impulse);
                isDashing = true;
                StartCoroutine(StartDashCooldown());
                dashSound.Play();
            }
            else
            {
                return;
            }
        }
    }

    IEnumerator StartDashCooldown()
    {
        yield return new WaitForSeconds(dashCooldown);
        isDashing = false;
    }
}
