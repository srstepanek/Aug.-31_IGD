using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clouds : MonoBehaviour
{
    public float speed = 2f;
    
    // Update is called once per frame
    void Update()
    {
        //stores current position of the object.
        Vector3 temp = this.transform.position;

        //temp.x += speed; 
        temp.x = temp.x + speed * Time.deltaTime;


        this.transform.position = temp;
    }
}
