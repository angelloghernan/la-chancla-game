using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money2Script : MonoBehaviour
{
    GameObject bill;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject bill = this.transform.parent.gameObject;
        Destroy(bill);
        moneyUI.S.addMoney(5);
        
    }
}

