using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (particle.isEmitting == false)
        {
            Debug.Log("termine");
        }
    }
}
