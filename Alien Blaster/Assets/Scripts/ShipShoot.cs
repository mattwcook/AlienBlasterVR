using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour
{
    float minFireTime = 4.0f;
    float maxFireTime = 7.0f;
    public GameObject laserProjectile;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Fire",Random.Range(minFireTime,maxFireTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Fire()
    {
        Invoke("Fire", Random.Range(minFireTime, maxFireTime));
    }
}
