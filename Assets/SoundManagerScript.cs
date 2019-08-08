using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update


    // declaring a singleton
    public static SoundManagerScript S;



    // Declare the sound objects

    public AudioSource sound1;
    public AudioSource sound2;
    public AudioSource sound3;
    public AudioSource sound4;
    public AudioSource sound5;
    public AudioSource sound6;
    public AudioSource sound7;
    public AudioSource sound8;
    public AudioSource sound9;
    public AudioSource sound10;

    void Start()
    {
        S = this;
    }

    public void PlaySound1()
    {
        sound1.Play();
    }
    public void PlaySound2()
    {
        sound2.Play();
    }

    public void PlaySound3()
    {
        sound3.Play();
    }
    public void PlaySound4()
    {
        sound4.Play();
    }
    public void PlaySound5()
    {
        sound5.Play();
    }
    public void PlaySound6()
    {
        sound6.Play();
    }
    public void PlaySound7()
    {
        sound7.Play();
    }
    public void PlaySound8()
    {
        sound8.Play();
    }
    public void PlaySound9()
    {
        sound9.Play();
    }
    public void PlaySound10()
    {
        sound10.Play(); 
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            PlaySound1();
        }
    }
}
