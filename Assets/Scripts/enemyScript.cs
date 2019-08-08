using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    private bool canShoot;
    public GameObject startPlace;
    public GameObject bulletObject;
    public GameObject grid;
    public GameObject playerPos;
    public float speed2;
    public bool collidedWall;
    //public static enemyScript S;
    void Start()
    {
        //S = this;
        canShoot = true;
        speed = 15;
        collidedWall = false;
        //angle1 = transform.eulerAngles.z;
        //angle2 = transform.eulerAngles.z + 90;

    }
    //private void OnTriggerEnter2D(Collider2D collision)
    private void OnTriggerEnter2D(Collider2D turner)
    {
        if (turner.gameObject.tag == "TurnPoint")
        {
            speed = -speed;

        }
    }
    private void onColliderEnter2D(Collider2D turner)
    {


    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        collidedWall = false;


        if (canShoot)
        {
            if (collision.gameObject.tag == "Player")
            {

                /*
                foreach (RaycastHit2D l in Physics2D.RaycastAll(this.gameObject.transform.position, playerPos.transform.position))
                {
                    Debug.DrawRay(this.gameObject.transform.position, playerPos.transform.position, Color.green);
                    if (l.collider.gameObject.tag == "wall")
                    {
                        Debug.DrawRay(this.gameObject.transform.position, playerPos.transform.position, Color.green, 10.0f,false);
                        collidedWall = true;
                        canShoot = true;
                        break;
                    }
                }
                
            }
            */

                if (!collidedWall && collision.gameObject.tag == "Player")
                {
                    Shoot();
                }



            }

            /*if (!collidedWall && !(collision.gameObject.tag == "Player"))
            {
                if (collision.gameObject.tag == "TurnPoint")
                {
                    Debug.Log(speed);
                    speed = -speed;
                }
            }
            */
        }
    }







    public void Shoot()
    {
        collidedWall = false;
        if (canShoot)
        {
            //instantiate a bullet 
            //Instantiate(bulletObject, startPlace.transform.position, Quaternion.identity);
            var bull = Instantiate(bulletObject, startPlace.transform.position, Quaternion.identity);
            bull.transform.SetParent(grid.transform);
            bull.GetComponent<bulletScript>().thrust = (7 - speed2) * 250;

            // turn off the cannon box object

            // start the reload timer
            StartCoroutine(ReloadTimer());
        }

    }

    void Reload()
    {
        // reset the shoot ability and the cannon box
        canShoot = true;
    }

    public IEnumerator ReloadTimer()
    {
        canShoot = false;
        yield return new WaitForSeconds(0.5f);
        Reload();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log((transform.eulerAngles).z >= angle2);
        Debug.Log(transform.eulerAngles.z <= angle1);
        if (!(transform.eulerAngles.z >= angle2 && transform.eulerAngles.z <= angle1))
        {
            speed = -speed;
            Debug.Log(speed);
        }
        if (transform.eulerAngles.z <= angle2)
        {
            speed = -speed;
            Debug.Log(speed);
        }*/
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * speed * speed2));

    }
}
    
