using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    PlayerHealth target;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = Mathf.Floor(target.GetHealth()).ToString();
    }
}
