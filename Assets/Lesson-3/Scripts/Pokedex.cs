using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct PokeInfo
{
    public string Name;
    public Sprite PkmImg;
}

[CreateAssetMenu(fileName = "Pokedex", menuName = "Scriptable Object/Create Pokedex", order = 0)]
public class Pokedex : ScriptableObject
{
    public List<PokeInfo> Pokemon;
}
