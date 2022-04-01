using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   public void PlayAGameStreamer()
   {
       SceneManager.LoadScene("Streamer");

   }
public void Quit()
{
    Application.Quit();
    UnityEditor.EditorApplication.isPlaying = false;
}
public void PlayAGameViewer()
   {
       SceneManager.LoadScene("Viewr");
   }
}
