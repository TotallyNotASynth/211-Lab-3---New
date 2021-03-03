using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonTrig : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene("Play");
    }
    public void OnBackButton()
    {
        SceneManager.LoadScene("Title");
    }
    
    public void OnUpgradeTower2()
    {
        if (Monry.money >= Tower1.cost2)
        {
            Tower1.countT2++;
            Monry.money -= Tower1.cost2;
        }
    }
    public void OnBuyTower2()
    {
        if (Monry.money >= 5)
        {
            TowerSpawn1.count1++;
            Monry.money -= 5;
        }
        
    }
}
