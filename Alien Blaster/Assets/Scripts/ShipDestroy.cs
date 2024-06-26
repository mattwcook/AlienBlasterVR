using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDestroy : MonoBehaviour
{
    GameObject appearance;
    GameObject explosion;
    private void Start()
    {
        appearance = transform.GetChild(0).gameObject;
        explosion = transform.GetChild(1).gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        Die();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Die();
        }
    }
    private void Die()
    {
        appearance.SetActive(false);
        explosion.SetActive(true);
    }
}
