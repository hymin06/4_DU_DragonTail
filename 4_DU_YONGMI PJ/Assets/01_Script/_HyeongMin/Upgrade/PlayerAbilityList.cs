using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilityList : MonoBehaviour
{
    //능력 추가할 스크립트들
    [SerializeField] private Walk walk; //헤르메스, 중갑갑옷
    [SerializeField] private Attack attack; //축복창, 가죽가방
                                            //[SerializeField] private Enemy? ; //성물, 성경, 성수병, 성배
                                            //함정?
                                            //[SerializeField] private HP스크립트 hp; //중갑갑옷
    [SerializeField] private GameObject bibleObj;
    [SerializeField] private GameObject holyGrailObj;

    public string[] abilityList;
    public int[] abilityNumber;

    private void Start()
    {

    }
    public void AbilitySelect(int selectNumber)
    {
        Invoke("Ability" + selectNumber + "Upgrade", 0);
    }
    void Ability1Upgrade()
    {
        //walk.speed *= 1.1f;
        Debug.Log("헤르메스의 창");
    }
    void Ability2Upgrade()
    {
        //attack.
        Debug.Log("축복받은 창");
    }
    void Ability3Upgrade()
    {
        //attack.
        Debug.Log("성물 장착");
    }
    void Ability4Upgrade()
    {
        //attack.
        Debug.Log("쓸만한 가죽 가방");
    }
    void Ability5Upgrade()
    {
        //함정 스크립트
        Debug.Log("십자가");
    }
    void Ability6Upgrade()
    {
        //hp.
        //walk.speed *= 0.9f;
        Debug.Log("중갑 갑옷");
    }
    void Ability7Upgrade()
    {
        //
        Debug.Log("슬라임 점액 신발");
    }
    void Ability8Upgrade()
    {
        //
        bibleObj.SetActive(true);
        Debug.Log("성경");
    }
    void Ability9Upgrade()
    {
        //
        Debug.Log("성수병");
    }
    void Ability10Upgrade()
    {
        //
        holyGrailObj.SetActive(true);
        Debug.Log("성배");
    }

}
