using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemScript : MonoBehaviour
{
    public itemScript s;
    public GameObject item;
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
        if(this.gameObject.name == "keys")
        {
            movementTest.S.collectedKeys = true;
        }
        else if(this.gameObject.name == "phone")
        {
            movementTest.S.collectedKeys = true;
        }

        Destroy(this.gameObject);
    }
}
