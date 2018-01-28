using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour
{

    public GameObject pauseMenu;
    private bool isEnabled = false;

    void Update()
    {
        // Enable pause menu
        if (Input.GetKeyDown(KeyCode.Escape) && !isEnabled)
        {
            pauseMenu.SetActive(true);
            isEnabled = true;
        }

        // disable pause menu
        else if (Input.GetKeyDown(KeyCode.Escape) && isEnabled)
        {
            pauseMenu.SetActive(false);
            isEnabled = false;
        }
    }

}