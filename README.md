# Курсовой проект

## Дано

### Технологии
- Server side Blazor (frontend)
- Orleans (backend)
- Redux

### Описание

В компоненте Календарь существуют некоторые события. На каждое событие можно назначить человека (одного и более). При этом существует ряд проверок/фильтров. 
Например: 
- не привышает ли количество назначеных людей допустимое значение
- нет ли у назначаемого пользователя конфликтующих мероприятий
- нет ли у назначаемого пользователя запросов на отпуск/отгул

Все фильтры выполняются в строго установленном порядке. 
В случае конфликтов, пользователю необходимо показать диалоговое окно, отображающее 
- количество конфликтов
- описание каждого конфликта
- возможные варианты решения конфликта
- кнопку "Отмена"

В диалоговом окне, конфликты отображаются по порядку. Пользователь может перейти к решению следующего конфликта только после решения предыдущего.

Для каждого конфликта есть свой набор кнопок. Есть кнопки с идентичной логикой, есть кнопки с уникальной логикой.

Кнопка "Отмена" завершает процесс назначения пользователя на каком шаге решения конфликтов не находился бы пользователь.

### Проблемы

- Подобная логика с фильрами и диалогами существует не только в календаре. Механизм должен быть универсальным
- Необходимо предусмотреть возможность сложносоставных проверок. Некоторые наборы фильтров должны быть объеденены в группы. После обработки каждой группы и при наличии конфликтов, пользователю предоставляется возможность решить конфликты. В результате решения конфликтов для каждой группы фильтров должны быть внесены изменения в стейт
- кнопка "Отмена" в сложносоставных проверках, откатывает все изменения стейта
- пользователю достаточно отобразить финальное состояние стейта. Нет необходимости обновлять UI в процессе решения конфликтов.



