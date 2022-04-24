// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Get Btn Menu 
let btnmenu = document.querySelector("i.fas.fa-ellipsis-v");
console.log(btnmenu);
let menu = document.querySelector(".list-menu");
console.log(menu);
btnmenu.onclick = function () {
    menu.style.cssText = "display:flex;";
    hide.style.cssText = "display:block;";
    this.style.cssText = "display:none";
}
let hide = document.querySelector(".fa-times");
  hide.onclick = function () {
      menu.style.cssText = "display:none;";
      hide.style.cssText = "display:none;";
      btnmenu.style.cssText = "display:block";
};
