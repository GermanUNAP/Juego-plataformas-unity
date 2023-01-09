using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenGem : MonoBehaviour {

    public GameObject scoreBox;
    public AudioSource collectSound;
    public int score = 0;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 3000;
        collectSound.Play();
        Destroy(gameObject);
    }

}
