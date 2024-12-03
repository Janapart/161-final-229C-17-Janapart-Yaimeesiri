using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private float radius;

    private int side = 4;
    private int Squarearea = 6;

    public override void CalculateArea()
    {
        
    }

    public void Side()
    {
        Debug.Log($" Square Side : {side} ");
        Debug.Log($" Squarearea : {Squarearea} ");
    }
    
    

}
