using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnSamochodów : MonoBehaviour {

    public float delay = 2f;

    public GameObject bombka;


    private float Delay2;
	// Use this for initialization


	void Start () {
        Delay2 = delay;
        

    }

    // Update is called once per frame
    void Update () {
        Delay2 -= Time.deltaTime;
        if(Delay2<=0)
        {
            System.Random rnd = new System.Random();
            double x = rnd.NextDouble() * 10;
            int czy = rnd.Next(1, 11);
            if (czy %2 == 0)
            {
                x = -x;
            }
            spawn(x);
            Delay2 = delay;
        }
		
	}
    void spawn(double x)
    {
        float x2 = (float) x;
       
        Instantiate(bombka, new Vector3(x2, 6, 0), Quaternion.identity);
    }
}
