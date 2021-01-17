using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basla : MonoBehaviour {     
    public void sahne1()
    {
        SceneManager.LoadScene("level1");
    }
    public void sahne2()
    {
        SceneManager.LoadScene("level2");
    }
    public void sahne3()
    {
        SceneManager.LoadScene("level3");
    }
    public void sahne4()
    {
        SceneManager.LoadScene("level4");
    }
    public void bolumgec()
    {
        SceneManager.LoadScene("bolumkilit");
    }
}
