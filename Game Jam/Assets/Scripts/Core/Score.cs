using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    float score = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetScore()
    {
        return score;
    }

    public void IncreaseScore(float amount)
    {
        score += amount;
    }

    public void DecreaseScore(float amount)
    {
        score -= amount;
    }
}
