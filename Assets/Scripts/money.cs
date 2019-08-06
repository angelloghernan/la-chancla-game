using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    bool collected = false;
    Renderer renderer;
    Vector3 degrees;
    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<Renderer>();
        StartCoroutine(rotateMoney());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator rotateMoney()
    {
        while (collected == false)
        {

                degrees = new Vector3(0,3,0);
                this.transform.Rotate(degrees,Space.Self);
                yield return new WaitForEndOfFrame();
        


            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collected = true;
        renderer.enabled = false;
    }
    
    
}
