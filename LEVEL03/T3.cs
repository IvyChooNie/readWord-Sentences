using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class T3 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("It is a cherry.", () =>
        {
            GoCalled();
        });

        keywords.Add("It is an orange.", () =>
        {
            GoCalled01();
        });

        keywords.Add("It is a chair.", () =>
        {
            GoCalled02();
        });

        keywords.Add("It is a towel.", () =>
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

    void GoCalled()
    {
        Debug.Log("Good Job!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score03.Score += 5;
        txtDisplayB09.textDisplayB09 += "Excellent! You are right!";
    }

    void GoCalled02()
    {
        Debug.Log("Good Job!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score03.Score += 5;
        txtDisplayB10.textDisplayB10 += "Excellent! You are right!";
    }

    void GoCalled01()
    {
        Debug.Log("Sorry...Your answer is wrong.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score03.Score -= 2;
        txtDisplayB11.textDisplayB11 += "Opps! You are wrong...";
    }

    void GoCalled03()
    {
        Debug.Log("Sorry...Your answer is wrong.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score03.Score -= 2;
        txtDisplayB12.textDisplayB12 += "Opps! You are wrong...";
    }

}
