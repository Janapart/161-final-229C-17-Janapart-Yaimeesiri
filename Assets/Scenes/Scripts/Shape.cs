using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private void Start()
    {
        Debug.Log($" Drawing : Square ");
        CalculateArea();
        Resize();
    }



    public void InitString(string Square , string Cirele)
    {
        Square = " Square ";
        Cirele = " Circle ";

    }

    public abstract void CalculateArea();
    

    public virtual void Resize()
    {

    }

    public void Draw ()
    {

    }

}
