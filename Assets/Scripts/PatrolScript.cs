using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PatrolScript : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float travelTime;

    private float elapsedTime = 0.0f;
    private float distancePercentage = 0.0f;
    private int distanceDirection = 1;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        distancePercentage = elapsedTime / travelTime;

        if (distanceDirection > 0)
        {
            transform.position = ((endPosition - startPosition) * distancePercentage) + startPosition;
        } else
        {
            transform.position = ((startPosition - endPosition) * distancePercentage) + endPosition;
        }




        if (elapsedTime >= travelTime)
        {
            elapsedTime= 0.0f;
            distanceDirection *= -1;
        }
        
    }
}
