using UnityEngine;
using UnityEngine.UI;

using TMPro;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public GameObject winText;
    private int score = 0;
    private static int MAX_COINS = 4; 

    void Awake()
    {
        Debug.Log("Called Score Manager");
        if (instance == null)
        {
            instance = this;
            Debug.Log("new instane is created");
            winText.gameObject.SetActive(false);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
        if (score == MAX_COINS) {
            Debug.Log("You Win");
            winText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
