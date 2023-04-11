using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoPanel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _infoText;

    private void Awake()
    {
        if (_infoText == null)
            _infoText = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void UpdateInfo()
    {
        HeroData data = HeroPicker.Instance.currentHero.Data;

        _infoText.text = data.Description;
    }
}
