using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private void Start()
    {
        try
        {
            GenereateHero(HeroPicker.Instance.currentHero);
        }
        catch (NullReferenceException)
        {
            return;
        }
    }

    private void GenereateHero(Hero hero)
    {
        Instantiate(hero);
    }
}
