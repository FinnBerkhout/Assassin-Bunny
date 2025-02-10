using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float Speed = 5f; 

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponenet<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        
        characterController.move(move * Time.deltaTime * Speed);

    }
}
