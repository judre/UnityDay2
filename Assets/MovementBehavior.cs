using UnityEngine;
using System.Collections;

public class MovementBehavior : MonoBehaviour
{
    public float smoothing = 1f;
    public Transform target;
    public Transform target2;


    void Start()
    {
        StartCoroutine(Movement(target,target2));

        
        
    }


    IEnumerator Movement(Transform target, Transform target2)
    {
        while (Vector3.Distance(transform.position, target.position) > 2f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);

            yield return null;
        }

        while (Vector3.Distance(transform.position, target2.position) > 2f)
        {
            transform.position = Vector3.Lerp(transform.position, target2.position, smoothing * Time.deltaTime);

            yield return null;
        }
    }
    
}