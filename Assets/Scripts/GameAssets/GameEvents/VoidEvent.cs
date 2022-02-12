using UnityEngine;
using UnityEngine.Assertions;

///<Summary> This class provides communication with the bool parameter.
///In other words, it allows us to raise an event without parameters.
///All functions that listen to it become parameterless and invoke directly.
///It does this communication with events.</Summary>
///<see cref="GameEvent"/>
[CreateAssetMenu(fileName = "NewVoidEvent", menuName = "GameAssets/GameEvents/VoidEvent")]
public class VoidEvent : GameEvent
{
    private System.Action gameEvent;

    ///<Summary> The function that will listen to this event is added. </Summary>
    public void AddListener(System.Action action)
    {
        gameEvent += action;
    }
    
    ///<Summary> The function that will listen to this event is removed. </Summary>
    public void RemoveListener(System.Action action)
    {
        gameEvent -= action;
    }

    ///<Summary> This event is being raised. All listeners that will listen are triggered after this raise. </Summary>
    public void Raise()
    {
        Assert.IsNotNull(gameEvent, this.name + " was raised but this event has no listener.");
        gameEvent?.Invoke();
    }
}
