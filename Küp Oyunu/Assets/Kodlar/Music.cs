using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{   
    public AudioClip Music1;
    public AudioSource küphareketsesi;       
    // Use this for initialization
    void Start()
    {
        //küphareketsesi = GetComponent<AudioSource>();
        //küphareketsesi.Play();
    }

    // Update is called once per frame
    void Update()
    {
        küphareketsesi.clip = Music1;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)){                                  
            if (!küphareketsesi.isPlaying)
            {              
                küphareketsesi.Play();                         
            }
        }
    }    
}