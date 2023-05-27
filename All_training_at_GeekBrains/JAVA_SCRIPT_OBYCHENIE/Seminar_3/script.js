// // Задание 1
// function user(firstName, secondName, age) {
//   console.log(`Привет ${firstName} ${secondName} с возрастом ${age}`)
// }
// let firstName = prompt(`Пожалуйста введите своё имя`)
// let secondName = prompt(`Пожалуйста введите свою фамилию`)
// let age = +prompt(`Пожалуйста введите свой возраст`)
// user(firstName, secondName, age)

// // Задание 2
// function Kvadrat(x) {
//   console.log(`Квадрат ${x} = ${x*x} `)
// }
// let x = +prompt(`Введите х`)
// Kvadrat(x);

// // Задание 3
// function Proverka(x, y) {
//   console.log((x>=0) ? '+++' : '---')
// }
// let x = +prompt(`Введите х`)
// let y = +prompt(`Введите y`)
// Proverka(x, y)

// // Задание 4
// const sum = (x, y, z) => {
// let summa = 0;
// return summa = x + y + z
// }
// let x = +prompt(`Введите х`)
// let y = +prompt(`Введите y`)
// let z = +prompt(`Введите z`)
// console.log(sum(x, y, z))

// // Задание 5
// let param1 = 1;
// let param2 = 2;
// let param3 = 3;
// console.log(sum(param1, param2, param3))

// // Задание 6
// const kvadratKoren = (x) => {
//   return Math.sqrt(x);
// }
// let first = kvadratKoren(3);
// let second = kvadratKoren(4);
// console.log(`Сумма = ${first + second}`)

// // Задане 7
// const number = (x,y) => {
//   if (x>y) {
//     return x
//   } else if (x<y) {
//     return y
//   } else {
//     return 'Числа равны'
//   } 
// }
// console.log(number(35, 35))

// // Задание 8
// const dayWeek = (x) => {
//   switch (x) {
//     case 1:
//       return 'понедельник'
//       break;
//     case 2:
//     return 'вторник'
//       break;
//       case 3:
//     return 'среда'
//     break;
//     case 4:
//     return 'четверг'
//     break;
//     case 5:
//     return 'пятница'
//     break;
//     case 6:
//     return 'суббота'
//     break;
//     case 7:
//     return 'воскресенье'
//     default:
//       return 'Ошибка либо в написании числа либо в тебе'
//   }
// }
// let day = +prompt('Введите номер дня')
// day = dayWeek(day)
// console.log(day)

// // Задание 9
// const privet = (name) => {
//   let date = new Date().getHours();
//   if (date >=6 && date <12) {
//     return `Доброе утро ${name}`
//   } else if (date >= 12 && date < 18){
//     return `Доброе день ${name}`
//   } else if (date >= 18 && date < 24){
//     return `Добрый вечер ${name}`
//   }
//   else {
//     return `Доброй ночи ${name}`
//   }
// }
// console.log(privet('Алексей'));




