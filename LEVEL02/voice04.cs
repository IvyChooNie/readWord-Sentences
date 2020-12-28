using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class voice04 : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("burger", () =>
        {
            Go();
        });

        keywords.Add("run away", () =>
        {
            Go01();
        });

        keywords.Add("pull by a boy", () =>
        {
            Go02();
        });

        keywords.Add("cupcake", () =>
        {
            Go03();
        });

        keywords.Add("kick by a boy", () =>
        {
            Go04();
        });

        keywords.Add("say sorry", () =>
        {
            Go05();
        });

        keywords.Add("cookies", () =>
        {
            Go06();
        });

        keywords.Add("push by a boy", () =>
        {
            Go07();
        });

        keywords.Add("buy a new cupcake", () =>
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
        txtDisplayA00010.textDisplayA00010 += "cupcake";
    }

    void Go01()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA00012.textDisplayA00012 += "said sorry";
    }

    void Go02()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA00011.textDisplayA00011 += "push by a boy";
    }

    void Go03()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA00010.textDisplayA00010 += "cupcake";
    }

    void Go04()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA00011.textDisplayA00011 += "push by a boy";
    }

    void Go05()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA00012.textDisplayA00012 += "said sorry";
    }

    void Go06()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA00010.textDisplayA00010 += "cupcake";
    }

    void Go07()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA00011.textDisplayA00011 += "push by a boy";
    }

    void Go08()
    {

        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA00012.textDisplayA00012 += "said sorry";
    }
}

