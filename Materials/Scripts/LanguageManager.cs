//using UnityEngine;
//using UnityEngine.UI;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.EventSystems;
//public class LanguageManager : MonoBehaviour
//{
//    public Text scoreTxt;
//    public Text nowTxt;

//    void Start()
//    {
//        UpdateText();
//    }

//    void UpdateText()
//    {
//        // �������� ������� ���� �� PlayerPrefs
//        int language = PlayerPrefs.GetInt("language", 0);

//        // ������������� ����� � ����������� �� ���������� �����
//        if (language == 0) // ����������
//        {
//            scoreTxt.text = "<size=45><color=#E06156>best:</color></size>" + PlayerPrefs.GetInt("score");
//            nowTxt.text = "<size=45>now:</size> " + maxY;
//        }
//        else if (language == 1) // �������
//        {
//            scoreTxt.text = "<size=45><color=#E06156>������:</color></size>" + PlayerPrefs.GetInt("score");
//            nowTxt.text = "<size=45>������:</size> " + maxY;
//        }
//    }
//}
