using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HeroAnimations : MonoBehaviour
{
    [SerializeField]
    private Hero _thisHero;

    private void Start()
    {
        if (_thisHero == null)
            _thisHero = GetComponent<Hero>();

        //Подписываемся на ивенты
        _thisHero.onDepicked += DepickedAnimation;
        _thisHero.onPicked += PickedAnimation;
    }

    /// <summary>
    /// Анимация ухода героя 
    /// </summary>
    private void DepickedAnimation()
    {
        transform.DOMove(new Vector3(0, 25, 0), 2f);
    }

    /// <summary>
    /// Анимация появления героя
    /// </summary>
    private void PickedAnimation()
    {
        transform.DOMove(new Vector3(0, 0, 0), 2f);
    }
}
