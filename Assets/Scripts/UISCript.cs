using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class UISCript : MonoBehaviour
{
    public static UISCript instance;
    [SerializeField]
    TextMeshProUGUI killCounter_TMP;
    [HideInInspector]
    public int killCount; 



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

    private void Awake()
    {
        
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); 
        }    
    }

    public void UpdatekillCounterUI()
    {

        killCounter_TMP.text = killCount.ToString(); 
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
