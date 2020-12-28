using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class V3 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {

        keywords.Add("The boy likes to dance", () =>
        {
            GoCalled11();
        });

        keywords.Add("The uncle likes to dance", () =>
        {
            GoCalled12();
        });

        keywords.Add("The girl likes to dance", () =>
        {
            GoCalled13();
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

    void GoCalled12()
    {
        Debug.Log("Opps!You are wrong.The fishes are swimming in the water.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txtDisplayA3.textDisplayA3 += "Opps......The girl like to dance.";
    }

    void GoCalled13()
    {
        Debug.Log("Opps!You are wrong.The fishes are swimming in the water.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txtDisplayA3.textDisplayA3 += "Excellent! The girl like to dance.";
    }

    void GoCalled11()
    {
        Debug.Log("Excellent. The fishes are swimming in the water.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txtDisplayA3.textDisplayA3 += "Opps......The girl like to dance.";
    }
}
