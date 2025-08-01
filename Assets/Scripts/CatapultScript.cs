using UnityEngine;
using UnityEngine.UI;

public class CatapultScript : MonoBehaviour
{
    public Animator armAnimator;
    public Slider angleSlider;
    public Slider forceSlider;
    public Transform turret;
    public Transform shootPoint;
    public Rigidbody ammoBody;
    public Vector3 launchDirection = new Vector3(0, 1, 1);
    public float launchForce = 10.0f;
    public float rotationSpeed = 100.0f;
    private float launchAngle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetCatapult();
        }
        RotateCatapult();
    }

    void Launch()
    {
        ammoBody.transform.parent = null;
        ammoBody.isKinematic = false;
        launchAngle = (angleSlider.value * Mathf.PI) / 180;
        launchDirection = Mathf.Cos(launchAngle) * turret.forward + Mathf.Sin(launchAngle) * Vector3.up;
        launchForce = forceSlider.value;
        ammoBody.AddForce(launchDirection.normalized * launchForce, ForceMode.Impulse);
        armAnimator.SetTrigger("Launch");
    }

    void ResetCatapult()
    {
        ammoBody.transform.parent = shootPoint;
        ammoBody.isKinematic = true;
        ammoBody.transform.position = shootPoint.position;
    }

    void RotateCatapult()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        turret.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
