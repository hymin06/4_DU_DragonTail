using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Asset/Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    [SerializeField] float itemDropValue;
}
