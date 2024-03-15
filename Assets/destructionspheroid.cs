using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destructionspheroid : MonoBehaviour
{
    public GameObject sphere;
    public GameObject spheroid;
    public GameObject explosion;
    public GameObject gameOverScreen;
    public AudioSource Sound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Spheroid Collision");
        explosion.transform.localScale = new Vector3(50, 50, 50);
        Instantiate(explosion, transform.position, Quaternion.identity);
        Sound.Play();
        spheroid.SetActive(false);
        Debug.Log("Game Over");
        gameOverScreen.SetActive(true);
        
    }
}

