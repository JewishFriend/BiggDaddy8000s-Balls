using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Start is called before the first frame update

    private Rigidbody player;
    public GameObject cube;


    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    public float side_speed = 1;
    public float speed = 10;
    public float boost_speed = 30;
    private Vector3 vektor;
    //słabe zmienne tfu
    private float interval;
    private Rigidbody rb;
    private float timer = 0f;
   

    void FixedUpdate()
    {
        //sterowanko ruchem
        vektor = cube.transform.rotation * Vector3.forward * Input.GetAxis("Vertical") * speed;

        float szypkosc = player.velocity.magnitude;

        player.AddForce(vektor, ForceMode.Force);
        player.AddForce(new Vector3(0f, 0f, Input.GetAxis("Horizontal") * side_speed));

        //usówanko kręgli

        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var go in GameObject.FindGameObjectsWithTag("Krengiel"))
            {
                Debug.Log(go);
                Destroy(go);
            }
        }

        //super krenconko

        if (Input.GetKey(KeyCode.LeftShift))
        {
            player.AddTorque(new Vector3(boost_speed, 0f, 0f), ForceMode.Acceleration);
        }
    }

    void Update()
    {
        //słaby update tfu
        if (timer >= interval)
        {
            GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            interval = 1 / rb.velocity.magnitude;
        }
        else timer += Time.deltaTime;

        //Kręgle



    }
}
