using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseHeroButton : MonoBehaviour
{
    [SerializeField]
    private Hero _hero;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(SelectHero);

        if (!_hero) GetComponent<Button>().interactable = false;
    }

    public void SelectHero()
    {
        HeroPicker.Instance.SelectNewHero(_hero);
    }
}
