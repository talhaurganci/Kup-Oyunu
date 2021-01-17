using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour {

    public Button[] lvlButtons;    

	// Use this for initialization
	void Start () {
       
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for(int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 2 > levelAt)
                lvlButtons[i].interactable = false;
        }
	}
    public void Reset()
    {        
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("bolumkilit");
    }
}
