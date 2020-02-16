using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelExplode : MonoBehaviour
{
    public float delay = 3f;
    float countdown;
    bool hasExploded = false;
    public GameObject explosionEffect;
    public GameObject destroyedVersion;
    void Start()
    {
        countdown = delay;
        
    }

    
   
    
        public void Explode()
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);

            Instantiate(destroyedVersion, transform.position, transform.rotation);



        }

    }


