using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collide r detecetd.");

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("It is a player.");
            Destroy(gameObject);
            ScoreManager.instance.AddScore(1);
        }
        else if (other.gameObject.CompareTag("GoldenBall"))
        {
            Debug.Log("It is a GoldenBall.");
            Destroy(gameObject);
            ScoreManager.instance.AddScore(3);
        }
        else {
            Debug.Log("Not player.");
            Debug.Log(gameObject);

        }
    }
}