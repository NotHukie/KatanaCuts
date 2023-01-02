using UnityEngine;

public class Utils : MonoBehaviour
{
    public static Vector3 ScreenToWorld(Camera camera, Vector3 position)
    {
        //public Ray ScreenPointToRay(Vector3 position);
        position.z = 1f;
        //Debug.Log(camera.ScreenToWorldPoint(position));
        //Debug.Log(position.z);
        Ray ray = camera.ScreenPointToRay(position);
        RaycastHit hit;


        if (Physics.Raycast(ray.origin, ray.direction, out hit))
        {
            position = hit.point;
            //Debug.Log(hit.collider.gameObject);
            collider1 script1 = hit.collider.gameObject.GetComponent<collider1>();
            Collider2 script2 = hit.collider.gameObject.GetComponent<Collider2>();
            Collider3 script3 = hit.collider.gameObject.GetComponent<Collider3>();
            Collider4 script4 = hit.collider.gameObject.GetComponent<Collider4>();
            if (script1 != null)
            {
                script1.Hited();
            }
            if (script2 != null)
            {
                script2.Hited();
            }
            if (script3 != null)
            {
                script3.Hited();
            }
            if (script4 != null)
            {
                script4.Hited();
            }
        }
        //Debug.Log(position);
        return position;
    }
}
