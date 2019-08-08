using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementTest : MonoBehaviour
{
    public GameObject sprite;
    float speed = .1f;
    float speedMultiplier = 1.0f;
    public Rigidbody2D rb;
    public int itemCount = 0;
    Vector2 newpos;
    Animator animator;
    bool isMoving = false;
    public inventory f;
    public Renderer renderer;
    public bool collectedKeys;
    public bool collectedPhone;
    public bool collectedFlowers;
    public static movementTest S;
    public int radius;
    public bool isAlive;
    private bool isSprint = false;
    GameObject[] nearbyEnemies;
    // Start is called before the first frame update
    void Start()
    {
        collectedFlowers = false;
        collectedKeys = false;
        collectedPhone = false;
        S = this;
        rb = GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
        renderer = this.GetComponent<SpriteRenderer>();
        renderer.receiveShadows = true;
        renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        radius = 4;
        isAlive = true;
        StartCoroutine(checkNearbyEnemies());
        StartCoroutine(SoundMaker());
    }

    // Update is called once per frame
    void Update()
    {
        newpos = this.transform.position;
        newpos.x += Input.GetAxisRaw("Horizontal") * speed * speedMultiplier;
        newpos.y += Input.GetAxisRaw("Vertical") * speed * speedMultiplier;
        if(newpos.x != this.transform.position.x || newpos.y != this.transform.position.y)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        rb.MovePosition(newpos);


        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = .2f;
            radius *= 2;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = .1f;
            radius /= 2;
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            speed = .05f;
            radius /= 2;
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            speed = .1f;
            radius *= 2;
        }

        if (Input.GetKey(KeyCode.W))
        {
            
            changeDirection(1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            changeDirection(0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            changeDirection(3);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            changeDirection(2);
        }
        if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            isMoving = false;
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        {
            isMoving = false;
        }
        if (!isMoving)
        {
            changeDirection(4);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            MakeWalkingTileNoise();
        }

    }
    private IEnumerator checkNearbyEnemies()
    {
        while(isAlive)
        {
            nearbyEnemies = GameObject.FindGameObjectsWithTag("enemy");
            foreach (GameObject enemy in nearbyEnemies)
            {
                float dist = Vector3.Distance(this.transform.position, enemy.transform.position);
              if (dist < radius)
                {
                    enemy.gameObject.GetComponent<enemyScript>().Shoot();
                }


            }
            yield return new WaitForSeconds(.5f);
        }

    }
    void changeDirection(int direction)
    {
        switch(direction)
        {
            case 0:
                animator.SetInteger("state", 0);
                break;
            case 1:
                animator.SetInteger("state", 1);
                break;
            case 2:
                animator.SetInteger("state", 2);
                break;
            case 3:
                animator.SetInteger("state", 3);
                break;
            case 4:
                animator.SetInteger("state", 4);
                break;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if(col.gameObject.tag == "item1")
        {

          //  string text = "speedPower";
            speedMultiplier += .5f;

        }
    }
    private IEnumerator SoundMaker ()
    {
       
        if (isMoving)
        {
            
            MakeWalkingTileNoise();
        }
        yield return new WaitForSeconds(0.75f);
        StartCoroutine(SoundMaker());

    }
    void MakeWalkingTileNoise()
    {
        Debug.Log("Running Physics Check");

        // cast a ray backwards from the player
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, Vector3.forward, 10.0f);

        foreach (RaycastHit hit in hits)
        {
            Debug.Log("hit name: " + hit.transform.name);

            switch (hit.transform.tag) {

                case "HardWoodTile":
                    Debug.Log("Playing hardwood sound");
                    
                    if (isSprint)
                    {
                        SoundManagerScript.S.PlaySound5();
                    }
                    else
                    {
                        SoundManagerScript.S.PlaySound2();
                    }

                    break;

                case "kitchenTile":
                    if (isSprint)
                    {
                        SoundManagerScript.S.PlaySound6();
                    }
                    else
                    {
                        SoundManagerScript.S.PlaySound3();
                    }
                    break;
                case "carpetTile":
                    if (isSprint)
                    {
                        SoundManagerScript.S.PlaySound4();
                    }
                    else
                    {
                        SoundManagerScript.S.PlaySound1();
                    }
                    
                    break;
                
                
            }

        }

    }

}
