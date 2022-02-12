using UnityEngine;
using UnityEngine.Assertions;

///<Summary> This class provides communication with Vector3 parameter.
///In other words, it allows us to raise an event as Vector3.
///All functions that listen to it take this Vector3 parameter and become Invoke using it.
///It does this communication with events.</Summary>
///<see cref="GameEvent"/>
[CreateAssetMenu(fileName = "NewVector3Event", menuName = "GameAssets/GameEvents/Vector3Event")]
public class Vector3Event : GameEvent
{
    private System.Action<Vector3> gameEvent;

    ///<Summary> The function that will listen to this event is added. </Summary>
    public void AddListener(System.Action<Vector3> action)
    {
        gameEvent += action;
    }
    
    ///<Summary> The function that will listen to this event is removed. </Summary>
    public void RemoveListener(System.Action<Vector3> action)
    {
        gameEvent -= action;
    }

    ///<Summary> This event is being raised. All listeners that will listen are triggered after this raise. </Summary>
    public void Raise(Vector3 value)
    {
        Assert.IsNotNull(gameEvent, this.name + " was raised but this event has no listener.");
        gameEvent?.Invoke(value);
    }
}
