using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColorScript : MonoBehaviour
{

    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject closestSphere = null;
        GameObject farthestSphere = null;


        // iterating through the children in the parent element with FOR
        //for (var i = 0; 1 < transform.childcount; i++)
        //{

        //    // elaborate version
        //    var childsphere = transform.getchild(i);    //put the child in a variable
        //    var renderer = childsphere.gameobject.getcomponent<renderer>(); // get the renderer of the variable
        //    renderer.material.color = new color(1, 0, 0);


        //    // compact version
        //    transform.getchild(i).gameobject.getcomponent<renderer>().material.color = new color(0, 1, 0);

        //    /*color vs color word
        //      color is a property
        //      color is a type, allows to store rgb-value*/

        //}


        // iterating through the children in the parent element with FOREACH
        foreach (Transform childSphere in transform)
        {
            childSphere.gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 1);

            var cs = childSphere.position;

            // to connect to the cube which is NOT a child of the plane by introducing a new gameobject above
            var cc = Cube.transform.position;
            
            var d = cs - cc;

            // magnitude gets the length
            var distance = d.magnitude;
            Debug.Log(distance);


            // Sorting-Technique
            // || ... boolean OR
            // A || B ... true if either A or B is true
            // A ... closestSphere == null
            // B ... distance < (closestSphere.transform.position - cc).magnitude

            // closestSphere == null .... means when we first start looking for the closest sphere, the first childsphere will always be the closest CURRENTLY
            if (closestSphere == null || distance < (closestSphere.transform.position - cc).magnitude)
            {
                closestSphere = childSphere.gameObject;
            }

            // closestSphere == null .... means when we first start looking for the closest sphere, the first childsphere will always be the closest CURRENTLY
            if (farthestSphere == null || distance > (farthestSphere.transform.position - cc).magnitude)
            {
                farthestSphere = childSphere.gameObject;
            }
        }

        closestSphere.gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        farthestSphere.gameObject.GetComponent <Renderer>().material.color = new Color(1, 0, 0);
            
    }
}


/*
 */
