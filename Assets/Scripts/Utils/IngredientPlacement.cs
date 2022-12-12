using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class IngredientPlacement : MonoBehaviour
    {
        private Dictionary<string, int> used = new();
    
        private List<string> ingredients = new() { "salami", "olive", "tomato", "mushroom", "mozzarella", "pepper" };
    
        [SerializeField] Transform parent;
    
        private void OnCollisionEnter(Collision collision)
        {
            if (!ingredients.Contains(collision.gameObject.name)) return;
        
            used[collision.gameObject.name] = used.ContainsKey(collision.gameObject.name) ?  used[collision.gameObject.name] + 1 : 1;
            
            collision.transform.SetParent(parent);

            // freeze position
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.isKinematic = true;
        }
    }
}
