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
Футболист- это спортсмен, занимающийся футболом.[1]
Клуб — это спортивная организация, участвующая в соревнованиях по футболу. Кроме собственно спортсменов-футболистов, в состав клуба входят тренер и его помощники, менеджеры клуба, врачи и прочий обслуживающий персонал. Непосредственно основная команда состоит из двадцати и более игроков.[2]
Менеджер- это посредник между клубом и футболистом, которые рассматривает предложения для обеих сторон и заключает трансфер между ними.
Футбольные трансферы — сделки, проводимые в период, специально отведённый для покупки и продажи игроков (трансферное окно). При этом футболист подписывает личный контракт, в котором оговаривается срок, в течение которого он должен играть за данную команду, а также зарплата, премиальные, бонусы и обязанности сторон. Стоимость игрока часто зависит не от объективной оценки его игры, а от того, на какую цену договорятся между собой представители клубов. История футбола знает немало случаев, когда более сильный игрок покупался за более низкую цену, чем другой, чуть менее талантливый футболист. Кроме денег, часто за игрока отдают бонусы от своего футболиста, в услугах которых клуб не нуждается.[3]
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
Других аналогов не имеется.
***
## 3 Разработка <a name ="разработка"></a>
Разработка информационной системы начинается с построения USE-CASE диаграммы (Диаграмма вариантов использования) , которая состоит из участников и прецендетов.(см. рисунок 1)

Участник - это множество логически связанных ролей, исполняемых при взаимодействии с прецедентами или сущностями (система, подсистема или класс). Участником может быть человек или другая система, подсистема или класс, которые представляют нечто вне сущности. Графически участник изображается “человечком”.

Прецедент - описание множества последовательных событий (включая варианты), выполняемых системой, которые приводят к наблюдаемому участником результату. Прецедент представляет поведение сущности, описывая взаимодействие между участниками и системой. Прецедент не показывает, “как” достигается некоторый результат, а только “что” именно выполняется. Прецеденты обозначаются очень простым образом - в виде эллипса, внутри которого указано его название.
![image](https://user-images.githubusercontent.com/85898336/146952795-0ee910f8-d36d-449f-9b47-073025f3c675.png)

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
