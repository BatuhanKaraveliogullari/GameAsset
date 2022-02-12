using System;

///<Summary> This class enables the created variable to be called and read in different classes.
/// If an int is cast to the referenced value, it returns (ex: (int)myFloatReference )</Summary>
[Serializable]
public class IntReference 
{
    public bool UseConstant = true;
    public int ConstantValue;
    public IntVariable Variable;

    public IntReference() { }

    public IntReference(int value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    /// <value> Property <c> Value </c> This reference returns the value of the variable that belongs to it.
    ///If a constant value is entered, it returns it. </value>
    public int Value{ get => UseConstant ? ConstantValue : Variable.Value; }

    public static implicit operator int(IntReference reference)
    {
        return reference.Value;
    }
}