using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonOptions : MonoBehaviour
{
    //public void PlayGame()
    //{
    //    SceneManager.LoadScene(2);
    //}
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Track1()
    {
        SceneManager.LoadScene(2);
    }
    public void Track2()
    {
        SceneManager.LoadScene(3);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
