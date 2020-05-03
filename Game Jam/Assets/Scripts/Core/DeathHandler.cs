﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{

    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleDeath()
    {
        AudioSource.PlayClipAtPoint(audioClip, transform.position);
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
