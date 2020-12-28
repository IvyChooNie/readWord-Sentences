using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class T2 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("It is a broccoli.", () =>
        {
            GoCalled();
        });

        keywords.Add("It is a lemon.", () =>
        {
            GoCalled01();
        });

        keywords.Add("It is a fish.", () =>
        {
            GoCalled02();
        });

        keywords.Add("It is a tiger.", () =>
        {
            GoCalled03();
        });

        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizerOnPhraseRecognizer;
        keywordRecognizer.Start();
    }

    void KeywordRecognizerOnPhraseRecognizer(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;

        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }

    }

    void GoCalled01()
    {
        Debug.Log("Good Job!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score03.Score += 5;
        txtDisplayB05.textDisplayB05 += "Excellent! You are right!";
    }

    void GoCalled02()
    {
        Debug.Log("Good Job!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score03.Score += 5;
        txtDisplayB06.textDisplayB06 += "Excellent! You are right!";
    }

    void GoCalled()
    {
        Debug.Log("Sorry...Your answer is wrong.");
        //this.transform.Translate(Vector3.up * 10.0f);
         score03.Score -= 2;
        txtDisplayB07.textDisplayB07 += "Opps! You are wrong...";
    }

    void GoCalled03()
    {
        Debug.Log("Sorry...Your answer is wrong.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score03.Score -= 2;
        txtDisplayB08.textDisplayB08 += "Opps! You are wrong...";
    }

}