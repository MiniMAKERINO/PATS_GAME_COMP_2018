using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuStart : MonoBehaviour {



    public void StartGame(){

        SceneManager.LoadScene("House");
    }

    public void QuitGame(){

        Application.Quit();
        Debug.Log("Quit Application");
    }
}
