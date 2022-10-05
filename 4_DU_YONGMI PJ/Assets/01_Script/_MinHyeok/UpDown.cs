using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
<<<<<<< Updated upstream
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
        
=======
    public GameObject SettingPan;
    public GameObject OtherPan;
    // Start is called before the first frame update
    void Start()
    {
        //SettingPan.SetActive(false);
    }
    public void OtherPanUp()
    {
        OtherPan.SetActive(true);
    }
    public void OtherPanDown()
    {
        OtherPan.SetActive(false);
    }
    public void SettingPanUp() 
    {
        SettingPan.SetActive(true);
    }
    public void SettingPanDown()
    {
        SettingPan.SetActive(false );
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
