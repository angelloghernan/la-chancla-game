    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float thrust;
   
    private Rigidbody2D rb;
    public GameObject player;
    public Transform posPlayer;
    void Start()
    {
        posPlayer = player.GetComponent<Transform>();
        rb = this.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.Normalize(posPlayer.position - transform.position) * thrust);
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "enemy")
        {
            if(collision.gameObject.tag == "Player")
            {
                healthScript.S2.updateHealth(-1);
                SoundManagerScript.S.PlaySound10();

            }
            Destroy(this.gameObject);
        }
    }
}
