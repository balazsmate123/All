document.getElementById("login").onsubmit = function(event){
event.defaultPrevented();
fetch('https://192.168.10.10:8500/Pizza',{
  mode: "cors",
  headers:Acces-Control-Allow-origin
        })
    .then(function(response){
        if(!response.ok){
            return promise.reject();
        }
        return response.json();
    })}