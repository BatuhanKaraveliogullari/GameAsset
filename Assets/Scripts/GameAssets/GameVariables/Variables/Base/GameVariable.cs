using UnityEngine;
///<Summary> This class provides communication within the game.
///It does this communication with variables.</Summary>
///<see cref="GameAsset"/>
public class GameVariable : GameAsset 
{ 
    [Tooltip("Represents resetting the value at each start of the game. It should be true if the variable is resetable, false otherwise.")]
    [SerializeField] protected bool useInitialValue;
}