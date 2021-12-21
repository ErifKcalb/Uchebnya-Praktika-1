# Футбольный трасферный рынок
## `Содержание`
[Введение](#введение)

1 [Описание предметной области](#по)

1.1 [Указание на проблематику](#проблематика) 

1.2 [Формулировка задачи](#формулировка_задачи)

2  [Существующие решения проблемы](#решения_проблемы)

3 [Разработка](#разработка)

4 [Тестирование](#тестирование)

***
## Введение <a name ="введение"></a>
Темой проекта является "Футбольный трансферный рынок", позволяет дистанционно посмотреть информацию о футболистах и клубах, футболистам посмотреть менеджеров и их предложение, клуб посмотреть футболистов и заключить с ними контракт. Сегодня это особенно важно, ведь футболистам, менеджерам и клубам не придется лишний раз встречаться в условиях пандемии, так же это удобно. Это все позволяет обеспечить удобство на расстоянии, тем самым экономия время футболистов и клубов. На сегодняшний день данная информационная система является как никогда актульной в связи с эпидемией коронавируса и не имеющих прямых аналогов.
***
## 1 Описание предметной области <a name ="по"></a>
Футболист который желает поменять клуб и подписать с ним контракт, имел возможно посмотреть предложение менеджера в удобное для себя время. Клубы же могли дистиацианно смотреть предложение менеджеров и рассматриваться футболистов для подписания контрактов. Это облгечит работу между футболистами, менеджерами и клубами. 
***
  ### 1.1 Указание на проблематику <a name ="проблематика"></a>
  В связи занятностью футболистов и пандемической ситуацией, можно с помощью сайта рассматривать предложение, тем самым работать с трансферным рынком. Можно узнавать согласен ли футболист на условия, заинтересованны ли клубы в подписании конкретных игроков и рассмотреть предожение менеджера. Одна из основных проблем некоректная цена на футболистов, бывает игрок слишком завышен по трансферной стоимости необъективно, либо цена на футболиста изначально неверна. Представленная информационная система позволяет это всё удобно рассмотреть, чтобы не терять время не футболистам, не клубам.
  ### 1.2 Формулировка задачи <a name ="формулировка_задачи"></a>
  Целью проекта является создание сайта футбольного трансферна рынка, предоставляющий пользователям удобную и достоверную информацию о клубах и футболистах.
  
  Задачи:
  1. Предоставление простой и понятной информации футболисту, менеджеру и клубу.
  2. Возможность посмотреть дистанционно предложение менеджера клубам и футболистам.
  3. Футболисту дистианционно подписать контракт.
  4. Клубу дистиацианно подписать футболиста.
  5. Менеджеру дистиацианно работать с клубами и футболистами.
***
## 2 Существующие решения проблемы <a name ="решения_проблемы"></a>
Transfermarkt — немецкий веб-сайт, который содержит информацию о футболе, такую как счёт матчей, результаты турниров и трансферные новости. Несмотря на то, что стоимость игроков, наряду с некоторыми другими показателями, являются оценочными, исследователи из Центра изучения экономических показателей обнаружили, что «слухи» о трансферах и стоимости игроков в значительной степени точны.
Transfermarkt работает засчет системы база данных, в которых вносится информация о футболистах и последних трансферах.
Других аналогов не существует.
***
## 3 Разработка <a name ="разработка"></a>
Разработка информационной системы начинается с построения USE-CASE диаграммы (Диаграмма вариантов использования) , которая состоит из участников и прецендетов.(см. рисунок 1)

Участник - это множество логически связанных ролей, исполняемых при взаимодействии с прецедентами или сущностями (система, подсистема или класс). Участником может быть человек или другая система, подсистема или класс, которые представляют нечто вне сущности. Графически участник изображается “человечком”.

Прецедент - описание множества последовательных событий (включая варианты), выполняемых системой, которые приводят к наблюдаемому участником результату. Прецедент представляет поведение сущности, описывая взаимодействие между участниками и системой. Прецедент не показывает, “как” достигается некоторый результат, а только “что” именно выполняется. Прецеденты обозначаются очень простым образом - в виде эллипса, внутри которого указано его название.
![image](https://user-images.githubusercontent.com/85898336/146951119-3d7d006e-b238-40b0-a034-b518dae4a7ad.png)

                                                Рисунок 1 - Диаграмма вариантов использования

На основе USE-CASE диаграммы разрабатвается DFD диаграмма, которая наглядно отображает течение информации в пределах системы.(см. рисунок 2)
![image](https://user-images.githubusercontent.com/85898336/146951679-989f55e8-0073-46b4-8d72-9b9c68e94adf.png)

                                                Рисунок 2 - Диаграмма потоков данных

На основе DFD диаграммы проектируется схема «сущность-связь» (ER-диаграмма), где показано, как разные «сущности» (люди, объекты, концепции и так далее) связаны между собой внутри системы.(см. рисунок 3)
![image](https://user-images.githubusercontent.com/85898336/146952001-ee0da253-9c94-4532-abb0-f0a3cae2bfa2.png)

                                                Рисунок 3 - Диаграмма «сущность-связь»
***
## 4 Тестирование <a name ="тестирование"></a>
***
## Заключение
