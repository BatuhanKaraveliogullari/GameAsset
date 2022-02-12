using System;

///<Summary> This class enables the created variable to be called and read in different classes.
/// If a float is cast and used, the referenced value is returned. (ex: (float)myFloatReference)</Summary>
[Serializable]
public class FloatReference
{
    public bool UseConstant = true;
    public float ConstantValue;
    public FloatVariable Variable;

    public FloatReference() { }

    public FloatReference(float value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    /// <value> Property <c> Value </c> This reference returns the value of the variable that belongs to it.
    ///If a constant value is entered, it returns it. </value>
    public float Value{ get => UseConstant ? ConstantValue : Variable.Value; }

    public static implicit operator float(FloatReference reference)
    {
        return reference.Value;
    }
}
