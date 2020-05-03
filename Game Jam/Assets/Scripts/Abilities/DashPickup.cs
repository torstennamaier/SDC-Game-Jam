using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPickup : MonoBehaviour
{
    GameObject player;
    public AudioClip audioClip;

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
            AudioSource.PlayClipAtPoint(audioClip, other.transform.position);
            if (player.GetComponent<Dash>() != null)
            {
                Destroy(player.GetComponent<Dash>());
            }
            player.AddComponent<Dash>();
            Destroy(gameObject);
        }
    }
}
