using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    public GameObject menu;
    private bool PauseMenu = false; // Big pause menu thing

    public void Exit()
    {
        PauseMenu = false;
        Cursor.visible = false;
        Time.timeScale = 1;
        menu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            PauseMenu = !PauseMenu;
            Time.timeScale = 0;
            menu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            if (PauseMenu != true)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Exit();
            }
        }
    }
}