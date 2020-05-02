using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    Score target;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>().GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = Mathf.Floor(target.GetScore()).ToString();
    }
}
