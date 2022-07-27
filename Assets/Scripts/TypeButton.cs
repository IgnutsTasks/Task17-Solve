using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeButton : MonoBehaviour
{
    [SerializeField] private ItemData[] itemData;
    [SerializeField] private GameObject parentWindow;
    
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void Start()
    {
        _button.onClick.AddListener(OpenTypeWindow);
        
    }

    private void OpenTypeWindow()
    {
        TypeWindow.Instance.Initialize(itemData);
        parentWindow.SetActive(false);
    }
}
