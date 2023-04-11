using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public HeroData Data;

    public event Action onPicked; //����� �� ����� �����
    public event Action onDepicked; //������ �� ����������� �����

    public void HeroPicked()
    {
        onPicked?.Invoke();
    }

    public void HeroDePicked()
    {
        onDepicked?.Invoke();
    }

}
