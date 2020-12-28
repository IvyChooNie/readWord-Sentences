using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;
using Proyecto26;
using UnityEngine.UI;

public class voice05 : MonoBehaviour
{
    public Text scoreText;
    public InputField nameText;

    public static int playerScore;
    public static string playerName;

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("peanuts", () =>
        {
            Go();
        });

        keywords.Add("take some food", () =>
        {
            Go01();
        });

        keywords.Add("bake a cake", () =>
        {
            Go02();
        });

        keywords.Add("beans", () =>
        {
            Go03();
        });

        keywords.Add("cook noodles", () =>
        {
            Go04();
        });

        keywords.Add("find my mother", () =>
        {
            Go05();
        });

        keywords.Add("milk", () =>
        {
            Go06();
        });

        keywords.Add("cook a fish", () =>
        {
            Go07();
        });

        keywords.Add("open the bottle", () =>
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
        txtDisplayA00013.textDisplayA00013 += "milk";
       
    }

    void Go01()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA00015.textDisplayA00015 += "open the bottle";
        playerScore = score02.Score;
        scoreText.text = "Score: " + playerScore;
    }

    void Go02()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA00014.textDisplayA00014 += "bake a cake";
       
    }

    void Go03()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA00013.textDisplayA00013 += "milk";
       
    }

    void Go04()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA00014.textDisplayA00014 += "bake a cake";
        
    }

    void Go05()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA00015.textDisplayA00015 += "open the bottle";
        playerScore = score02.Score;
        scoreText.text = "Score: " + playerScore;
    }

    void Go06()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA00013.textDisplayA00013 += "milk";
        
    }

    void Go07()
    {
        Debug.Log("Try it again.");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score -= 2;
        txtDisplayA00014.textDisplayA00014 += "bake a cake";
    }

    void Go08()
    {
        Debug.Log("Excellent!");
        //this.transform.Translate(Vector3.up * 10.0f);
        score02.Score += 2;
        txtDisplayA00015.textDisplayA00015 += "open the bottle";
        playerScore = score02.Score;
        scoreText.text = "Score: " + playerScore;
    }

    public void OnSubmit()
    {
        playerName = nameText.text;
        PostToDatabase();
    }

    public void PostToDatabase()
    {
        User02 user = new User02();
        RestClient.Post("https://fyp-testing1.firebaseio.com/.json", user);
    }
}

