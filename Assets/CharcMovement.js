

function Update () {
		
		if (Input.GetKeyDown ("space"))
		{
			animation.Play("jump", PlayMode.StopAll);
		} else if (Input.GetKeyDown("up"))
		{
			animation.Play("run", PlayMode.StopAll);
		}
		 else if (Input.GetKeyDown("down"))
		{
			animation.Play("kick", PlayMode.StopAll);
		}
	    else if (Input.GetKeyDown("right"))
		{
			animation.Play("flip", PlayMode.StopAll);
		}else if (Input.GetKeyDown("left"))
		{
			animation.Play("death", PlayMode.StopAll);
		}
		else 
		{
		}
			
}