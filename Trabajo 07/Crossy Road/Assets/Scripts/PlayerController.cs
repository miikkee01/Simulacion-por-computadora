using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    public float speed = 0.5f;
    public Text StatusText;

    public CharacterController player;

    public int count;

    void Start (){
        player =  GetComponent<CharacterController>();

        count = 0;
        StatusText.text="";
    }

    void FixedUpdate (){
        float moveVertical = Input.GetAxis("Vertical");

        player.Move(new Vector3 (0.0f, 0.0f, moveVertical)*speed);

    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Kill")){
            transform.position =  new Vector3 (1.4f,-0.9f,-17f);
            
        }

        if (other.gameObject.CompareTag("Win"))
        {     
            StatusText.text= "You Win!";
        }
        
    }

    
}