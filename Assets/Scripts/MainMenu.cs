using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject ControlsGuide;

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void Levels()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Options()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Credits()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void Level1()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void Level2()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void Level3()
    {
        SceneManager.LoadSceneAsync(6);
    }


    //public void Awake()
    //{
    //    // Need to add the "if button pressed than set to active thing. Plus a cross it top right to go back. 
    //    ControlsGuide.SetActive(true);
    //}


}
