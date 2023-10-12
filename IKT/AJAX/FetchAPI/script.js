var state = [];

document.getElementById("login").onsubmit = function(event){
    event.preventDefault();
    var email = event.target.elements.email.value;
    var password = event.target.elements.password.value;
    var body = JSON.stringify({
        email: email,
        password: password
    })
    console.log(body);
    fetch('https://reqres.in/api/login',{
        method: 'POST',
        body: body,
        headers: {
            'Content-type':'application/json'
        }
    })
    .then(function(response){
        if(!response.ok){
            return Promise.reject('login hiba!')
        }
        return response.json();
    })
    .then(function(response){
        return fetch('https://reqres.in/api/users')
    })
    .then (function(response){
        if(!response.ok){
            return Promise.reject('user hiba')
        }
        return response.json();
    })
    .then(function(userpage){
        state = userPage.data;
    })
    .catch(function(){
        console.log(error);
    })
};
function renderUsers(){
    var usersHTML = '';
    for(var user of state){
        userHTML += `<li class = "list-group-item">${user.first_name} ${user.last_name}</li>
        <li class = "list-group-item">${item.email}</li>
        <li class = "list-group-item"><center><img src="${user.avatar}"></li>
        <li class = "list-group-item">&nbsp&nbsp</li> 
        `
    }
    document.getElementById('user-lista-conatiner').innerHTML = '<ul class = "list-group">' + usersHTML + '</ul>';
}