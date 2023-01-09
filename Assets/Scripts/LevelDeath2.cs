using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelDeath2 : MonoBehaviour {

    public GameObject youFell;
    public GameObject LevelAudio;
    public GameObject scoreBox;
    public static int levelDeat = 0;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore = 0;
        StartCoroutine(YouFellOff());
        
    }

    IEnumerator YouFellOff(){
        LevelAudio.SetActive(false);
        youFell.SetActive(true);
        yield return new WaitForSeconds(3); 
        SceneManager.LoadScene(5);
    }

}
