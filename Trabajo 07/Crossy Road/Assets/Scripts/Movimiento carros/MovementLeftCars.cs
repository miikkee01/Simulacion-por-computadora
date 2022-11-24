using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLeftCars : MonoBehaviour
{
    public float speed;
    /*public Transform InitialPosition;
    public gameObject player;*/


    void Start()
    {
        speed = 40;
    }

    void Update()
    {
        if (transform.position.x >= 45f) {
            transform.position = new Vector3(-63, 1, 14);
            
        }
        else{
            transform.Translate(new Vector3(0,-1,0) * speed * Time.deltaTime);
        }
    }
/*
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Kill")){
            player.transform.position =  InitialPosition.transform.position;
            

        }
    }*/
}
