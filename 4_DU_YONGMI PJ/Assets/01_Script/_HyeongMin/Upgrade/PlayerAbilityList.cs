using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilityList : MonoBehaviour
{
    //�ɷ� �߰��� ��ũ��Ʈ��
    [SerializeField] private Walk walk; //�츣�޽�, �߰�����
    [SerializeField] private Attack attack; //�ູâ, ���װ���
                                            //[SerializeField] private Enemy? ; //����, ����, ������, ����
                                            //����?
                                            //[SerializeField] private HP��ũ��Ʈ hp; //�߰�����
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
        Debug.Log("�츣�޽��� â");
    }
    void Ability2Upgrade()
    {
        //attack.
        Debug.Log("�ູ���� â");
    }
    void Ability3Upgrade()
    {
        //attack.
        Debug.Log("���� ����");
    }
    void Ability4Upgrade()
    {
        //attack.
        Debug.Log("������ ���� ����");
    }
    void Ability5Upgrade()
    {
        //���� ��ũ��Ʈ
        Debug.Log("���ڰ�");
    }
    void Ability6Upgrade()
    {
        //hp.
        //walk.speed *= 0.9f;
        Debug.Log("�߰� ����");
    }
    void Ability7Upgrade()
    {
        //
        Debug.Log("������ ���� �Ź�");
    }
    void Ability8Upgrade()
    {
        //
        bibleObj.SetActive(true);
        Debug.Log("����");
    }
    void Ability9Upgrade()
    {
        //
        Debug.Log("������");
    }
    void Ability10Upgrade()
    {
        //
        holyGrailObj.SetActive(true);
        Debug.Log("����");
    }

}
