using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public GameObject pauseMenu;
   private bool ActivatePause;
   private void Update ()
   {
       if (Input.GetKeyDown(KeyCode.Escape))
       {
           ActivatePause = !ActivatePause;
           pauseMenu.SetActive(ActivatePause);
       }
   }
   public void startGame()
   {
       SceneManager.LoadScene(0);
   }
   public void exitOptionsMenu (GameObject obj)
   {
       obj.SetActive (false);
   }
    public void activateOptionsMenu (GameObject obj)
   {
       obj.SetActive (true);
   }


}
