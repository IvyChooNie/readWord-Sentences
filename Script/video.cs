using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class video : MonoBehaviour
{
    public void load()
    {
        switch (this.gameObject.name)
        {
            case "01B":
                SceneManager.LoadScene("montage01");
                break;

            case "02B":
                SceneManager.LoadScene("montage02");
                break;

            case "03B":
                SceneManager.LoadScene("montage03");
                break;

            case "Button":
                SceneManager.LoadScene("Level 01");
                break;

            case "buttonToLevel02":
                SceneManager.LoadScene("DemoScene");
                break;

            case "buttonToLevel03":
                SceneManager.LoadScene("T1");
                break;


            case "r1":
                SceneManager.LoadScene("Level 01-2");
                break;

            case "r2":
                SceneManager.LoadScene("Level 01-3");
                break;

            case "r3":
                SceneManager.LoadScene("Load 01-4");
                break;

            case "r4":
                SceneManager.LoadScene("Load 01-5");
                break;

            case "r5":
                SceneManager.LoadScene("Load 01-6");
                break;

        }
    }
}

