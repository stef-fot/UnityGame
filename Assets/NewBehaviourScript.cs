using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x <= 350)
                transform.Translate(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x >= -350)
                transform.Translate(-speed, 0f, 0f);

        }

        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.z <= 350)
                transform.Translate(0.0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.X))
        {
            if (transform.position.z >= -350)
                transform.Translate(0.0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, speed, 0.0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(0.0f, -speed, 0.0f);
        }
    }
}
