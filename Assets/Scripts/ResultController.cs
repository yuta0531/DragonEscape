using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour
{
    public void OnResultButtonClicked()
    {
        //�V�[���؂�ւ�Result��MainScene
        SceneManager.LoadScene("MainScene");
    }

    public void OnTitleButtonClicked()
    {
        //�V�[���؂�ւ�Result��Title
        SceneManager.LoadScene("Title");
    }
}
