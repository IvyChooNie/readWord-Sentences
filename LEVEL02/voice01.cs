using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class voice01 : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("dress", () =>
        {
            Go();
        });

        keywords.Add("balloon", () =>
        {
            Go01();
        });

        keywords.Add("lipstick", () =>
        {
            Go02();
        });

        keywords.Add("cheese", () =>
        {
            Go03();
        });

        keywords.Add("shoes", () =>
        {
            Go04();
        });

        keywords.Add("cherry", () =>
        {
            Go05();
        });

        keywords.Add("cream", () =>
        {
            Go06();
        });

        keywords.Add("rose", () =>
        {
            Go07();
        });

        keywords.Add("necklace", () =>
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
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
       txtDisplayA001.textDisplayA001 += "dress";
    }

    void Go01()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA003.textDisplayA003 += "balloon";
    }

    void Go02()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA003.textDisplayA003 += "balloon";
    }

    void Go03()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA002.textDisplayA002 += "cherry";

    }

    void Go04()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA001.textDisplayA001 += "dress";
    }

    void Go05()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA002.textDisplayA002 += "cherry";
    }

    void Go06()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA002.textDisplayA002 += "cherry";
    }

    void Go07()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA003.textDisplayA003 += "balloon";
    }

    void Go08()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA001.textDisplayA001 += "dress";
    }
}

