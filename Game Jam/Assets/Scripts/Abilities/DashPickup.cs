﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPickup : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (player.GetComponent<Dash>() != null)
            {
                Destroy(player.GetComponent<Dash>());
            }
            player.AddComponent<Dash>();
            Destroy(gameObject);
        }
    }
}
