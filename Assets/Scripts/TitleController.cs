using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        //シーン切り替えTitel→MainScene
        SceneManager.LoadScene("MainScene");
    }
}
