using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class DoubleJump : MonoBehaviour
{
    [SerializeField] float doubleJumpForce = 100f;
    [SerializeField] float timeTillSelfDestruct = 10f;

    RigidbodyFirstPersonController target;
    bool doubleJump = false;
    Rigidbody m_RigidBody;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>().GetComponent<RigidbodyFirstPersonController>();
        m_RigidBody = target.GetComponent<Rigidbody>();
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(timeTillSelfDestruct);
        Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if(target.Jumping && doubleJump == false)
            {
                m_RigidBody.drag = 0f;
                m_RigidBody.velocity = new Vector3(m_RigidBody.velocity.x, 0f, m_RigidBody.velocity.z);
                m_RigidBody.AddForce(new Vector3(0f, doubleJumpForce, 0f), ForceMode.Impulse);
                doubleJump = true;
            }
            else
            {
                return;
            }
        }
        if (target.Grounded)
        {
            doubleJump = false;
        }
    }
}
