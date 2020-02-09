using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{

    public GameObject menu;
    public bool PauseMenu = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu = !PauseMenu;
            Time.timeScale = 0;
            menu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            if (PauseMenu != true)
            {
                Time.timeScale = 1;
                menu.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
