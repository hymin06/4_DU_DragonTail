using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickEvent : MonoBehaviour
{
    [SerializeField] private PlayerAbilityList playerAbilityList;
    [SerializeField] private PlayerUpgradeManager playerUpgradeManager;
    public int buttonAbilityNumber;
    public void ButtonClick()
    {
        playerAbilityList.AbilitySelect(buttonAbilityNumber);
        StartCoroutine(playerUpgradeManager.ButtonDown());
        Time.timeScale = 1;
    }
}
