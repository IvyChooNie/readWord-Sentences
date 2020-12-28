using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;
using Proyecto26;
using UnityEngine.UI;

public class V6 : MonoBehaviour
{
    public Text scoreText;
    public InputField nameText;

    public static int playerScore;
    public static string playerName;

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {

        keywords.Add("She is cooking now", () =>
        {
            GoCalled14();
        });


        keywords.Add("She is dancing now", () =>
        {
            GoCalled16();
        });

        keywords.Add("She is jumping now", () =>
        {
            GoCalled17();
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

    void GoCalled14()
    {
        Debug.Log("Excellent. She is cooking now.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txtDisplayA6.textDisplayA6 += "Excellent. She is cooking now.";
        playerScore = ScoreBoard.Score;
    }



    void GoCalled16()
    {
        Debug.Log("Opps!You are wrong. She is cooking now.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txtDisplayA6.textDisplayA6 += "Opps.......She is cooking now.";
        playerScore = ScoreBoard.Score;
    }

    void GoCalled17()
    {
        Debug.Log("Opps!You are wrong. She is cooking now.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txtDisplayA6.textDisplayA6 += "Opps.......She is cooking now.";
        playerScore = ScoreBoard.Score;
    }

    public void OnSubmit()
    {
        playerName = nameText.text;
        PostToDatabase();
    }

    public void PostToDatabase()
    {
        User user = new User();
        RestClient.Post("https://fyp-testing1.firebaseio.com/.json", user);
    }
}
