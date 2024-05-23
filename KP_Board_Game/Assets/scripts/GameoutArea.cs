using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameoutArea : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ball fell off the board.");

        if (other.gameObject.CompareTag("Player"))
        {
            gameOverText.text = "Oops.. That's Sad!!";
            gameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
