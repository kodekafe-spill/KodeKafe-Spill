using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fov : MonoBehaviour
{

    public float FOV;
    public Camera cam;

    void Start()
    {
        FOV = PlayerPrefs.GetFloat("FOV");
    }

    public void adjustFov (float newFov)
    {
        FOV = newFov;
        cam.fieldOfView = newFov;
        PlayerPrefs.SetFloat("FOV", newFov);
    }
}
