using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UISCript : MonoBehaviour
{

    public Health HealthScript;  
    public Text HealthText;
    public Slider HealthBar; 

    // Start is called before the first frame update
    void Start()
    {
        HealthBar.maxValue = HealthScript.GetMaxHealth();
        HealthBar.value = HealthScript.GetHealth();
        HealthText.text = "Health" + HealthScript.GetHealth(); 
        






        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
