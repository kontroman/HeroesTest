using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCreator : MonoBehaviour
{
    [SerializeField]
    private GameObject _buttonToCreate;     //����� ������ ������� ��� ����� �� ������

    [SerializeField]
    private GameObject _buttonCanvas;       //������������ ������

    [SerializeField]
    private float _offsetX, offsetY;        //�������� ������������ �������� �������

    private GameObject _instantiateButton;  //��������� ������

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
