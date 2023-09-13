using UnityEngine;

public class control_player : MonoBehaviour
{
    //public float moveSpeed = 0.03f;
    //public float turnSpeed = 10f;
    //public GameObject panel;

    //void Start()
    //{
    //    panel.SetActive(false);
    //}

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "xingbiao")
    //    {
    //        Debug.Log("TriggerWall");
    //        panel.SetActive(true);
    //    }
    //    else if (other.gameObject.tag == "box")
    //    {
    //        Debug.Log("Triggerbox");
    //    }
    //}
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        transform.position -= new Vector3(0, 0, -moveSpeed);
    //        transform.Rotate(turnSpeed, 0, 0);
    //    }
    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        transform.position += new Vector3(0, 0, -moveSpeed);
    //        transform.Rotate(-turnSpeed, 0, 0);
    //    }
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        transform.position += new Vector3(-moveSpeed, 0, 0);
    //        transform.Rotate(0, 0, turnSpeed);
    //    }
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        transform.position -= new Vector3(-moveSpeed, 0, 0);
    //        transform.Rotate(0, 0, -turnSpeed);
    //    }
    //}


    /// <summary>
    /// 以下为优化后的代码
    /// </summary>
    public float moveSpeed = 5f;
    public float turnSpeed = 10f;
    public GameObject panel;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        panel.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "xingbiao")
        {
            Debug.Log("TriggerWall");
            panel.SetActive(true);
        }
        else if (other.gameObject.tag == "box")
        {
            Debug.Log("Triggerbox");
        }
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);

        rb.AddForce(movement * moveSpeed);

        if (horizontal != 0 || vertical != 0)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, turnSpeed * Time.deltaTime);
        }
    }
}
