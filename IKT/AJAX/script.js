document.getElementById("fetch-post").onclick = function(){
    var xhr = new XMLHttpRequest;
    xhr.onreadystatechange = function(){
        if(xhr.readyState == 4 && xhr.status == 200){
            var post = (JSON.parse(xhr.responseText))
            var postListHTML = '';
            for(var post of posts){
                postListHTML += '<p>' + post.id + '</p>' + '<p>' + post.title + '</p><small>' + post.body + '</small>'
            }

            document.getElementById('post-list-container').innerHTML = postListHTML;
        }
    }
   
xhr.open('GET', 'https://jsonplaceholder.typicode.com/posts')

xhr.send();
}