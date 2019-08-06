using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyUI : MonoBehaviour
{
    Text nText;
    public static moneyUI S;
    public int totalMoney = 0;
    // Start is called before the first frame update
    void Start()
    {
        nText = GetComponent<Text>();
        S = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addMoney(int amount)
    {
        totalMoney += amount;
        nText.text = "Money: " + totalMoney + "$";
    }

}

