using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserProjectile : MonoBehaviour
{
    float velocity = 30f;
    float existTimer = 0;
    float existTime = 2.0f;
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("Projectile Start");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * velocity * Time.deltaTime;
        existTimer += Time.deltaTime;
        if (existTimer > existTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
    }
}
