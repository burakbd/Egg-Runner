using UnityEngine;
[System.Serializable]
public enum SIDE { Left, Mid, Right }
public class Playermove : MonoBehaviour
{
	public GameManager gameManager;
	Animator Animi;
	SwipeManager Swp;
	public float movementSpeed;
	private PlayerSecondMove Psc;
	AudioSource dance;
	AudioSource yurume;
	public SIDE m_Side = SIDE.Mid;
	float NewXPos = 0f;
	[HideInInspector]
	public bool SwipeLeft, SwipeRight, SwipeUp, SwipeDown;
	public float XValue;
	private CharacterController m_char;
	private float x;
	private float SpeedDonus = 10f;
	public float JumpPower = 7f;
	private float y;
	public bool InJump;

	private void Start()
	{
		Psc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSecondMove>();
		Animi = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
		yurume = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
		dance = gameManager.GetComponent<AudioSource>();
		m_char = GetComponent<CharacterController>();
		Swp = GameObject.FindGameObjectWithTag("Player").GetComponent<SwipeManager>();
	}

    private void Update()
    {
		SwipeLeft = Input.GetKeyDown(KeyCode.A) || SwipeManager.swipeLeft;
		SwipeRight = Input.GetKeyDown(KeyCode.D) || SwipeManager.swipeRight;
		SwipeUp = Input.GetKeyDown(KeyCode.W) || SwipeManager.swipeUp;

		if (SwipeLeft)
		{
			if (m_Side == SIDE.Mid)
			{
				NewXPos = -XValue;
				m_Side = SIDE.Left;
			}
			else if (m_Side == SIDE.Right)
			{
				NewXPos = 0;
				m_Side = SIDE.Mid;
			}
		}
		else if (SwipeRight)
		{
			if (m_Side == SIDE.Mid)
			{
				NewXPos = XValue;
				m_Side = SIDE.Right;
			}
			else if (m_Side == SIDE.Left)
			{
				NewXPos = 0;
				m_Side = SIDE.Mid;
			}

		}
		Vector3 moveVector = new Vector3(x - transform.position.x, y * Time.deltaTime, movementSpeed * Time.deltaTime);
		x = Mathf.Lerp(x, NewXPos, Time.deltaTime * SpeedDonus);
		m_char.Move(moveVector);
		Jump();
	}

	public void RestartMove()
	{
		LeanTween.moveZ(gameObject, -192.2284f, 0f);
		LeanTween.moveY(gameObject, 6.41112f, 0f);
		Psc.enabled = false;
		dance.enabled = false;
		yurume.enabled = true;
		Swp.enabled = true;
	}

	public void Jump()
    {
		if (m_char.isGrounded)
        {
            if (SwipeUp)
            {
				y = JumpPower;
				Animi.SetBool("Jump", true);
				InJump = true;
            }
        }else
        {
			y -= JumpPower * 2 * Time.deltaTime;
			Animi.SetBool("Jump", false);
		}
    }
	public void FinishMove()
	{
		LeanTween.moveZ(gameObject, gameObject.transform.position.z + 15f, 2f);
	}

}	






