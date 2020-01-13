using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UISCript : MonoBehaviour
{

    public Health healthScript;  
    public Text healthText;
    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.maxValue = healthScript.GetMaxHealth();
        healthBar.value = healthScript.GetHealth();
        healthText.text = "Health" + healthScript.GetHealth();

    }




        
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
