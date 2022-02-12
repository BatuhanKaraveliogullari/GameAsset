using UnityEngine;

///<Summary> This class provides communication within the game.
///Here, an int variable is written to this class and all classes that read it realtime set this value.
///It does this communication with variables.</Summary>
///<see cref="GameVariable"/>
[CreateAssetMenu(fileName = "NewIntVariable", menuName = "GameAssets/GameVariables/IntVariable")]
public class IntVariable : GameVariable
{
    public int Value { get => savedValue; }

    [Tooltip("Every time the game starts, it is the value that the variable will start with, no matter how much the value is left. A kind of resetable variable is made. It is set only at the beginning of the game.")]
    [SerializeField] private int initialValue;

    private int savedValue;

    private void OnEnable() 
    {
        if(!useInitialValue) return;
        savedValue = initialValue;
    }

    ///<Summary> Value is assigned with int.</Summary>
    public void SetValue(int amount) => savedValue = amount;

    ///<Summary> Value is assigned with int Variable.</Summary>
    public void SetValue(IntVariable amount) => savedValue = amount.Value;

    ///<Summary> Value assignment is made with IntReference.</Summary>
    public void SetValue(IntReference amount) => savedValue = amount.Value;

    ///<Summary> Summation is done with int.</Summary>
    public void Increase(int amount) => savedValue += amount;

    ///<Summary> Summation is done with Int Variable.</Summary>
    public void Increase(IntVariable amount) => savedValue += amount.Value;

    ///<Summary> Summation is done with IntReference.</Summary>
    public void Increase(IntReference amount) => savedValue += amount.Value;

    ///<Summary> Subtraction is done with int.</Summary>
    public void Decrease(int amount) => savedValue -= amount;

    ///<Summary> Subtraction is done with Int Variable.</Summary>
    public void Decrease(IntVariable amount) => savedValue -= amount.Value;

    ///<Summary> Subtraction is done with IntReference.</Summary>
    public void Decrease(IntReference amount) => savedValue -= amount.Value;

    ///<Summary> Multiplication is done with int.</Summary>
    public void Multiply(int multiplier) => savedValue *= multiplier;

    ///<Summary> Multiplication is done with Int Variable.</Summary>
    public void Multiply(IntVariable multiplier) => savedValue *= multiplier.Value;

    ///<Summary> Multiplication is done with IntReference.</Summary>
    public void Multiply(IntReference multiplier) => savedValue *= multiplier.Value;

    ///<Summary> Division is done with an int.
    /// If the result of the division is decimal, it is rounded up to the nearest whole number.</Summary>
    public void Devide(int divider) => savedValue = Mathf.RoundToInt(savedValue / divider);

    ///<Summary> Division is done with an IntVariable.
    /// If the result of the division is decimal, it is rounded up to the nearest whole number.</Summary>
    public void Devide(IntVariable divider) => savedValue = Mathf.RoundToInt(savedValue / divider.Value);

    ///<Summary> Division is done with an IntReference.
    /// If the result of the division is decimal, it is rounded up to the nearest whole number.</Summary>
    public void Devide(IntReference divider) => savedValue = Mathf.RoundToInt(savedValue / divider.Value);
}