using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SettingsMenu : MonoBehaviour
{

   // public GameObject ;


    public TMP_Dropdown dropdown;
    public GameObject playerCam = null;
    public Slider fovSlider;
    public Slider sensSlider;


    Resolution[] resolutions;

    private void Start()
    {
        resolutions = Screen.resolutions;

        dropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].width == Screen.currentResolution.width)
            {
                currentResIndex = i;
            }
        }


        dropdown.AddOptions(options);
        dropdown.value = currentResIndex;
        dropdown.RefreshShownValue();

        fovSlider.value = PlayerPrefs.GetFloat("FOV");
        sensSlider.value = PlayerPrefs.GetFloat("Sens");
    }


    public void SetRes(int resIndex)
    {
        Resolution resolution = resolutions[resIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetQuality (int qualInd)
    {
        QualitySettings.SetQualityLevel(qualInd);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetSensitivity(float sens)
    {
        PlayerPrefs.SetFloat("Sens", sens);
        if (playerCam != null)
        {
            playerCam.SendMessage("SetSensitivity", sens);
        }
    }

    public void SetFOV(float fov)
    {
        PlayerPrefs.SetFloat("FOV", fov);    
    }

}
