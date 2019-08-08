using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SoundManagerScript.S.PlaySound1();

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SoundManagerScript.S.PlaySound2();

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SoundManagerScript.S.PlaySound3();


        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SoundManagerScript.S.PlaySound4();

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SoundManagerScript.S.PlaySound5();

        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SoundManagerScript.S.PlaySound6();

        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SoundManagerScript.S.PlaySound7();

        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            SoundManagerScript.S.PlaySound8();

        }
        if (Input.GetKeyDown (KeyCode.Alpha9))
        {
            SoundManagerScript.S.PlaySound9();

        }

    }
}
