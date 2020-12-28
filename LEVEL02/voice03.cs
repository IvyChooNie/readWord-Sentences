using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class voice03 : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("elder", () =>
        {
            Go();
        });

        keywords.Add("shout at her", () =>
        {
            Go01();
        });

        keywords.Add("balls", () =>
        {
            Go02();
        });

        keywords.Add("older", () =>
        {
            Go03();
        });

        keywords.Add("sing a song", () =>
        {
            Go04();
        });

        keywords.Add("candy", () =>
        {
            Go05();
        });

        keywords.Add("baby", () =>
        {
            Go06();
        });

        keywords.Add("talk to her", () =>
        {
            Go07();
        });

        keywords.Add("teddy bear", () =>
        {
            Go08();
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

    void Go()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA004.textDisplayA004 += "baby";
    }

    void Go01()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA005.textDisplayA005 += "sing a song";
    }

    void Go02()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2; 
        txtDisplayA006.textDisplayA006 += "balls";
       
    }

    void Go03()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA004.textDisplayA004 += "baby";
    }

    void Go04()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA005.textDisplayA005 += "sing a song";
    }

    void Go05()
    {
        Debug.Log("Try it again");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA006.textDisplayA006 += "balls";
    }

    void Go06()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA004.textDisplayA004 += "baby";
    }

    void Go07()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA005.textDisplayA005 += "sing a song";
    }

    void Go08()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA006.textDisplayA006 += "balls";
    }
}

