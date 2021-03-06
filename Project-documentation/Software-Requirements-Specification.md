Следить за бюджетом - дело сложное. В наше время достаточно приложить карту/телефон/часы к терминалу, чтобы совершить покупку. Это настолько простые действия, что порой мы и не замечаем сколько и на какие товары мы тратим деньги. Время от времени проверяя баланс мы не понимаем, куда потратили деньги. Данное приложение поможет ответить Вам на этот вопрос! 

## Содержание: 

[Глоссарий](#Глоссарий) <br>
1. [Введение](#1) <br>
1.1. [Назначение](#1.1) <br>
1.2. [Соглашения, принятые в документах](#1.2) <br>
1.3. [Границы проекта](#1.3) <br>
1.4. [Аналоги](#1.4) <br>
2. [Требования пользователя](#2) <br>
2.1. [Программные интерфейсы](#2.1) <br>
2.2. [Интерфейс пользователя](#2.2) <br>
2.3. [Классы и характеристика пользователя](#2.3) <br>
2.4. [Предположения и зависимости](#2.4) <br>
3. [Системные требования](#3) <br>
3.1. [Функциональные требования](#3.1) <br>
3.2. [Нефункциональные требования](#3.2) <br>
3.2.1. [Бизнес-правила](#3.2.1) <br> 
3.2.2. [Атрибуты качества](#3.2.2) <br> 
3.2.2.1. [Требования к доступности](#3.2.2.1) <br> 
3.2.2.2. [Требования по удобству использования](#3.2.2.2) <br> 
3.2.2.3. [Требования к безопасности](#3.2.2.3) <br> 
3.3. [Ограничения](#3.3) <br>

## Глоссарий. <a name="Глоссарий"> </a> 
Чек - потраченная или приобретенная сумма, записанная пользователем.<br> 

## 1. Введение.<a name="1"></a>
### 1.1 Назначение.<a name="1.1"></a> 
Эта спецификация требований к ПО описывает функциональные и нефункциональные требования к выпуску Money-manager. Документ предназначен для разработчика, который будет реализовывать и проверять корректность системы.
### 1.2 Соглашения, принятые в документах.<a name="1.2"></a> 
В этой спецификации нет типографских условных обозначений.
### 1.3 Границы проекта.<a name="1.3"></a>
<p>Money-manager - мобильное приложение, целью которого является отслеживание финансовой деятельности пользователя.</p> 
<ul> 
<li>Пользователь может вводить данные о покупке.</li> 
<li>Пользователь может вводить данные о поступлении средств.</li> 
<li>Система должна хранить данные, введенные пользователем.</li> 
<li>Система должна с помощью графика представлять финансовую деятельность пользователя.</li> 
</ul> 

### 1.4 Аналоги.<a name="1.4"></a>
<ul> 
 <li><a href=http://www.dominsoft.ru/flash.php> MoneyTracker</a> - домашняя бухгалтерия. Основным недостатком, на мой взгляд, является то, что она предназначена для использования на ПК, но при этом у данной программы огромный функционал (нееобходимая пользователю информация настраивается, ведение истории цен, учет долгов и кредитов, календарь, мощные отчеты и др.)</li> 
<li><a href=https://vk.com/away.php?utf=1&to=https%3A%2F%2Fplay.google.com%2Fstore%2Fapps%2Fdetails%3Fid%3Dcom.droid4you.application.wallet> Wallet</a> - мобильное приложение для слежения за финансами. Приложение синхронизруется с банком пользователя и позволяет отслеживать банкогвские операции, , возможность нескольки учетных записей, , поддержка нескольких валют, отслеживание чеков и гарантий и многое другое следует отнести в плюсы данного приложения.</li> 
</ul> 


## 2. Требования пользователя.<a name="2"></a> 
### 2.1 Программные интерфейсы.<a name="2.1"></a> 
Использование фреймворка Xamarin, ЯП - C#. Использование БД SqLite. 
### 2.2 Интерфейс пользователя.<a name="2.2"></a> 
Интерфейс пользователя представлен с помощью<a href="https://github.com/DanaKlimova/Money-Manager/tree/master/Mockups"> мокапов.</a><br> 
а) <a href="https://github.com/DanaKlimova/Money-Manager/blob/master/Mockups/MainWindow.jpg">Вид главного окна.</a><br> 
б) <a href="https://github.com/DanaKlimova/Money-Manager/blob/master/Mockups/Settings.jpg">Окно настроек.</a><br> 
в) <a href="https://github.com/DanaKlimova/Money-Manager/blob/master/Mockups/CashVoucherList.jpg">Список чеков.</a><br> 
г) <a href="https://github.com/DanaKlimova/Money-Manager/blob/master/Mockups/AddCashVoucher(category).jpg">Добавление чека (выбор категории).</a><br> 
д) <a href="https://github.com/DanaKlimova/Money-Manager/blob/master/Mockups/AddItemCategory.jpg">Добавление категории товаров.</a><br> 
е) <a href="https://github.com/DanaKlimova/Money-Manager/blob/master/Mockups/AddCashVoucher(amount).jpg">Добавление чека (ввод суммы).</a><br> 
### 2.3 Классы и характеристики пользователей.<a name="2.3"></a> 
Пользователями являются люди, желающие контролировать свои расходы. 
### 2.4 Предположения и зависимости.<a name="2.4"></a>
Наличие зависимостей не предусматривается. 

## 3. Системные требования.<a name="3"></a>
### 3.1 Функциональные требования.<a name="3.1"></a>

|Функция| Требование | 
|--|--| 
|Добавление чека | Появление окна добавление чека при нажатии на кнопки "плюс" и "минус". 1) Если пользователь ввел сумму, категорию и нажал кнопку "Добавить", то новый чек отобразиться в окне чеков. 2) Если пользователь ввел сумму, категорию и не нажал кнопку "Добавить", то новый чек не отобразиться в окне чеков.| 
|Добавление категории | Появление окна добавления категории, в котором необходимо ввести название категории. 1) Если пользователь ввел название, цвет и нажал кнопку "Добавить", то новая категория будет доступна для выбора. 2) Если пользователь ввел название, цвет и не нажал кнопку "Добавить", то новая категория не будет доступна для выбора.| 
|Обновление диаграммы | При вводе новых чеков, диаграмма на главной странице должна отобразить новые данные. | 
|Изменение цвета | Изменение цвета будет доступно в окне настроек. 1) Если пользователь выбрал цвет и нажал кнопку "Сохранить" система должна сохранить изменения. 2) Если пользователь выбрал цвет и не нажал кнопку "Сохранить" система не должна сохранить изменения.| 
|Изменение шрифта | Изменение шрифта будет доступно в окне настроек. 1) Если пользователь выбрал шрифт и нажал кнопку "Сохранить" система должна сохранить изменения. 2) Если пользователь выбрал шрифт и не нажал кнопку "Сохранить" система не должна сохранить изменения.| 

### 3.2 Нефункциональные требования.<a name="3.2"></a>
##### 3.2.1 Бизнес-правила.<a name="3.2.1"></a>
Бизнес-правила не выявлены. 
##### 3.2.2 Атрибуты качества.<a name="3.2.2"></a>
###### 3.2.2.1 Требования к доступности.<a name="3.2.2.1"></a>
Приложение должно быть доступно все время, за исключением времени обслуживания. 
###### 3.2.2.2 Требования по удобству использования.<a name="3.2.2.2"></a>
Приложение должно позволить пользователю в два клика (нажатие на кнопку "+"/"-", нажатие на кнопку "Добавить") добавить чек. 
###### 3.2.2.3 Требования к безопасности.<a name="3.2.2.3"></a>
Приложение является однопользовательским и нет необходимости подключения к сетям, поэтому требования к безопасности не выявлены.
### 3.3. Ограничения <a name="3.3"></a> <br>
Данные пользователя хранятся в базе данных.
