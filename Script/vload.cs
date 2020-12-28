using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vload : MonoBehaviour
{
    public void load()
    {
        switch (this.gameObject.name)
        {
            case "rsb01":
                SceneManager.LoadScene("SC2");
                break;

            case "rb2":
                SceneManager.LoadScene("SC3");
                break;

            case "rb3":
                SceneManager.LoadScene("SC4");
                break;

            case "rb4":
                SceneManager.LoadScene("SC5");
                break;

            case "rs01":
                SceneManager.LoadScene("P1");
                break;

            case "rs02":
                SceneManager.LoadScene("P2");
                break;

            case "rs03":
                SceneManager.LoadScene("P3");
                break;

            case "rs04":
                SceneManager.LoadScene("P4");
                break;

            case "rs05":
                SceneManager.LoadScene("P5");
                break;
        }
    }
}
