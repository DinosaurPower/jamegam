using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Back : MonoBehaviour
{

    public Button backButton;

    public void BacktoMenuEnd()
    {
        SceneManager.LoadScene("Menu");
    }

}

