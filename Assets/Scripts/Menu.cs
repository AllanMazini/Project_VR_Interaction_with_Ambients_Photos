using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public GameObject pauseMenu;
    private bool activePausedMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            activePausedMenu = !activePausedMenu;
            pauseMenu.SetActive(activePausedMenu);
        }

    }

    public void sala()
    {
        SceneManager.LoadScene(1);    
    }


    // public void activeOption(GameObject go)
    // {
    //     go.SetActive(true);
    // }

    // public void exitOption(GameObject go)
    // {
    //     go.SetActive(false);
    // }

    public void exitGame()
    {
        Application.Quit();
    }

}
