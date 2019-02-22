using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlCube : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody player;


    void Start()
    {
        player = GetComponent<Rigidbody>();
    }


    
    public float rotation_speed = 10;

    void FixedUpdate()
    {
        
        float xforce = Input.GetAxis("Horizontal");

        
        Vector3 rotate = new Vector3(0f, rotation_speed * xforce, 0f);

        
        player.AddTorque(rotate);
    }
}
