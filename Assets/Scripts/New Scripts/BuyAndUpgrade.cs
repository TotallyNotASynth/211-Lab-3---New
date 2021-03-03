using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAndUpgrade : MonoBehaviour
{
    public GameObject upgrade;
    public GameObject buy;
    public Text buttonName;
    private bool purch = false;
    public GameObject tower;

    public void NameChange()
    {
        buttonName.text = "Upgrade";
        purch = true;
    }
    public void TowerSpawnNew()
    {
        Instantiate(tower, transform.position, transform.rotation);
    }

    public void OnBuyTower()
    {
        if (Monry.money >= 5 && purch == false)
        {
            TowerSpawnNew();
            Monry.money -= 5;
            NameChange();
            upgrade.SetActive(true);
            buy.SetActive(false);
        }

    }

    public void OnUpgradeTower()
    {
        if (purch == true)
        {
            TowerNew.level++;
            //Monry.money -= ;
        }
    }
}
