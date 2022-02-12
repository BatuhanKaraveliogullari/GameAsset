using UnityEngine;

///<Summary> This class provides communication within the game.
///Here, a float variable is written to this class and all classes that read it realtime set this value.
///It does this communication with variables.</Summary>
///<see cref="GameVariable"/>
[CreateAssetMenu(fileName = "NewFloatVariable", menuName = "GameAssets/GameVariables/FloatVariable")]
public class FloatVariable : GameVariable
{
    public float Value { get => savedValue; }

    [Tooltip("Every time the game starts, it is the value that the variable will start with, no matter how much the value is left. A kind of resetable variable is made. It is set only at the beginning of the game.")]
    [SerializeField] private float initialValue;

    private float savedValue;

    private void OnEnable() 
    {
        if(!useInitialValue) return;
        savedValue = initialValue;
    }

    ///<Summary> Value is assigned with float.</Summary>
    public void SetValue(float amount) => savedValue = amount;

    ///<Summary> Value is assigned with FloatVariable.</Summary>
    public void SetValue(FloatVariable amount) => savedValue = amount.Value;

    ///<Summary> Value assignment is made with FloatReference.</Summary>
    public void SetValue(FloatReference amount) => savedValue = amount.Value;

    ///<Summary> Collection is done with float.</Summary>
    public void Increase(float amount) => savedValue += amount;

    ///<Summary> Collection is done with FloatVariable.</Summary>
    public void Increase(FloatVariable amount) => savedValue += amount.Value;

    ///<Summary> Collection is done with FloatReference.</Summary>
    public void Increase(FloatReference amount) => savedValue += amount.Value;

    ///<Summary> Subtraction is done with float.</Summary>
    public void Decrease(float amount) => savedValue -= amount;

    ///<Summary> Subtraction is done with FloatVariable.</Summary>
    public void Decrease(FloatVariable amount) => savedValue -= amount.Value;

    ///<Summary> Subtraction is done with FloatReference.</Summary>
    public void Decrease(FloatReference amount) => savedValue -= amount.Value;

    ///<Summary> Multiplication is done with float.</Summary>
    public void Multiply(float multiplier) => savedValue *= multiplier;

    ///<Summary> Multiplication is done with FloatVariable.</Summary>
    public void Multiply(FloatVariable multiplier) => savedValue *= multiplier.Value;

    ///<Summary> Multiplication is done with FloatReference.</Summary>
    public void Multiply(FloatReference multiplier) => savedValue *= multiplier.Value;

    ///<Summary> Division is done with float.</Summary>
    public void Devide(float divider) => savedValue /= divider;

    ///<Summary> Division is done with FloatVariable.</Summary>
    public void Devide(FloatVariable divider) => savedValue /= divider.Value;
    
    ///<Summary> Division is done with FloatReference.</Summary>
    public void Devide(FloatReference divider) => savedValue /= divider.Value;
}