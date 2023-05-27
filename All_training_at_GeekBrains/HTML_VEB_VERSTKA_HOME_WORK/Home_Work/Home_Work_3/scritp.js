let menuActive = document.querySelector('.Spisok_Menu')
let headerMenu = document.querySelector('.Menu')

function toggleMenu() {
  menuActive.classList.toggle('Inviz')
}

headerMenu.addEventListener('click', toggleMenu)






