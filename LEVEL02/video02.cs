using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class video02 : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("beautiful", () =>
        {
            Go();
        });

        keywords.Add("rabbit", () =>
        {
            Go01();
        });

        keywords.Add("tiger", () =>
        {
            Go02();
        });

        keywords.Add("long", () =>
        {
            Go03();
        });

        keywords.Add("penguin", () =>
        {
            Go04();
        });

        keywords.Add("zebra", () =>
        {
            Go05();
        });

        keywords.Add("colorful", () =>
        {
            Go06();
        });

        keywords.Add("peacock", () =>
        {
            Go07();
        });

        keywords.Add("crocodile", () =>
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
        txtDisplayA008.textDisplayA008 += "beautiful";
    }

    void Go01()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA007.textDisplayA007 += "peacock";
    }

    void Go02()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA009.textDisplayA009 += "tiger";
    }

    void Go03()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA008.textDisplayA008 += "beautiful";
    }

    void Go04()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA007.textDisplayA007 += "peacock";
    }

    void Go05()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
       score02.Score -= 2;
        txtDisplayA009.textDisplayA009 += "tiger";
    }

    void Go06()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA008.textDisplayA008 += "beautiful";
    }

    void Go07()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA007.textDisplayA007 += "peacock";
    }

    void Go08()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA009.textDisplayA009 += "tiger";
    }
}
