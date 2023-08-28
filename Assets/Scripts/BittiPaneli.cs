using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BittiPaneli : MonoBehaviour
{
    public void EvetButonu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Main");
    }

    public void Hayýr_Butonu()
    {
        Application.Quit();
    }
}
