using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class mainmenu : MonoBehaviour
{
   public void PlayAGameStreamer()
   {
       SceneManager.LoadScene("Streamer");

   }
public void Quit()
{
    Application.Quit();
    //EditorApplication.isPlaying = false;
}
public void PlayAGameViewer()
   {
       SceneManager.LoadScene("Viewr");
   }
}
