using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class UIhandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNew()
    {
        SceneManager.LoadScene("main");
    }
    public void Exit()
    {
    // if (UNITY_EDITOR) {    
        EditorApplication.ExitPlaymode();
    // }    else {
        Application.Quit(); // original code to quit Unity player
    }   
}
