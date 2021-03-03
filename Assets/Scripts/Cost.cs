using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cost : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TowerNew.level == 1)
        {
            GetComponent<Text>().text = "Cost: " + 10;
        }
        else if (TowerNew.level == 2)
        {
            GetComponent<Text>().text = "Cost: " + 15;
        }
        else if (TowerNew.level == 3)
        {
            GetComponent<Text>().text = "Cost: " + 20;
        }
        else if (TowerNew.level == 4)
        {
            GetComponent<Text>().text = "Cost: " + 25;
        }
        else if (TowerNew.level == 5)
        {
            GetComponent<Text>().text = "Cost: " + 30;
        }
        else if (TowerNew.level == 6)
        {
            GetComponent<Text>().text = "Cost: " + 35;
        }
        else if (TowerNew.level == 7)
        {
            GetComponent<Text>().text = "Cost: " + 40;
        }
        else if (TowerNew.level == 8)
        {
            GetComponent<Text>().text = "Cost: " + 45;
        }
        else if (TowerNew.level == 9)
        {
            GetComponent<Text>().text = "Cost: " + 50;
        }
    }
}
