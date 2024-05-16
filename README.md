# Информационная система по школьному предмету «Физика».
### Название приложения: PhysicApp
### Описание приложения:
**Система «PhysicApp» предназначена для обучения и изучения физических тем, включая “Тепловое движение. Температура”, “Внутренняя энергия” и “Способы изменения внутренней энергии тела”. Пользователи могут свободно перемещаться между темами, чтобы изучать интересующие их аспекты физики, а так же добавлять новые материалы.**

# Функции, реализованные в программе:
1. **Просмотр статей.** Выбрать тему можно на главном экране, или из списка, который открывается с помощью кнопки "Ещё".
2. **Добавление собственного материала.** Нажав на кнопку "Добавить свою тему", откроется соответсвующая форма для заполнения.
3. **Конвертер электрического тока.** Во вкладке "Перевод единиц силы тока" можно конвертировать значения в Амперы.
4. **Калькулятор по закону Ома.** Система позволяет быстро посчитать основные переменные закона Ома для участка цепи.

# Технологии, которые были использованы для разработки приложения:
- **C#** - объектно-ориентированный язык программирования.
- **Visual Studio Community 2022** - интегрированная среда разработки (IDE), которая обеспечивает удобное создание, отладку и развертывание приложений.
- **Windows Presentation Foundation** - система для построения клиентских приложений Windows с визуально привлекательными возможностями взаимодействия с пользователем, графическая подсистема в составе .NET Framework, использующая язык XAML.
- **SQLite** - компактная встраиваемая СУБД.
- **Microsoft.EntityFrameworkCore.Sqlite** - пакет Entity Framework Core для работы с базой данных SQLite.

# Описание базы данных:
#### Файл базы данных называется topics.db <br/>
Файл базы данных расположен локально в проекте по пути **PhysicApp\PhysicApp\bin\Debug** </br>
В базе данных находится 1 таблица _Topic_, которая состоит из колонок _Id_, _NameTopic_, _TextTopic_. В этой таблице храняться все тематические статьи по физике, доступные для чтения в приложении.

# Скриншоты приложения:

![Главная страница](https://github.com/vanyaokblog/PhysicApp/blob/main/Screenshots/MainWindow.png)
                  Главная страница
</br> </br> </br>

![Просмотр темы, выбранной из списка](https://github.com/vanyaokblog/PhysicApp/blob/main/Screenshots/TopicWin.png)
 Просмотр темы, выбранной из списка
</br> </br> </br>

![Добавление данных](https://github.com/vanyaokblog/PhysicApp/blob/main/Screenshots/AddWin.png)
 Добавление данных
</br> </br> </br>

![Калькулятор по закону Ома](https://github.com/vanyaokblog/PhysicApp/blob/main/Screenshots/OhmsWin.png)
 Калькулятор по закону Ома
</br> </br> </br>

![Перевод единиц силы тока](https://github.com/vanyaokblog/PhysicApp/blob/main/Screenshots/CurrentConverterWin.png)
 Перевод единиц силы тока
</br> </br> </br>
