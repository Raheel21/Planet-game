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
    public TextMeshProUGUI healthText;
    public Slider healthBar;
    

    // Start is called before the first frame update
    void Start()
    {
        GameManager manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>(); 

        healthBar.maxValue = healthScript.GetMaxHealth();
        healthBar.value = healthScript.GetHealth();
        healthText.text = "Health:" + healthScript.GetHealth();

        StartCoroutine("UpdateUI");



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

    public void UpdateKillCounterUI()
    {

        killCounter_TMP.text = killCount.ToString();
        if (killCount > 2)
        {
            Timer.unhide = true;
            killCounter_TMP.text = ("Walk Path Unlocked"); 
        }

        else
        {
            killCounter_TMP.text = killCount.ToString();

        }





    }




    IEnumerator UpdateUI()
    {

        healthBar.maxValue = healthScript.GetMaxHealth();
        healthBar.value = healthScript.GetHealth();
        healthText.text = "Health:" + healthScript.GetHealth();

        if (healthScript.IsDead)
        {

            Time.timeScale = 0;


        }
        yield return new WaitForSeconds(0.5f);
        
    }


    // Update is called once per frame
    void Update()
    {
        healthBar.maxValue = healthScript.GetMaxHealth();
        healthBar.value = healthScript.GetHealth();
        healthText.text = "Health:" + healthScript.GetHealth();

    }
}
