# Футбольный трасферный рынок
## `Содержание`
[Введение](#введение)

1 [Описание предметной области](#по)

1.1 [Указание на проблематику](#проблематика) 

1.2 [Формулировка задачи](#формулировка_задачи)

2  [Существующие решения проблемы](#решения_проблемы)

3 [Разработка](#разработка)

3.1 [Проектирование системы](#проектирование_системы)

3.2 [Реализация системы](#реализация_системы)

4 [Тестирование](#тестирование)

[Заключение](#заключение)

[Список литературы](#список_литературы)

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
***
## 3.1 Проектирование системы
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
## 3.2 Реализация системы
На основании ER-диаграммы создали классы. Примеры классов "Футболист" и "Менеджер" представленны на листингах 1 и 2 соответственно.

Листинг 1 - Класс "Футболист"

    public class Footballer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public string Club { get; set; }
        public string Country { get; set; }
        public decimal Money { get; set; }
    }
            

Листинг 2 - Класс "Менеджер"

    public class Manager
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }

Затем отпределили где они будут храниться, создав репозитории ......

Листинг 3 - Репрезиторий для класса "Футболист"

    public class FootballerStorage
    {
        private readonly Dictionary<int, Footballer> _Footballers = new();

        public Footballer Create(Footballer footballer)
        {
            _Footballers.Add(footballer.Id, footballer);
            return footballer;
        }

        public Footballer Read(int footballerId)
        {
            return _Footballers[footballerId];
        }

        public Footballer Update(int footballerId, Footballer newFootballer)
        {
            _Footballers[footballerId] = newFootballer;
            return _Footballers[footballerId];
        }

        public bool Delete(int footballerId)
        {
            return _Footballers.Remove(footballerId); 
        }
    }

Листинг 4 - Общеее хранилище

    public class Storage
    {
        public static readonly FootballerStorage footballerStorage = new();
        public static readonly ManagerStorage managerStorage = new();
        public static readonly ClubStorage clubStorage = new();
        public static readonly AcceptTheTransetionStorage attStorage = new();
        public static readonly ManagerSuggestionStorage managersuggestionStorage = new();
        public static readonly ContractStorage contractStorage = new();
        public static readonly AcceptContractStorage acceptcontractStorage = new();

    }
    
Разработали набор web-методов, включая 4 базисные операции CRUD, для каждой сущности, отражающих предметную область. Примеры контроллеров для классов "Футболист" и "Менеджер" представлены на листингах 5 и 6.

Листинг 5 - Контроллер для класса "Футболист"

    [ApiController]
    [Route("/footballer")]
    public class FootballerController : ControllerBase
    {
        [HttpPut("Create")]
        public Footballer Create(Footballer footballer)
        {
            Storage.footballerStorage.Create(footballer);
            return Storage.footballerStorage.Read(footballer.Id);
        }

        [HttpGet("Read")]
        public Footballer Read(int Id)
        {
            return Storage.footballerStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Footballer Update(int Id, Footballer newFootballer)
        {
            return Storage.footballerStorage.Update(Id, newFootballer);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.footballerStorage.Delete(Id);
        }
    }
  
Листинг 6 - Контроллер для класса "Менеджер"

    [ApiController]
    [Route("/manager")]
    public class ManagerController : ControllerBase
    {
        [HttpPut("Create")]
        public Manager Create(Manager manager)
        {
            Storage.managerStorage.Create(manager);
            return Storage.managerStorage.Read(manager.Id);
        }

        [HttpGet("Read")]
        public Manager Read(int Id)
        {
            return Storage.managerStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Manager Update(int Id, Manager newManager)
        {
            return Storage.managerStorage.Update(Id, newManager);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.managerStorage.Delete(Id);
        }
    }
  
***
## 4 Тестирование <a name ="тестирование"></a>
После запуска программы открывается страница Swagger UI со списком сущностей и операций над ними (см. рисунок 4).
![image](https://user-images.githubusercontent.com/85898336/147094212-8ab8d7d5-87ad-4837-ae5d-c1e15b6a94a6.png)

                                                Рисунок 4 - Cтраница Swagger UI
                                                
Проверка работы методов CRUD (Create - создание, Read - чтение, Update - обновление, Delete - удаление) в сущности Footballer (см. рисунок 5).
![image](https://user-images.githubusercontent.com/85898336/147095124-f1433517-183f-42ad-a844-80630f9cd6fe.png)
                                                
                                                Рисунок 5 -Проверка работы методов CRUD
                                                
1. Create позволяет добавлять новые строки в вашу таблицу (см. рисунок 6).
![image](https://user-images.githubusercontent.com/85898336/147095394-2072a0b6-256a-4c56-9d45-21845df33707.png)
                                                
                                                Рисунок 6 - Окно метода создания
                                                
Ввод необходимых данных об футболисте в соответствующие поля (см. рисунок 7).
![image](https://user-images.githubusercontent.com/85898336/147095721-866bad2b-4af6-4891-96f9-a7321e1f207c.png)

                                                Рисунок 7 - Работа с методом создания
                                                
После успешного выполнения операции сервер выдаёт ответ (см. рисунок 8).
![image](https://user-images.githubusercontent.com/85898336/147095885-e7315cba-2771-4ad7-a329-352732a796f5.png)

                                                Рисунок 8 - Результат выполнения операции создания
                                                
2.Функция чтения Read похожа на функцию поиска, поскольку позволяет извлекать определенные записи и считывать их значения (см. рисунок 9).
![image](https://user-images.githubusercontent.com/85898336/147096119-db9f6c43-86fc-4d99-a6a8-c8de21ceed40.png)

                                                Рисунок 9 - Окно функции чтения

Считывание информации об уже созданном футболисте по его Id (см. рисунок 10).
![image](https://user-images.githubusercontent.com/85898336/147096372-37789cd7-b1ee-4daa-9435-0ad3d17de20b.png)

                                                Рисунок 10 - Работа с методом чтения
                                                
После выполнения операции сервер выдаёт информацию об футболисте, которая была создана в Create (см. рисунок 11).
![image](https://user-images.githubusercontent.com/85898336/147096833-7cc4bc80-7f4d-4fe8-8a4e-2e049c51c1ab.png)

                                                Рисунок 11 - Результат выполнения операции чтения
                                                
3.Update, редактирование записи (см. рисунок 12). Используется для изменения существующих записей в базе данных.
![image](https://user-images.githubusercontent.com/85898336/147096990-474ab976-59e5-4336-a869-7f066a45c0eb.png)

                                                Рисунок 12 - Окно метода обновления
                                                
Изменение информации об футболисте, для этого сначала нужно ввести его номер и затем новые данные (см. рисунок 13).
![image](https://user-images.githubusercontent.com/85898336/147098947-70c6074f-6316-42f1-bb38-7d9d744f1211.png)

                                                Рисунок 13 - Работа с методом обновления
                                                
После выполнения операции сервер выдаёт новую информацию о том же футболисте (см. рисунок 14).
![image](https://user-images.githubusercontent.com/85898336/147099068-8b96b74c-0640-4b66-b78b-7fe548e7fad0.png)

                                                Рисунок 14 - Результат выполнения операции обновления

Функцией read проверка вышеуказанной операции. После срабатывания сервер выдает новую информацию об футболисте (см. рисунок 15).
![image](https://user-images.githubusercontent.com/85898336/147099304-1145706b-8768-486d-b939-778731ee0801.png)
                                                
                                                Рисунок 15 - Результат выполнения операции чтения после обновления данных
                                                
4.Delete - используется для удаления записи по Id. Если операция удаления сработает успешно, то ответ сервера будет "true", иначе "false" (см. рисунок 16).
![image](https://user-images.githubusercontent.com/85898336/147099461-70f39463-b728-461c-84d0-2223ffe4a472.png)

                                                Рисунок 16 - Окно метода удаления
                                                
Удаление футболиста по его Id (см. рисунок 17).
![image](https://user-images.githubusercontent.com/85898336/147099570-250dc756-65af-4a83-8c48-694bbe20911f.png)

                                                Рисунок 17 - Работа с методом удаления
                                                
После выполнения операции ответ сервера (см. рисунок 18).
![image](https://user-images.githubusercontent.com/85898336/147099664-f126d2b3-f08c-4011-859e-19fd21efd1a2.png)
                                                
                                                Рисунок 18 - Раезультат выполнения метода удаления
                                                
Проверка вышеописанного действия с помощью read, считывание информацию об удалённом покупателе (см. рисунок 19).
![image](https://user-images.githubusercontent.com/85898336/147099819-d816a0c0-bb3a-4677-aab2-857d708e07f2.png)
                                                
                                                Рисунок 19 - Работа с операцией чтения
                                                
После срабатывания программа не выдаёт информации об этом покупателе (см. рисунок 20).
![image](https://user-images.githubusercontent.com/85898336/147100202-5f8c4792-88b8-408f-8e35-16f2580c2806.png)

                                                Рисунок 20 - Результат выполнения операции чтения после удаления данных






***
## Заключение
***
## Список литературы
