using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthScript : MonoBehaviour
{
    public static healthScript S2;
    public int health;
    Text newText;
    // Start is called before the first frame update
    void Start()
    {
        newText = GetComponent<Text>();
        health = 3;
        S2 = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateHealth(int updateBy)
    {
        health = health + updateBy;
        newText.text = "Health: " + health;
    }
}
