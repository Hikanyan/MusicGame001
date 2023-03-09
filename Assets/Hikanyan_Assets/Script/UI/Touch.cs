using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Touch : MonoBehaviour
{
    [SerializeField]
    string text;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Test);
    }

    void Test()
    {
        SceneManager.LoadScene(text);
    }
}
