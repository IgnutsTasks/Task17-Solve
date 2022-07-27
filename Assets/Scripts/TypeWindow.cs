using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeWindow : MonoBehaviour
{
    public static TypeWindow Instance;
    
    [SerializeField] private Item itemPrefab;
    [SerializeField] private Transform layout;
    [SerializeField] private GameObject window;

    private void Awake()
    {
        Instance = this;
    }

    public void Initialize(ItemData[] data)
    {
        CleanUp();
        foreach (var elem in data)
        {
            CreateItem(elem);
        }
        
        window.SetActive(true);
    }

    private void CreateItem(ItemData itemData)
    {
        Item newItem = Instantiate(itemPrefab, layout);
        newItem.avatar.sprite = itemData.sprite;
    }

    private void CleanUp()
    {
        for (int i = 0; i < layout.childCount; i++)
        {
            Destroy(layout.GetChild(i).gameObject);
        }
    }
}
