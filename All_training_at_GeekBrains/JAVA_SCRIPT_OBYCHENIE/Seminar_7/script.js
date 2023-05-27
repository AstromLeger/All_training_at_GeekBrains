// Задание 1
// const firstDiv = document.querySelector('.block')
// const secondDiv = document.createElement('div')
// firstDiv.appendChild(secondDiv)
// secondDiv.setAttribute('class', 'item_1')
// secondDiv.textContent = 'Элемент внутри'
// secondDiv.style.color = 'blue'
// secondDiv.style.border = '1px solid black'
// secondDiv.style.backgroundColor = "#f8f8f8"
// secondDiv.style.padding = '16px'

// Задание 2
// const first = document.querySelector('.text')
// console.log(first.previousElementSibling);
// console.log(first.parentElement);
// console.log(first.parentNode.previousElementSibling);
// console.log(first.parentNode.parentNode);

// Задание 3
// const elementH2 = document.querySelector('h2')
// console.log(elementH2.parentNode);
// console.log(elementH2.parentNode.parentNode);
// console.log(elementH2.parentNode.parentNode.parentNode);

// Задание 4
// Вариант 1
// const button = document.querySelector('button')
// const input = document.querySelector('input')
// button.onclick = function () {
//   if (input.value.length == 0) {
//     const textH2 = document.createElement('h2')
//     textH2.textContent = 'Вы не заполнили поле ввода'
//     input.style.border = '3px solid red'
//     // const form = document.querySelector('form')
//     // form1.appendChild(textH2)
//     button.parentNode.appendChild(textH2)
//   }
//   else {const form = document.querySelector('form')
//   form.removeChild(textH2)
// }
// }

// Вариант 2
const button = document.querySelector('button');
const input = document.querySelector('input');
const textH2 = document.createElement('h2')

button.onclick = function() {
    if (input.value.length ==0) {

textH2.textContent = ' Bы не заполнили поле ввода';
input.style.border = '3px solid red';

// const form = document.querySelector('form');
// form.append(textH2);

button.parentElement.appendChild(textH2);
    }
    else {const form = document.querySelector('form');
    form.removeChild(textH2);} 
}




































































