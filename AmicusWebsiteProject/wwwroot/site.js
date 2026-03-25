// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



function collapse(){
    let element = document.querySelector(`navbar-collapse`);
    let element2 = document.querySelector(`hidden`);
    if (element){
        element.classList.add("hidden");
    }
    if(element2){
        element2.classList.remove("hidden");
    }
   
}

let url = null;

document.getElementById('imageInput').addEventListener('change', function(event) {
    const file = event.target.files[0];
    if (file) {
        // Create a temporary URL for the selected file
        url = URL.createObjectURL(file);
        document.getElementById('imageURL').value = url;
        document.getElementById('preview').src = url;
        document.getElementById('preview').style.display = 'block';
    }
});

function UpdateImage(Model){
    $.ajax({
        type: "POST",
        url: "MemberRepository.aspx/UpdateProfileImage", // PageName.aspx/MethodName
        data: "{url}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
    });
    /*
    $.ajax({UpdateProfileImage()});
    Model.MemberImage = url;*/
}