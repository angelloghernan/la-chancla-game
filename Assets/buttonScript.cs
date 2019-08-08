using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// for scene manager

public class buttonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
    }






    // button accss

      public void DidYouPressAButton()
    {
        Debug.Log("You pressed a button");
    }


    // Scene Manager
    public void GoToGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoToStartScene()
    {
        SceneManager.LoadScene("TitleScreen");

    }
    public void GoToHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
