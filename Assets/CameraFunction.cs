using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFunction : MonoBehaviour
{
    private Vector3 pos;
    [Header("Camera Settings")]
    public float speed;
    public float speed_y_axis;


    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            transform.Rotate(speed * Time.deltaTime, 0, 0);
            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            transform.Rotate(-speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.Rotate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            pos.y += speed_y_axis;
            
            
        }
        if (Input.GetKey(KeyCode.KeypadMinus))
        {
            pos.y -= speed_y_axis;
            
        }
        if (Input.GetKey(KeyCode.KeypadMultiply))
        {
            
            transform.Rotate(0, speed * Time.deltaTime, 0);

        }
        if (Input.GetKey(KeyCode.KeypadDivide))
        {
            
            transform.Rotate(0, -speed * Time.deltaTime, 0);
        }
        this.transform.position = pos;

    }

}
