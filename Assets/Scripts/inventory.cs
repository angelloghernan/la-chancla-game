using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public GameObject slot;
    public GameObject speedPower;
    // Start is called before the first frame update
    void Start()
    {
        var createImage = Instantiate(speedPower) as GameObject;
        slot.transform.SetParent(slot.transform, false);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
