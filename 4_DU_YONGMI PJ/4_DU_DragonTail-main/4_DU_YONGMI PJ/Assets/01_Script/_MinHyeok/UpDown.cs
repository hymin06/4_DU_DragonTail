using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    public GameObject SulChang;
    public GameObject KeySulChang;

    public void OpenSulChang()
    {
        SulChang.SetActive(true);
    }
    public void DownSulChang()
    {
        SulChang.SetActive(false);
    }
    public void OpenKeySul()
    {
        KeySulChang.SetActive(true);
    }
    public void DownKeySul()
    {
        KeySulChang.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
