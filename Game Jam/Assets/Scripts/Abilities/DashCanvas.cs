using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Disable()
    {
        GetComponent<Canvas>().enabled = false;
    }

    public void Enable()
    {
        GetComponent<Canvas>().enabled = true;
    }
}
