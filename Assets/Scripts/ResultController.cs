using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour
{
    public void OnResultButtonClicked()
    {
        //シーン切り替えResult→MainScene
        SceneManager.LoadScene("MainScene");
    }

    public void OnTitleButtonClicked()
    {
        //シーン切り替えResult→Title
        SceneManager.LoadScene("Title");
    }
}
