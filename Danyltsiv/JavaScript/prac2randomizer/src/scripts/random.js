	export default function(from, to, except){
    let random = Math.floor(Math.random()*(to-from+1))+from;
		
    if (except!==undefined && except.length - 1 >= (to-from)) return false;
		
    while(except!==undefined  && except.length!==0 && except.includes(random))
    {
		random = Math.floor(Math.random()*(to-from+1))+from;
	}
		
        return random;
    };