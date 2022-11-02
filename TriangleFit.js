
let tri1= [1,2,4];
let tri2 = [1,2,6]; 
if(tri1.sort(function(a,b){return a-b})[2]>tri2.sort(function(a,b){return a-b})[2]){
    console.log('NO');
}else if(sum(tri1)<=sum(tri2)){
    console.log('YES')
}
else{
    console.log('No');
}

function sum(a){
    return a[0]+a[1]+a[2];
}