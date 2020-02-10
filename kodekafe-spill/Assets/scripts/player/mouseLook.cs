using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouseLook : MonoBehaviour
{

    public float mouseSens = 500f;

    public Transform playerBody;

    float xRotation = 0f;

    public Text text;

    public float _upRecoil;
    public float _sideRecoil;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        mouseSens = PlayerPrefs.GetFloat("Sens");
    }

    public void adjustSens(float newSens)
    {
        mouseSens = newSens;
        PlayerPrefs.SetFloat("Sens", newSens);
    }

    void Update()
    {
        text.text = mouseSens.ToString();
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
