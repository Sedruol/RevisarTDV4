using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void LoadScene(int n)
    {
        Time.timeScale = 1f;
        if (SceneManager.GetActiveScene().buildIndex + n == 0)
            GameManager.Instance.GetTotalScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + n);
    }
    public void QuitGame()
    {
        Debug.Log("cerrando juego");
        Application.Quit();
    }
}