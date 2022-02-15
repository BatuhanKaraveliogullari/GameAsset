using System;
using UnityEngine;

///<Summary> This class enables the created variable to be called and read in different classes.
/// If it is cast to Vector2, the referenced value is returned. (ex: (Vector2)myFloatReference )</Summary>
[Serializable]
public class Vector2Reference
{
    public bool UseConstant = true;
    public Vector2 ConstantValue;
    public Vector2Variable Variable;

    public Vector2Reference() { }
     
    public Vector2Reference(Vector2 value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    /// <value> Property <c> Value </c> This reference returns the value of the variable that belongs to it.
    ///If a constant value is entered, it returns it. </value>
    public Vector2 Value{ get => UseConstant ? ConstantValue : Variable.Value; }

    public static implicit operator Vector2(Vector2Reference reference)
    {
        return reference.Value;
    }
}
