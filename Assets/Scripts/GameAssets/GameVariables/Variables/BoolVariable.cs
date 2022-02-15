using UnityEngine;

///<Summary> This class provides communication within the game.
///Here, a bool variable is written to this class and all classes that read it realtime set this value.
///It does this communication with variables.</Summary>
///<see cref="GameVariable"/>
[CreateAssetMenu(fileName = "NewBoolVariable", menuName = "GameAssets/GameVariables/BoolVariable")]
public class BoolVariable : GameVariable
{
    public bool Value { get => savedValue; }

    [Tooltip("Every time the game starts, it is the value that the variable will start with, no matter how much the value is left. A kind of resetable variable is made. It is set only at the beginning of the game.")]
    [SerializeField] private bool initialValue;

    private bool savedValue;

    private void OnEnable() 
    {
        if(!useInitialValue) return;
        savedValue = initialValue;
    }

    ///<Summary> Value is assigned with bool.</Summary>
    public void SetValue(bool amount) => savedValue = amount;

    ///<Summary> Value is assigned with BoolVariable.</Summary>
    public void SetValue(BoolVariable amount) => savedValue = amount.Value;

    ///<Summary> Value assignment is made with BoolReference.</Summary>
    public void SetValue(BoolReference amount) => savedValue = amount.Value;

    ///<Summary> This function returns false if the variable is true and true if false.</Summary>
    public void ToggleValue() => savedValue = !savedValue;
}