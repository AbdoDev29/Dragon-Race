using UnityEngine;

public class Explotion : MonoBehaviour
{
    [SerializeField] float explotionForce, radiusExplotion,upwardsModifire;
    [SerializeField] ParticleSystem rockExplotion;
    public Transform cube;
    private Rigidbody rb;
    private GameManager gameManager;
    private AudioManager audioManager;
    public string tagName;
    
    private void Awake()
    {
        rb= GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
        audioManager = FindObjectOfType<AudioManager>();
    }
    private void Update()
    {
   

       
    }

    private void OnCollisionEnter(Collision dragon)
    {
       
        if (dragon.gameObject.tag == "Power")
        {
            rb.AddExplosionForce(explotionForce, cube.position, radiusExplotion, upwardsModifire, ForceMode.Impulse);
            Destroy(this.gameObject.transform.GetChild(0).gameObject,2);
            GetComponent<Collider>().enabled = false;

           if(dragon.gameObject.transform.parent.tag == "Player")
                audioManager.PlaySound("Collision");

        }
        else
        {
           
            if (dragon.gameObject.transform.parent.tag=="Player")
            {
                dragon.gameObject.GetComponent<Movement>().currentSpeed = 0;
                gameManager.GameOver();
            }
            else if (dragon.gameObject.transform.parent.tag == "Enemy")
            {
                dragon.gameObject.GetComponent<Movement>().currentSpeed = 0;
            }
        }
       
    }
    private void DissableCollider()
    {
            GetComponent<Collider>().enabled = false;
    }
 
}
