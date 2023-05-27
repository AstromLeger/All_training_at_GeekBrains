// Задание 3
const data = JSON.parse(dataInfo)
console.log(data);
const div = document.querySelector('.content')
data.reverse().forEach(obj => {
  div.insertAdjacentHTML('afterend', `
  <p>id - ${obj.id}</p>
  <img src="${obj.url}" width="${obj.width}" height="${obj.height}">

  
  
  `)
  
});





























































































