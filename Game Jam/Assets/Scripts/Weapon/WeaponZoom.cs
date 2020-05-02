using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] float fieldOfView = 60f;
    [SerializeField] float fieldOfViewZoom = 30f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = 1f;

    RigidbodyFirstPersonController fpsController;

    // Start is called before the first frame update
    void Start()
    {
        fpsController = GetComponentInParent<RigidbodyFirstPersonController>();
    }

    private void OnDisable()
    {
        ZoomOut();
    }

    // Update is called once per frame
    void Update()
    {
        ZoomOut();

        if (Input.GetButton("Fire2"))
        {
            ZoomIn();
        }
    }

    private void ZoomOut()
    {
        mainCamera.fieldOfView = fieldOfView;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
    }

    private void ZoomIn()
    {
        mainCamera.fieldOfView = fieldOfViewZoom;
        fpsController.mouseLook.XSensitivity = zoomInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInSensitivity;
    }
}
