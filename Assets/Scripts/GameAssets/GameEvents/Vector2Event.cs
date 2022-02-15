using UnityEngine;
using UnityEngine.Assertions;

///<Summary> This class provides communication with Vector2 parameter.
///In other words, it allows us to raise an event as Vector2.
///All functions that listen to it take this Vector2 parameter and become Invoke using it.
///It does this communication with events.</Summary>
///<see cref="GameEvent"/>
[CreateAssetMenu(fileName = "NewVector2Event", menuName = "GameAssets/GameEvents/Vector2Event")]
public class Vector2Event : GameEvent
{
    private System.Action<Vector2> gameEvent;

    ///<Summary> The function that will listen to this event is added. </Summary>
    public void AddListener(System.Action<Vector2> action)
    {
        gameEvent += action;
    }
    
    ///<Summary> The function that will listen to this event is removed. </Summary>
    public void RemoveListener(System.Action<Vector2> action)
    {
        gameEvent -= action;
    }

    ///<Summary> This event is being raised. All listeners that will listen are triggered after this raise. </Summary>
    public void Raise(Vector2 value)
    {
        Assert.IsNotNull(gameEvent, this.name + " was raised but this event has no listener.");
        gameEvent?.Invoke(value);
    }
}
