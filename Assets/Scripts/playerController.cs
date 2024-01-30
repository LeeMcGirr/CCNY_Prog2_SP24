using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //speed is a multiplier used to control actual speed of player
    public float speed;
    Vector3 myDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void OnCollisionStay(Collision collision)
    {

    }

    public Vector3 GetMyDir()
    {
        return myDir;
    }

    public void Move()
    {
        //simple keycode checks - start with W for UP
        if (Input.GetKey(KeyCode.W))
        {
            //for now we'll just directly call the transform and Translate it
            transform.Translate(Vector3.up * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        }

    }
}
