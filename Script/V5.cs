using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class V5 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("I brush my teeth everyday", () =>
        {
            GoCalled06();
        });

        keywords.Add("I comb my hair everyday", () =>
        {
            GoCalled07();
        });

        keywords.Add("I wash my face everyday", () =>
        {
            GoCalled08();
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

    void GoCalled06()
    {
        Debug.Log("Excellent. I brush my teeth everyday.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txtDisplayA5.textDisplayA5 += "Excellent. I brush my teeth everyday.";
    }
    void GoCalled07()
    {
        Debug.Log("Opps!You are wrong. I am brushing my teeth.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txtDisplayA5.textDisplayA5 += "Opps...... I brush my teeth everyday.";
    }
    void GoCalled08()
    {
        Debug.Log("Opps!You are wrong. I am brushing my teeth.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txtDisplayA5.textDisplayA5 += "Opps...... I brush my teeth everyday.";
    }
}
