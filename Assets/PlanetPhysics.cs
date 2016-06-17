using UnityEngine;
using System.Collections;

public class PlanetPhysics : MonoBehaviour {

    private Transform trans;

    public GameObject parent;
    public float radius;
    private float centerX;
    private float centerY;
    public float period = 1f;
	private float angle = 0;

	// Use this for initialization
	void Start () {
        trans = GetComponent<Transform>();
		centerX = parent.transform.position.x;
		centerY = parent.transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void FixedUpdate()
    {
		angle += period * Time.deltaTime;
		trans.position = new Vector3(
			Mathf.Cos(angle) * radius + centerX,
			Mathf.Sin(angle) * radius + centerY, 
			transform.position.z);
    }
}
