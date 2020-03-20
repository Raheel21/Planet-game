using UnityEngine;

public class Shooting : MonoBehaviour {

    [SerializeField] int damageDealt = 25;
    MeshRenderer laser;
    AudioSource audioSrc;
    [SerializeField] AudioClip shootclip; 

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        audioSrc = GetComponent<AudioSource>();

        laser = transform.GetChild(4).GetChild(1).gameObject.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; 
        }
        if (Input.GetButtonDown ("Fire1"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;  
            Ray mouseRay = GetComponentInChildren<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;
            audioSrc.clip = shootclip;
            audioSrc.Play(); 

            if (Physics.Raycast (mouseRay, out hitInfo))
            {
                Debug.DrawLine(transform.position, hitInfo.point, Color.red, 5.0f);
                EnemyHealth enemyHealth = hitInfo.transform.GetComponent<EnemyHealth>();
                if(enemyHealth !=null)
                {
                    
                    enemyHealth.Damage(damageDealt); 

                }
            }
            laser.enabled = true;
        }
        else { laser.enabled = false; }

        





































		
	}
}
