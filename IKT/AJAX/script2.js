document.getElementById("login").onclick = function(){
    var url = 'https://reqres.in/api/login';

    var body = JSON.stringify({
        email: 'eve.hol@reqres.in',
        password:'bármi'
    })
    sendrequest(url, 'POST' , body, function(token){
        console.log(token)
    });

};

function sendrequest(url, method, body, callback){
var xhr = new XMLHttpRequest;
xhr.onreadystatechange =  function(){
    if(xhr.readyState == 4 && xhr.status == 200){
        callback(JSON.parse(xhr.responseText));
    }
}
xhr.open(method, url)
xhr.setRequestHeader('Content-type', 'application/json');
xhr.send(body);
}