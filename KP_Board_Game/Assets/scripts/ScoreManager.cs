using UnityEngine;
using UnityEngine.UI;

using TMPro;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public GameObject winText;
    private int coinsCollected = 0;
    private int score = 0;
    private static int MAX_COINS = 4; 
    public AudioSource coinSound;
    public AudioSource goldenBallCoinSound;

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
        if (amount == 1) {
            coinSound.Play();
        } else {
            goldenBallCoinSound.Play();
        }
        coinsCollected++;
        UpdateScoreText();
        if (coinsCollected == MAX_COINS) {
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
