using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public HeroData Data;

    public event Action onPicked; //Ивент на выбор героя
    public event Action onDepicked; //Инвент на деактивацию героя

    public void HeroPicked()
    {
        onPicked?.Invoke();
    }

    public void HeroDePicked()
    {
        onDepicked?.Invoke();
    }

}
