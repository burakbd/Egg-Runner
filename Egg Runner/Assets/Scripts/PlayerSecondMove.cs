using UnityEngine;

[System.Serializable]
public enum SIDES { Left, Mid, Right }
public class PlayerSecondMove : MonoBehaviour
{
		public GameManager gameManager;
		public float movementSpeed;
		public GameObject button›ki;
		public SIDES m_Side = SIDES.Mid;
		float NewXPos = 0f;
		[HideInInspector]
		public bool SwipeLeft, SwipeRight, SwipeUp, SwipeDown;
		public float XValue;
		private CharacterController m_char;
		private float x;
		private float SpeedDonus = 10f;
		public float JumpPower = 7f;
		public bool InJump;
		private void Start()
		{
			m_char = GetComponent<CharacterController>();
		}



		void Update()
		{
			SwipeLeft = Input.GetKeyDown(KeyCode.A) || SwipeManager.swipeLeft;
			SwipeRight = Input.GetKeyDown(KeyCode.D) || SwipeManager.swipeRight;
			SwipeUp = Input.GetKeyDown(KeyCode.W) || SwipeManager.swipeUp;

			if (SwipeLeft)
			{
				if (m_Side == SIDES.Mid)
				{
					NewXPos = -XValue;
					m_Side = SIDES.Left;
				}
				else if (m_Side == SIDES.Right)
				{
					NewXPos = 0;
					m_Side = SIDES.Mid;
				}
			}
			else if (SwipeRight)
			{
				if (m_Side == SIDES.Mid)
				{
					NewXPos = XValue;
					m_Side = SIDES.Right;
				}
				else if (m_Side == SIDES.Left)
				{
					NewXPos = 0;
					m_Side = SIDES.Mid;
				}

			}
		   Vector3 moveVector = new Vector3(0, 0.08f * movementSpeed * Time.deltaTime, movementSpeed * Time.deltaTime);
		   x = Mathf.Lerp(x, NewXPos, Time.deltaTime * SpeedDonus);
		   m_char.Move(moveVector);
		}

		
	
}

