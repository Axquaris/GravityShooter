using UnityEngine;
using System.Collections;

public class PlanetPhysics : MonoBehaviour {

    public float mass;
    private Transform trans;

    public float maxGravityDist = 4.0f;
    public float gravityConst = 0.1f;
    public GameObject sun;

    float x;
    float y;
    public float width;
    public float height;
    public float centerX;
    public float centerY;

    //float centerX = sun.transform.position.x;
    //float centerY = sun.transform.position.y;
    float angle = 0;
    public float period = 6f;

	// Use this for initialization
	void Start () {
        trans = GetComponent<Transform>();
        centerX = sun.transform.position.x;
        centerY = sun.transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        angle += period * Time.deltaTime;
        x = Mathf.Cos(angle) * width ;
        y = Mathf.Sin(angle) * height;

        trans.position = new Vector3(
            x + centerX,
            y + centerY, 
            transform.position.z);
        
	}

    void FixedUpdate()
    {

    }
}
