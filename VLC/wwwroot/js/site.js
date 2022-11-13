// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function ToggleFavorite(id) {
    let btn = document.getElementById(id);
    btn.innerHTML = btn.innerText === "Save to Cookbook" ? btn.innerText = "&#128505; Recipe Saved!" : btn.innerText = "Save to Cookbook";
}