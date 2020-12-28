using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class returnToSC : MonoBehaviour
{

    public void load()
    {
        switch (this.gameObject.name)
        {
            case "rt01":
                SceneManager.LoadScene("DemoScene");
                break;

            case "rt02":
                SceneManager.LoadScene("SC2");
                break;

            case "rt3":
                SceneManager.LoadScene("SC3");
                break;

            case "rt04":
                SceneManager.LoadScene("SC4");
                break;

            case "rt05":
                SceneManager.LoadScene("SC5");
                break;

        }
    }
        }
