using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controll : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    
    void LateUpdate()
    {
        float xforce = Input.GetAxis("Horizontal");
        transform.position = player.transform.position + offset;
        
    }
}
