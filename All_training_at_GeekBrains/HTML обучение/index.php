<?php

require('data.php');
$newArray = $arrayTest;

?>



<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Моя первая страница</title>
    <link rel="shortcut icon" href="./img/klipartz.com.png"> 
    <link rel="stylesheet" type="text/css" href="./css/style.css">
    <script type="text/javascript" src="./js/test_script.js"></script>

</head>
<body>
    <!-- <script text="text/javascript">
        alert("И что ты тут забыл?")
    </script> -->
 <header>
   
   <h1>Заголовок страницы о чём то</h1>
   <img src="./img/Loga.jpeg" alt="Это наш логотип">
   <nav>
    <li><a href="./index.html">Главная страница</a></li>
    <li><a href="#aboutme"> Обо мне</a></li>
    <li><a href="#Tel"> Контакты</a></li>
    <li><a href="./Test.php">Текстовый блок</a></li>
    <li><a href="./weather.php">Погода JSON</a></li>
   </nav>
 </header>
 <div class="container">
    <div class="sidebar">
        <h2 id="aboutme">Обо мне</h2>
        <p><?= $let ?> consectetur adipisicing elit. Quia obcaecati, quidem repellendus quod officia architecto porro quos eligendi minus aspernatur, magni exercitationem nostrum provident ex in. Dolorem ipsum ratione quae?
        Saepe voluptatum explicabo voluptatibus dolorem sint aut blanditiis. Minima maiores repellendus quod sunt deleniti repudiandae quae vitae placeat exercitationem non blanditiis officia porro nemo, alias dolorem, at ratione fugiat iste!
        Obcaecati quas illo sit, non incidunt animi quaerat dolorum corporis deserunt dolorem possimus vitae, accusantium inventore repellendus saepe, numquam minus maxime? Cumque officia voluptate eaque hic eius vel aspernatur adipisci?
        Eum, sit! Eveniet dolore magni, nisi officiis laudantium qui quasi quos impedit praesentium quidem exercitationem consequuntur non tempore necessitatibus id velit assumenda fugit vel. Sequi dolorum deserunt nesciunt ea repudiandae.
        Fugit excepturi soluta adipisci nemo numquam ex minus, quaerat facilis explicabo non et aliquid quos animi magnam provident magni! Neque cumque molestias illum. Ea laudantium quisquam a! Quibusdam, necessitatibus placeat!</p>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quia obcaecati, quidem repellendus quod officia architecto porro quos eligendi minus aspernatur, magni exercitationem nostrum provident ex in. Dolorem ipsum ratione quae?
        Saepe voluptatum explicabo voluptatibus dolorem sint aut blanditiis. Minima maiores repellendus quod sunt deleniti repudiandae quae vitae placeat exercitationem non blanditiis officia porro nemo, alias dolorem, at ratione fugiat iste!
        Obcaecati quas illo sit, non incidunt animi quaerat dolorum corporis deserunt dolorem possimus vitae, accusantium inventore repellendus saepe, numquam minus maxime? Cumque officia voluptate eaque hic eius vel aspernatur adipisci?
        Eum, sit! Eveniet dolore magni, nisi officiis laudantium qui quasi quos impedit praesentium quidem exercitationem consequuntur non tempore necessitatibus id velit assumenda fugit vel. Sequi dolorum deserunt nesciunt ea repudiandae.
        Fugit excepturi soluta adipisci nemo numquam ex minus, quaerat facilis explicabo non et aliquid quos animi magnam provident magni! Neque cumque molestias illum. Ea laudantium quisquam a! Quibusdam, necessitatibus placeat!</p>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quia obcaecati, quidem repellendus quod officia architecto porro quos eligendi minus aspernatur, magni exercitationem nostrum provident ex in. Dolorem ipsum ratione quae?
        Saepe voluptatum explicabo voluptatibus dolorem sint aut blanditiis. Minima maiores repellendus quod sunt deleniti repudiandae quae vitae placeat exercitationem non blanditiis officia porro nemo, alias dolorem, at ratione fugiat iste!
        Obcaecati quas illo sit, non incidunt animi quaerat dolorum corporis deserunt dolorem possimus vitae, accusantium inventore repellendus saepe, numquam minus maxime? Cumque officia voluptate eaque hic eius vel aspernatur adipisci?
        Eum, sit! Eveniet dolore magni, nisi officiis laudantium qui quasi quos impedit praesentium quidem exercitationem consequuntur non tempore necessitatibus id velit assumenda fugit vel. Sequi dolorum deserunt nesciunt ea repudiandae.
        Fugit excepturi soluta adipisci nemo numquam ex minus, quaerat facilis explicabo non et aliquid quos animi magnam provident magni! Neque cumque molestias illum. Ea laudantium quisquam a! Quibusdam, necessitatibus placeat!</p>
    </div>
    <div class="main">
        <p><?= $newArray['ключ']; ?> consectetur adipisicing elit. Quia obcaecati, quidem repellendus quod officia architecto porro quos eligendi minus aspernatur, magni exercitationem nostrum provident ex in. Dolorem ipsum ratione quae?
        Saepe voluptatum explicabo voluptatibus dolorem sint aut blanditiis. Minima maiores repellendus quod sunt deleniti repudiandae quae vitae placeat exercitationem non blanditiis officia porro nemo, alias dolorem, at ratione fugiat iste!
        Obcaecati quas illo sit, non incidunt animi quaerat dolorum corporis deserunt dolorem possimus vitae, accusantium inventore repellendus saepe, numquam minus maxime? Cumque officia voluptate eaque hic eius vel aspernatur adipisci?
        Eum, sit! Eveniet dolore magni, nisi officiis laudantium qui quasi quos impedit praesentium quidem exercitationem consequuntur non tempore necessitatibus id velit assumenda fugit vel. Sequi dolorum deserunt nesciunt ea repudiandae.
        Fugit excepturi soluta adipisci nemo numquam ex minus, quaerat facilis explicabo non et aliquid quos animi magnam provident magni! Neque cumque molestias illum. Ea laudantium quisquam a! Quibusdam, necessitatibus placeat!</p>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quia obcaecati, quidem repellendus quod officia architecto porro quos eligendi minus aspernatur, magni exercitationem nostrum provident ex in. Dolorem ipsum ratione quae?
        Saepe voluptatum explicabo voluptatibus dolorem sint aut blanditiis. Minima maiores repellendus quod sunt deleniti repudiandae quae vitae placeat exercitationem non blanditiis officia porro nemo, alias dolorem, at ratione fugiat iste!
        Obcaecati quas illo sit, non incidunt animi quaerat dolorum corporis deserunt dolorem possimus vitae, accusantium inventore repellendus saepe, numquam minus maxime? Cumque officia voluptate eaque hic eius vel aspernatur adipisci?
        Eum, sit! Eveniet dolore magni, nisi officiis laudantium qui quasi quos impedit praesentium quidem exercitationem consequuntur non tempore necessitatibus id velit assumenda fugit vel. Sequi dolorum deserunt nesciunt ea repudiandae.
        Fugit excepturi soluta adipisci nemo numquam ex minus, quaerat facilis explicabo non et aliquid quos animi magnam provident magni! Neque cumque molestias illum. Ea laudantium quisquam a! Quibusdam, necessitatibus placeat!</p>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quia obcaecati, quidem repellendus quod officia architecto porro quos eligendi minus aspernatur, magni exercitationem nostrum provident ex in. Dolorem ipsum ratione quae?
        Saepe voluptatum explicabo voluptatibus dolorem sint aut blanditiis. Minima maiores repellendus quod sunt deleniti repudiandae quae vitae placeat exercitationem non blanditiis officia porro nemo, alias dolorem, at ratione fugiat iste!
        Obcaecati quas illo sit, non incidunt animi quaerat dolorum corporis deserunt dolorem possimus vitae, accusantium inventore repellendus saepe, numquam minus maxime? Cumque officia voluptate eaque hic eius vel aspernatur adipisci?
        Eum, sit! Eveniet dolore magni, nisi officiis laudantium qui quasi quos impedit praesentium quidem exercitationem consequuntur non tempore necessitatibus id velit assumenda fugit vel. Sequi dolorum deserunt nesciunt ea repudiandae.
        Fugit excepturi soluta adipisci nemo numquam ex minus, quaerat facilis explicabo non et aliquid quos animi magnam provident magni! Neque cumque molestias illum. Ea laudantium quisquam a! Quibusdam, necessitatibus placeat!</p>
        <li> <a href="./index.html">СП1</a></li>
        <li> <a href=""> СП2</a></li>
        <li> <a href=""> СП3</a></li>
    </div>
 </div>
 <footer>
    <p>&#169; Все права защищены. Мой сайт</p>
    <p> <a href="#top">Перейти вверх страницы</a> </p>
 </footer>
</body>
</html>