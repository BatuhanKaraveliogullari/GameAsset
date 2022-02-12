using UnityEngine;
using UnityEngine.Assertions;

///<Summary> This class provides communication with the float parameter.
///In other words, it allows us to raise an event as a float.
///All functions that listen to it take this float parameter and become Invoke using it.
///It does this communication with events.</Summary>
///<see cref="GameEvent"/>
[CreateAssetMenu(fileName = "NewFloatEvent", menuName = "GameAssets/GameEvents/FloatEvent")]
public class FloatEvent : GameEvent
{
    private System.Action<float> gameEvent;

    ///<Summary> The function that will listen to this event is added. </Summary>
    public void AddListener(System.Action<float> action)
    {
        gameEvent += action;
    }
    
    ///<Summary> The function that will listen to this event is removed. </Summary>
    public void RemoveListener(System.Action<float> action)
    {
        gameEvent -= action;
    }

    ///<Summary> This event is being raised. All listeners that will listen are triggered after this raise. </Summary>
    public void Raise(float value)
    {
        Assert.IsNotNull(gameEvent, this.name + " was raised but this event has no listener.");
        gameEvent?.Invoke(value);
    }
}
