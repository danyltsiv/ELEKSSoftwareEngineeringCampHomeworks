import getRandom from './random';
import animate from './animation';

let goBtn = document.getElementById('goBtn');
let number = document.getElementById('number');
let clrBtn = document.getElementById('clrBtn');
let unique = document.getElementById('unique');

goBtn.onclick = ()=>{
  let rnd;
  let numbers = [];
  let i = 0; 
  for (let a in localStorage)
  {
    numbers[i] = parseInt(localStorage[a]);
    i++;
  }
  
  if (getRandom(parseInt(from.value),parseInt(to.value),numbers)!=false) {

    animate((timePassed) => {
      if (!unique.checked){
      rnd = getRandom(parseInt(from.value),parseInt(to.value));
      } else {
      rnd = getRandom(parseInt(from.value),parseInt(to.value),numbers);
      }
      number.innerHTML = rnd;
      let fontSizeAnim = timePassed/20;
      number.style.fontSize = fontSizeAnim+'px';}, 4000);

      if (!unique.disabled) setTimeout(()=>{
        if(rnd!=undefined)
        {
          localStorage.setItem(localStorage.length,rnd);
        }
      },4100);
  } 
  else
  { 
    number.innerHTML = "<p class='error'>No more unique numbers! Reset the local storage please!</p>"
  }
  
}

  clrBtn.onclick = () => {
    localStorage.clear();
    number.innerHTML = "<p class='reseted'>Local Storage reseted succesfully!</p>"
  }  
  
  unique.onclick = () => {
	  localStorage.clear();
	  clrBtn.disabled = !unique.checked;
  }