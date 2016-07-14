using UnityEngine;
using System.Collections;

public class playermove : MonoBehaviour {

    
    public movementthing move;
    [Range(50,700)]
    public float speed;
    [Range(200,700)]
    public float jumpspeed = 100.0f;


    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * jumpspeed * Time.deltaTime, Space.World);
        }

        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        move.Move(new Vector3(h, 0f, v));
    }
}
