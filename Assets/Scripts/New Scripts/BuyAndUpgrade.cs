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
        //Changes the button's name
        buttonName.text = "Upgrade";
        purch = true;
    }
    public void TowerSpawnNew()
    {
        //spawns a tower
        Instantiate(tower, transform.position, transform.rotation);
    }

    public void OnBuyTower()
    {
        //checks if you have enough money
        if (Monry.money >= 5 && purch == false)
        {
            //Calls a tower spawn
            TowerSpawnNew();
            //Takes the money
            Monry.money -= 5;
            //Changes button text
            NameChange();
            //Changes active button
            upgrade.SetActive(true);
            buy.SetActive(false);
        }

    }

    public void OnUpgradeTower()
    {
        //Checks if button is for upgrades
        if (purch == true)
        {
            //Upgrades tower
            TowerNew.level++;
            //Monry.money -= ;
        }
    }
}
