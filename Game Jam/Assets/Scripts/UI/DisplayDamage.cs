using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas damageTakenCanvas;
    [SerializeField] float impactTime = 0.3f;
    [SerializeField] Canvas damageDoneCanvas;

    // Start is called before the first frame update
    void Start()
    {
        damageTakenCanvas.enabled = false;
        damageDoneCanvas.enabled = false;
    }

    public void ShowDamageImpact()
    {
        StartCoroutine(ShowDamage());
    }

    IEnumerator ShowDamage()
    {
        damageTakenCanvas.enabled = true;
        yield return new WaitForSeconds(impactTime);
        damageTakenCanvas.enabled = false;
    }

    public void ShowDamageDone()
    {
        StartCoroutine(ShowHitMarker());
    }

    IEnumerator ShowHitMarker()
    {
        damageDoneCanvas.enabled = true;
        yield return new WaitForSeconds(impactTime);
        damageDoneCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
