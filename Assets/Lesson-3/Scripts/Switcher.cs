using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Switcher : MonoBehaviour
{
    public Pokedex MyPokedex;
    public TMP_Text PokeName;
    public Image PokeImg;
    private int actualIndex = -1;

    public PokeInfo GetNextPoke()
    {
        actualIndex = (actualIndex + 1) % MyPokedex.Pokemon.Count;

        return MyPokedex.Pokemon[actualIndex];
    }

    public void SetPokeUI()
    {
        PokeInfo info = GetNextPoke();
        PokeName.text = info.Name;
        PokeImg.sprite = info.PkmImg;
    }
}
