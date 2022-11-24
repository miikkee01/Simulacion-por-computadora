using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRightCars : MonoBehaviour
{
    public float speed;
    void Start()
    {
        speed = 45;
    }

    void Update()
    {
        if (transform.position.x <= -45f) {
            transform.position = new Vector3(47f, 1f, 7.5f);
            
        }
        else{
            transform.Translate(new Vector3(0,-1,0) * speed * Time.deltaTime);
        }
    }
}