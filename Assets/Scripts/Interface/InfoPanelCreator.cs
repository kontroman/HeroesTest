using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanelCreator : MonoBehaviour
{
    [SerializeField]
    private GameObject _panelToCreate;     //����� ������ ������� ��� ����� �� ������

    [SerializeField]
    private GameObject _panelCanvas;       //������������ ������

    [SerializeField]
    private float _offsetX, offsetY;        //�������� ������������ �������� �������

    private GameObject _instantiatePanel;  //��������� ������

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(CreatePanel);
    }

    private void CreatePanel()
    {
        if (_panelCanvas == null)
            _panelCanvas = GameObject.Find("Canvas");

        if (_instantiatePanel)
        {
            Destroy(_instantiatePanel);
            return;
        }

        _instantiatePanel = Instantiate(_panelToCreate, _panelCanvas.transform);
        _instantiatePanel.transform.localPosition = new Vector3(_offsetX, offsetY);
        _instantiatePanel.GetComponent<InfoPanel>().UpdateInfo();
    }
}
