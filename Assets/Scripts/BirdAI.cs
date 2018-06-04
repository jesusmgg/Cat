using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BirdAI : MonoBehaviour
{
    enum States
    {
        Idle,
        CollectingStraw,
        CollectingFood,
        Alerted,
        Fighting
    }

    int state;

    UnitStats unitStats;
    UnitMovement unitMovement;
    
    void Start()
    {
        state = (int) States.Idle;

        unitStats = GetComponent<UnitStats>();
        unitMovement = GetComponent<UnitMovement>();
    }

    void Update()
    {
        if (state == (int) States.Idle)
        {
            if (unitMovement.isAtDestination)
            {
                if (Random.Range(0, 300) == 0)
                {
                    unitMovement.currentDestination = unitMovement.GetRandomDestination();
                }   
            }
        }
        
        else if (state == (int) States.CollectingStraw)
        {
            
        }
        
        else if (state == (int) States.CollectingFood)
        {
            
        }
        
        else if (state == (int) States.Alerted)
        {
            
        }
        
        else if (state == (int) States.Fighting)
        {
            
        }
    }
}