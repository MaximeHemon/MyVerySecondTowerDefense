
using UnityEngine;

public class Detection : MonoBehaviour
{
    private Tower towerParent {get; set;} = null; 
    private void Start()
    {
        towerParent = GetComponentInParent<Tower>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponentInParent<Enemy>();
        if(enemy != null)
        {
            towerParent.AddEnemy(enemy);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Enemy enemy = other.GetComponentInParent<Enemy>();
        if(enemy != null)
        {
            towerParent.AddEnemy(enemy);
        }
    }

    private void Update()
    {
        
    }
}
