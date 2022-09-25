using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject panelPausa;

    public GameObject pauseFirstButton;
    public GameObject storeButton;

    void Update()
    {

         
    } 

    public void PauseUnPause()
    {
        if(!panelPausa.activeInHierarchy)
        {
            panelPausa.SetActive(true);
            Time.timeScale = 0f;

            //clear selected object
            EventSystem.current.SetSelectedGameObject(null);
            //Set a new selected object
            EventSystem.current.SetSelectedGameObject(pauseFirstButton);
            storeButton.SetActive(false);
            pauseFirstButton.SetActive(false);

        }
       /* else
        {
            panelPausa.SetActive(false);
            Time.timeScale = 1f;
           
        }*/
    }

    public void ClosePauseMenu()
    {
        panelPausa.SetActive(false);
        pauseFirstButton.SetActive(true);
        storeButton.SetActive(true);
        Time.timeScale = 1f;
  
    }

   

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
