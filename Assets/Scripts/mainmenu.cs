using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   public void PlayAGame()
   {
       SceneManager.LoadScene("Streamer");

   }
public void Quit()
{
    Application.Quit();
    UnityEditor.EditorApplication.isPlaying = false;
}
}
