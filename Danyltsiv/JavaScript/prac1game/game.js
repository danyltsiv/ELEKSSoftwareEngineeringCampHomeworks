function sortByLength(a,b){
    if (Math.abs(a.x-position.x)+Math.abs(a.y-position.y)>
    Math.abs(b.x-position.x)+Math.abs(b.y-position.y)) 
    return 1; else return -1;
    }

function sortByValue(a,b){
if (a.v<b.v) return 1;
else return -1;
}

Client.prototype.nextStep= function(position, targets) {
    var map = {
        0: 'left',
        1: 'right',
        2: 'up',
        3: 'down'
    }
if (targets.length === 0) return 'stay';
    
    targets.sort(sortByValue);
   
    if (targets[0].x>position.x)
       return 'right';
    else if(targets[0].x<position.x)
       return 'left';
    else if(targets[0].y>position.y)
       return 'down';
    else if (targets[0].y<position.y)
       return 'up';
}