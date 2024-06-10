using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffects : MonoBehaviour
{
    ParticleSystem effect;
    private void Awake()
    {
        effect = GetComponent<ParticleSystem>();
    }
    private void Update()
    {
        if (!effect.isEmitting)
        {
            Destroy(gameObject);
        }
    }
}