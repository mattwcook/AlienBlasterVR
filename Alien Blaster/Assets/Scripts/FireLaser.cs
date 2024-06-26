using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class FireLaser : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    public GameObject laser;
    float fireTime = 1.0f;
    bool readyToFire = true;

    LineRenderer aimLine;
    private void Awake()
    {
        aimLine = GetComponent<LineRenderer>();
        aimLine.positionCount = 2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            //Debug.Log(transform.parent.name);
            aimLine.SetPosition(1, transform.InverseTransformPoint(hit.point));
            if (readyToFire == true)
            {
                if (hit.transform.tag == "Enemy")
                {
                    Fire();
                }
            }
        }
        else
        {
            aimLine.SetPosition(1, new Vector3(0, 0, 100));
        }
    }
    void Fire()
    {
        readyToFire = false;
        Instantiate(laser, transform.position, Quaternion.LookRotation(transform.forward));
        StartCoroutine(FireCoolDown(fireTime));
    }
    IEnumerator FireCoolDown(float coolDownTime)
    {
        yield return new WaitForSeconds(coolDownTime);
        readyToFire = true;
    }
}
