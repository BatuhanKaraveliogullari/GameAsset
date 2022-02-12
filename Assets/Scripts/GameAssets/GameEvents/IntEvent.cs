using UnityEngine;
using UnityEngine.Assertions;

///<Summary> This class provides communication with the int parameter.
///In other words, it allows us to raise an event as an int.
///All functions that listen to it take this int parameter and become Invoke using it.
///It does this communication with events.</Summary>
///<see cref="GameEvent"/>
[CreateAssetMenu(fileName = "NewIntEvent", menuName = "GameAssets/GameEvents/IntEvent")]
public class IntEvent : GameEvent
{
    private System.Action<int> gameEvent;

    ///<Summary> The function that will listen to this event is added. </Summary>
    public void AddListener(System.Action<int> action)
    {
        gameEvent += action;
    }
    
    ///<Summary> The function that will listen to this event is removed. </Summary>
    public void RemoveListener(System.Action<int> action)
    {
        gameEvent -= action;
    }

    ///<Summary> This event is being raised. All listeners that will listen are triggered after this raise. </Summary>
    public void Raise(int value)
    {
        Assert.IsNotNull(gameEvent, this.name + " was raised but this event has no listener.");
        gameEvent?.Invoke(value);
    }
}
