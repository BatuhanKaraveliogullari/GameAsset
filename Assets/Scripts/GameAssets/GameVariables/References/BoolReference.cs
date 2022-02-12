using System;

///<Summary> This class enables the created variable to be called and read in different classes.
/// If it is cast to bool, the referenced value is returned. (ex: (bool)myFloatReference)</Summary>
[Serializable]
public class BoolReference
{
    public bool UseConstant = true;
    public bool ConstantValue;
    public BoolVariable Variable;

    public BoolReference() { }

    public BoolReference(bool value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    /// <value> Property <c> Value </c> This reference returns the value of the variable that belongs to it.
    ///If a constant value is entered, it returns it. </value>
    public bool Value{ get => UseConstant ? ConstantValue : Variable.Value; }

    public static implicit operator bool(BoolReference reference)
    {
        return reference.Value;
    }
}
