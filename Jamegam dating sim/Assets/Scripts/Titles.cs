using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Titles : MonoBehaviour
{

    public Button backButton;

    public void BacktoMenuEnd()
    {
        SceneManager.LoadScene("End");
    }

}

