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
//        // Получаем текущий язык из PlayerPrefs
//        int language = PlayerPrefs.GetInt("language", 0);

//        // Устанавливаем текст в зависимости от выбранного языка
//        if (language == 0) // Английский
//        {
//            scoreTxt.text = "<size=45><color=#E06156>best:</color></size>" + PlayerPrefs.GetInt("score");
//            nowTxt.text = "<size=45>now:</size> " + maxY;
//        }
//        else if (language == 1) // Русский
//        {
//            scoreTxt.text = "<size=45><color=#E06156>лучший:</color></size>" + PlayerPrefs.GetInt("score");
//            nowTxt.text = "<size=45>сейчас:</size> " + maxY;
//        }
//    }
//}
