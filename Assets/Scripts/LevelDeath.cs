using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelDeath : MonoBehaviour {

    public GameObject youFell;
    public GameObject LevelAudio;
    public GameObject scoreBox;

    void OnTriggerEnter()
    {

        StartCoroutine(YouFellOff());
        GlobalScore.currentScore = 0;
    }

    IEnumerator YouFellOff(){
        LevelAudio.SetActive(false);
        youFell.SetActive(true);
        yield return new WaitForSeconds(3); 
        SceneManager.LoadScene(2);
    }

}
