using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public int nextSceneLoad;
	// Use this for initialization
	void Start () {        
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;        
    }   
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {            
            if(SceneManager.GetActiveScene().buildIndex == 5)
            {
                Debug.Log("Oyunu kazandınız.");
                SceneManager.LoadScene("anamenu");
            }
            else
            {
                SceneManager.LoadScene(nextSceneLoad);
                if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }
            }
            
        }
    }
}
