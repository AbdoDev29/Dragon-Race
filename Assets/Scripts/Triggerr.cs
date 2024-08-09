using UnityEngine;

public class Triggerr : MonoBehaviour
{
    public string tagName;
    [SerializeField] private bool die = false;
    [SerializeField] private float decreaseSpeed = 4;

    private GameManager gameManager;
    private void Awake()
    {
      gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerStay(Collider dragon)
    {
        if (dragon.transform.parent.tag == "Player")
        {

            if (dragon.gameObject.tag != tagName)
            {
                dragon.gameObject.GetComponent<Movement>().currentSpeed = 0;
               gameManager.GameOver();
            }
      
        }
      
    }


}
      


   



