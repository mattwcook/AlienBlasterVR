using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class AlienMovement : MonoBehaviour
{
    Transform destination;
    public float moveSpeed = 1.0f;
    public float spinSpeed = 90f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        transform.eulerAngles += new Vector3(0, spinSpeed, 0)*Time.deltaTime;
        //transform.position += tr
    }
    IEnumerator Move()
    {
        while(transform.position != destination.position)
        {
            Debug.Log(transform.position);
            //transform.position = Vector3.Lerp(transform.position, destination.position, moveSpeed*Time.deltaTime);
            transform.position += (destination.position - transform.position).normalized * moveSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }
    public void SetDestination(Transform newDestination)
    {
        destination = newDestination;
        StartCoroutine(Move());
    }

}
