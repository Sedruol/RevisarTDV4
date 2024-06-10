using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public TextMeshProUGUI tmpTimerLose;
    public TextMeshProUGUI tmpScoreLose;
    public TextMeshProUGUI tmpTimer;
    public TextMeshProUGUI tmpScore;
    public GameObject gameplayHUD;
    public GameObject loseMenu;
    public static float timer;
    float score = 0;
    int minutes;
    int seconds;
    public float GetScore() { return score; }
    public void SetScore(float _s) { score = _s; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        timer = 0f;
        loseMenu.SetActive(false);
        gameplayHUD.SetActive(true);
    }
    public void LoadLoseMenu()
    {
        Time.timeScale = 0;
        tmpTimerLose.text += tmpTimer.text;
        tmpScoreLose.text += tmpScore.text;
        gameplayHUD.SetActive(false);
        loseMenu.SetActive(true);
    }
    public void AddPoints(float p)
    {
        float temp = GetScore();
        temp += p;
        SetScore(temp);
        tmpScore.text = GetScore().ToString("00000");
        Debug.Log(GetScore());
    }
    private void Update()
    {
        timer += Time.deltaTime;
        minutes = Mathf.FloorToInt(timer / 60);
        seconds = Mathf.FloorToInt(timer % 60);
        tmpTimer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        if (Input.GetMouseButtonDown(1))
        {
            LoadLoseMenu();
        }
    }
}