using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class mainmenu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        //EditorApplication.isPlaying = false;
    }

    public void PlayGameAsViewer()
    {
       SceneManager.LoadScene("Viewer");
    }

    public void PlayGameAsStreamer()
    {
        SceneManager.LoadScene("Streamer");
    }
}
