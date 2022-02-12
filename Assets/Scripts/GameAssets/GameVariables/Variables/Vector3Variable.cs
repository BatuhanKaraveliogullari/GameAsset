using UnityEngine;

///<Summary> This class provides communication within the game.
///Here, a Vector3 variable is written to this class and all classes that read it realtime set this value.
///It does this communication with variables.</Summary>
///<see cref="GameVariable"/>
[CreateAssetMenu(fileName = "NewVector3Variable", menuName = "GameAssets/GameVariables/Vector3Variable")]
public class Vector3Variable : GameVariable
{
    public Vector3 Value { get => savedValue; }

    [Tooltip("Every time the game starts, it is the value that the variable will start with, no matter how much the value is left. A kind of resetable variable is made. It is set only at the beginning of the game.")]
    [SerializeField] private Vector3 initialValue;

    private Vector3 savedValue;

    private void OnEnable() 
    {
        if(!useInitialValue) return;
        savedValue = initialValue;
    }

    ///<Summary> Value assignment is made with Vector3.</Summary>
    public void SetValue(Vector3 amount) => savedValue = amount;

    ///<Summary> Value assignment is made with Vector3Variable.</Summary>
    public void SetValue(Vector3Variable amount) => savedValue = amount.Value;

    ///<Summary> Scale is made with float.</Summary>
    public void Scale(float multiplier) => savedValue *= multiplier;

    ///<Summary> Scale is done with int.</Summary>
    public void Scale(int multiplier) => savedValue *= multiplier;

    ///<Summary> Scale is done with FloatVariable.</Summary>
    public void Scale(FloatVariable multiplier) => savedValue *= multiplier.Value;

    ///<Summary> Scale is done with FloatReference.</Summary>
    public void Scale(FloatReference multiplier) => savedValue *= multiplier.Value;

    ///<Summary> Scale is made with IntVariable.</Summary>
    public void Scale(IntVariable multiplier) => savedValue *= multiplier.Value;

    ///<Summary> Scale is done with IntReference.</Summary>
    public void Scale(IntReference multiplier) => savedValue *= multiplier.Value;
}