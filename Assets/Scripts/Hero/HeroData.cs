using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HeroData", menuName = "HeroData", order = 1)]
public class HeroData : ScriptableObject
{
    public Talants Talants;
    public string Description;
}
