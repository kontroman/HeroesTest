using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCreator : MonoBehaviour
{
    [SerializeField]
    private GameObject _buttonToCreate;     //Какую кнопку создаем при клике на объект

    [SerializeField]
    private GameObject _buttonCanvas;       //Родительский объект

    [SerializeField]
    private float _offsetX, offsetY;        //Смещение относительно главного объекта

    private GameObject _instantiateButton;  //Созданная кнопка

    private void OnMouseDown()
    {
        if (_buttonCanvas == null)
            _buttonCanvas = GameObject.Find("ButtonsCanvas");

        if (_instantiateButton)
        {
            Destroy(_instantiateButton);
            return;
        }

        _instantiateButton = Instantiate(_buttonToCreate, _buttonCanvas.transform);
        _instantiateButton.transform.localPosition = new Vector3(_offsetX, offsetY);
    }
}
