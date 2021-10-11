using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void stage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void stage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void stage3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void stage4()
    {
        SceneManager.LoadScene("Stage4");
    }
    public void stage5()
    {
        SceneManager.LoadScene("Stage5");
    }
    public void stage6()
    {
        SceneManager.LoadScene("Stage6");
    }
    public void Prob1()
    {
        SceneManager.LoadScene("Problem1");
    } 
    public void Prob2()
    {
        SceneManager.LoadScene("Problem2");
    } 
    public void Prob3()
    {
        SceneManager.LoadScene("Problem3");
    } public void Prob4()
    {
        SceneManager.LoadScene("Problem4");
    } public void Prob5()
    {
        SceneManager.LoadScene("Problem5");
    } public void Prob6()
    {
        SceneManager.LoadScene("Problem6");
    } public void Prob7()
    {
        SceneManager.LoadScene("Problem7");
    } public void Prob8()
    {
        SceneManager.LoadScene("Problem8");
    } public void Prob9()
    {
        SceneManager.LoadScene("Problem9");
    } public void Prob10()
    {
        SceneManager.LoadScene("Problem10");
    }  public void menus()
    {
        SceneManager.LoadScene("MenuManager");
    } public void quittt()
    {
        Application.Quit();
    } 
    
}
