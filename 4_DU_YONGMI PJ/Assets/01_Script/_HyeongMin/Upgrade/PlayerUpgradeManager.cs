using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUpgradeManager : MonoBehaviour
{
    [SerializeField] private PlayerAbilityList playerAbilityList;
    [SerializeField] private GameObject upgradeButtons;
    [SerializeField] private Button[] button;
    [SerializeField] private int buttonUpDownRange;

    public float buttonTransformY;
    int abilityRandomRange;

    private void Start()
    {
        abilityRandomRange = playerAbilityList.abilityList.Length;
        buttonTransformY = Mathf.Abs(button[0].transform.position.y - transform.position.y) / buttonUpDownRange;       
        upgradeButtons.SetActive(false);
    }
    public void ButtonActive()
    {
        upgradeButtons.SetActive(true);
        StartCoroutine(ButtonUP());
        Time.timeScale = 0;
    }

    IEnumerator ButtonUP()
    {
        AbilitySelect();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < buttonTransformY; j++)
            {
                button[i].transform.position += new Vector3(0, buttonUpDownRange, 0);
                yield return new WaitForSecondsRealtime(0.0001f);
            }
            yield return new WaitForSecondsRealtime(0.25f);
        }
    }
    public IEnumerator ButtonDown()
    {
        for (int j = 0; j < buttonTransformY; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                button[i].transform.position -= new Vector3(0, buttonUpDownRange, 0);
            }
            yield return new WaitForSecondsRealtime(0.0001f);
        }
        upgradeButtons.SetActive(false);
    }

    void AbilitySelect()
    {
        List<string> list = new List<string>();
        List<int> numberList = new List<int>();
        for (int i = 0; i < abilityRandomRange; ++i)
        {
            list.Add(playerAbilityList.abilityList[i]);
            numberList.Add(playerAbilityList.abilityNumber[i]);
        }
        for (int i = 0; i < button.Length; ++i)
        {
            int a = Random.Range(0, list.Count);
            string abilityName = list[a];
            button[i].gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = abilityName;
            button[i].GetComponent<ButtonClickEvent>().buttonAbilityNumber = numberList[a];
            list.RemoveAt(a);
            numberList.RemoveAt(a);
        }
    }
}
