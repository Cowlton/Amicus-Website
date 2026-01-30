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