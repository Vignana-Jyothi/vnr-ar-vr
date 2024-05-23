using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameoutArea : MonoBehaviour
{
    public TextMeshProUGUI winText;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ball fell off the board.");

        if (other.gameObject.CompareTag("Player"))
        {
            winText.text = "Oops.. That's Sad!!";
            winText.gameObject.SetActive(true);
        }
    }
}
