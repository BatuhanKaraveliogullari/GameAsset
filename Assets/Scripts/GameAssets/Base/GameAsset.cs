using UnityEngine;

/// <Summary> This class is the ancestor of all ScriptableObject assets that help in the game.
/// It keeps the info of this asset in it. </Summary>
public abstract class GameAsset : ScriptableObject
{
    [HideInInspector] public string assetInfo;
}
