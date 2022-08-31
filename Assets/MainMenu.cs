using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    public void EscenaJuego() {
        SceneManager.LoadScene("GameScreen");
    }
    public void Config() {
        SceneManager.LoadScene("Settings");
    }
    public void Salir() {
        Application.Quit();
    }
    public void Home() {
        SceneManager.LoadScene("MainMenu");
    }
    public void BtnLink(string link){
        Application.OpenURL(link);
    }
}


