using System;
using UnityEngine;

///<Summary> This class enables the created variable to be called and read in different classes.
/// If it is cast to Vector3, the referenced value is returned. (ex: (Vector3)myFloatReference )</Summary>
[Serializable]
public class Vector3Reference
{
    public bool UseConstant = true;
    public Vector3 ConstantValue;
    public Vector3Variable Variable;
    
    public Vector3Reference() { }

    public Vector3Reference(Vector3 value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    /// <value> Property <c> Value </c> This reference returns the value of the variable that belongs to it.
    ///If a constant value is entered, it returns it. </value>
    public Vector3 Value{ get => UseConstant ? ConstantValue : Variable.Value; }

    public static implicit operator Vector3(Vector3Reference reference)
    {
        return reference.Value;
    }
}
