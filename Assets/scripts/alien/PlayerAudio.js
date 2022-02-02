public var pulo : AudioClip;

function Update () {
	if(Input.GetKeyDown ("up")){
		if(!audio.isPlaying){
		audio.clip = pulo;
		audio.Play();
		}	
	}
}