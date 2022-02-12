using UnityEngine;
using UnityEngine.Assertions;

///<Summary> This class provides communication with the bool parameter.
///In other words, it allows us to raise an event as true or false.
///All functions that listen to it take this true or false parameter and use it to Invoke.
///It does this communication with events.</Summary>
///<see cref="GameEvent"/>
[CreateAssetMenu(fileName = "NewBoolEvent", menuName = "GameAssets/GameEvents/BoolEvent")]
public class BoolEvent : GameEvent
{
    private System.Action<bool> gameEvent;

    ///<Summary> The function that will listen to this event is added. </Summary>
    public void AddListener(System.Action<bool> action)
    {
        gameEvent += action;
    }
    
    ///<Summary> The function that will listen to this event is removed. </Summary>
    public void RemoveListener(System.Action<bool> action)
    {
        gameEvent -= action;
    }

    ///<Summary> This event is being raised. All listeners that will listen are triggered after this raise. </Summary>
    public void Raise(bool value)
    {
        Assert.IsNotNull(gameEvent, this.name + " was raised but this event has no listener.");
        gameEvent?.Invoke(value);
    }
}
