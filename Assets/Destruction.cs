using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public GameObject sphere;
    public GameObject spheroid;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sphere.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("Sphere Entered");
        explosion.transform.localScale = new Vector3(50, 50, 50);
        Instantiate(explosion, transform.position, Quaternion.identity);
        sphere.SetActive(false);

    }
    
       

    
}
