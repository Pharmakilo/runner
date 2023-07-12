
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cammover : MonoBehaviour

{
    public Transform cameraTarget;
    public float sSpeed;
    public Vector3 dist;
    public Transform lookTarget;

    // Start is called before the first frame update
    private void LateUpdate()
    {
        Vector3 dPos = cameraTarget.position+dist;

        Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed* Time.deltaTime) ;
        transform.position = sPos;
        transform.LookAt(lookTarget.position);


}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
