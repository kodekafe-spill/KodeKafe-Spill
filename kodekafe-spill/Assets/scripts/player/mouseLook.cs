using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouseLook : MonoBehaviour
{

    public float mouseSens = 500f;

    public Transform playerBody;

    float xRotation = 0f;

    public float _upRecoil;
    public float _sideRecoil;

    public void SetSensitivity(float sens)
    {
        mouseSens = sens;
    }

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseSens = PlayerPrefs.GetFloat("Sens");
    }

    void Update()
    { 
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= mouseY + _upRecoil;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation + _sideRecoil, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        _upRecoil = 0f;
        _sideRecoil = 0f;

        
    }
}
