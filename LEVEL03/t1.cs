using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;
using Proyecto26;
using UnityEngine.UI;

public class t1 : MonoBehaviour
{


    public Text scoreText;
    public InputField nameText;

    public static int playerScore;
    public static string playerName;


    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("She is a girl.", () =>
        {
            GoCalled();
        });

        keywords.Add("He is a boy.", () =>
        {
            GoCalled01();
        });

        keywords.Add("It is a rainbow.", () =>
        {
            GoCalled02();
        });

        keywords.Add("It is a star.", () =>
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
        txtDisplayB01.textDisplayB01 += "Excellent! You are right!";
        
    }

    void GoCalled02()
    {
        Debug.Log("Good Job!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score03.Score += 5;
        txtDisplayB02.textDisplayB02 += "Excellent! You are right!";
        playerScore = score03.Score;
    }

    void GoCalled01()
    {
        Debug.Log("Sorry...Your answer is wrong.");
        //this.transform.Translate(Vector3.up * 10.0f);
       score03.Score -= 2;
        txtDisplayB03.textDisplayB03 += "Opps! You are wrong...";
    }

    void GoCalled03()
    {
        Debug.Log("Sorry...Your answer is wrong.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score03.Score -= 2;
        txtDisplayB04.textDisplayB04 += "Opps! You are wrong...";
        playerScore = score03.Score;
    }


    public void OnSubmit()
    {
        playerName = nameText.text;
        PostToDatabase();
    }

    public void PostToDatabase()
    {
        User03 user = new User03();
        RestClient.Post("https://fyp-testing1.firebaseio.com/.json", user);
    }
}
