using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private GameObject GameWinnerScreen;
    [SerializeField] private TMP_Text tmpScore;
    [SerializeField] private TMP_Text tmpTotalScore;
    [SerializeField] private int scorePerSecond = 10;
    private int score;
    private int totalScore;
    public int GetTotalScore() { return totalScore; }
    public void SetTotalScore(int s) { totalScore = s; }
    private float timer;
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }
    private void Start()
    {
        GameOverScreen.SetActive(false);
        GameWinnerScreen.SetActive(false);
    }
    public void ShowGameOverScreen()
    {
        GameOverScreen.SetActive(true);
    }
    public void ShowGameWinnerScreen()
    {
        GameWinnerScreen.SetActive(true);
    }
    private void UpdateScore()
    {
        timer += Time.deltaTime;
        score = (int)(timer * scorePerSecond);
        tmpScore.text = score.ToString("00000");
    }
    public void UpdateTotalScore()
    {
        int temp = GetTotalScore();
        temp += score;
        SetTotalScore(temp);
        score = 0;
        timer = 0;
        tmpTotalScore.text = "Your total score was " + GetTotalScore().ToString("00000");
    }
    void Update()
    {
        if (!RibbitPlayer.isDie || !RibbitPlayer.isWin)
        {
            UpdateScore();
        }
    }
}