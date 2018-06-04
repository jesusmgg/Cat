using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStats : MonoBehaviour
{
    public int hitPoints;
    public float speed;

    public int currentHitPoints;

    public void Start()
    {
        currentHitPoints = hitPoints;
    }
}