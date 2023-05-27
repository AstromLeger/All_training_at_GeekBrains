<?php

$ExperienceJob = [
'work_name' => ['Турбинщик', 'Автомеханик', 'Сварщик'],
'work_data' => ['1997-2013', '2006-20017', '1999-2006'],
'work_desc' => ['Креативный подход к делу', 'Стабильная отдача делу', 'Гуру в своем деле']
]
?>
<div class="w3-container w3-card w3-white w3-margin-bottom">
<h2 class="w3-text-grey w3-padding-16"><i
class="fa fa-suitcase fa-fw w3-margin-right w3-xxlarge w3-text-teal"></i>Опыт работы</h2>
<div class="w3-container">
<h5 class="w3-opacity"><b>
<?= $ExperienceJob['work_name'][0]; ?>
</b></h5>
<h6 class="w3-text-teal"><i class="fa fa-calendar fa-fw w3-margin-right"></i>
<?= $ExperienceJob['work_data'][0]; ?>
</h6>
<p>
<?= $ExperienceJob['work_desc'][0]; ?>
</p>
<hr>
</div>
<div class="w3-container">
<h5 class="w3-opacity"><b>
<?= $ExperienceJob['work_name'][1]; ?>
</b></h5>
<h6 class="w3-text-teal"><i class="fa fa-calendar fa-fw w3-margin-right"></i>
<?= $ExperienceJob['work_data'][1]; ?>
</h6>
<p>
<?= $ExperienceJob['work_desc'][1]; ?>
</p>
<hr>
</div>
<div class="w3-container">
<h5 class="w3-opacity"><b>
<?= $ExperienceJob['work_name'][2]; ?>
</b></h5>
<h6 class="w3-text-teal"><i class="fa fa-calendar fa-fw w3-margin-right"></i>
<?= $ExperienceJob['work_data'][2]; ?>
</h6>
<p>
<?= $ExperienceJob['work_desc'][2]; ?>
</p><br>
<p> Домашнее задание 2</p>
</div>
</div>