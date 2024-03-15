using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class spawner : MonoBehaviour
{
	public GameObject sphere;
	// Start is called before the first frame update
	void Start()
	{
		
	}
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
	
			System.Random rnd = new System.Random();
			int ys = rnd.Next(600, 1000);
			float ysfloat = (float)ys;
			float x_axis = Random.Range(-350.0f, 350.0f);
			float z_axis = Random.Range(-350.0f, 350.0f);
			
			float aktina = Random.Range(10.0f, 30.0f);
			float diametros = 4 * aktina;
			
			Vector3 randompos = new Vector3(x_axis, ysfloat, z_axis);

			sphere.transform.localScale = new Vector3(diametros, diametros, diametros);
			Instantiate(sphere, randompos, Quaternion.identity);

		}


	}
		
			
}
