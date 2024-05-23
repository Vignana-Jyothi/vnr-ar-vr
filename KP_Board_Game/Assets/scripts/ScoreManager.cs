using UnityEngine;
using UnityEngine.UI;

using TMPro; // Add this line to import the TextMeshPro namespace


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        Debug.Log("Called Score Manager");
        if (instance == null)
        {
            instance = this;
            Debug.Log("new instane is created");
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
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
