using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fov : MonoBehaviour
{

    public float FOV = 60f;
    public Camera cam;

    public Text fovText;

    void Start()
    {
        FOV = PlayerPrefs.GetFloat("FOV");
    }

    void Update()
    {
        fovText.text = FOV.ToString();
    }

    public void adjustFov (float newFov)
    {
        FOV = newFov;
        cam.fieldOfView = newFov;
        PlayerPrefs.SetFloat("FOV", newFov);
    }
}
