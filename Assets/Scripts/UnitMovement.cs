using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    public float destinationTolerance = 0.05f;
    public float randomDestinationVariation;
        
    public Vector2 currentDestination;
    public Vector2 currentStartingPosition;

    public bool isAtDestination;
    public bool isMoving;
    
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    
    UnitStats unitStats;

    void Start()
    {
        unitStats = GetComponent<UnitStats>();
        
        currentStartingPosition = transform.position;
        currentDestination = currentStartingPosition;

        isAtDestination = true;
        isMoving = false;
    }

    void Update()
    {
        float deltaTime = Time.deltaTime;

        float progress =
            ((currentStartingPosition - (Vector2) transform.position).magnitude + unitStats.speed * deltaTime) /
            (currentDestination - currentStartingPosition).magnitude;

        Vector2 newPosition = transform.position;
            
        newPosition.x = Mathf.Lerp(currentStartingPosition.x, currentDestination.x, progress);
        newPosition.y = Mathf.Lerp(currentStartingPosition.y, currentDestination.y, progress);

        transform.position = newPosition;

        isAtDestination = false;
        isMoving = true;

        if (progress >= 1.0f - destinationTolerance)
        {
            currentStartingPosition = transform.position;
            isAtDestination = true;
            isMoving = false;
        }
    }
    
    public Vector2 GetRandomDestination()
    {
        float variation = randomDestinationVariation;
        
        Vector2 destination = new Vector2
        {
            x = Random.Range(transform.position.x - variation, transform.position.x + variation),
            y = Random.Range(transform.position.y - variation, transform.position.y + variation)
        };
        
        if (destination.x < minX) {destination.x = minX;}
        if (destination.x > maxX) {destination.x = maxX;}
        if (destination.y < minY) {destination.y = minY;}
        if (destination.y > maxY) {destination.y = maxY;}

        return destination;
    }
}