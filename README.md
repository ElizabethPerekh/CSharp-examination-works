# CSharp-examination-works
Экзаменационные работы 2024 C#
------------------------------
В данном репозитории представлены экзаменационные работы, выполненные на языке C#, за период обучения 2024
------------------------------
Приложение «Словари».  

Основная задача проекта: хранить словари на разных языках и разрешать пользователю находить перевод нужного слова или фразы.  
Интерфейс приложения должен предоставлять такие возможности:  

▼ Создавать словарь.  
▼ Добавлять слово и его перевод в уже существующий словарь. Так как у слова может быть несколько переводов, необходимо поддерживать возможность создания нескольких вариантов перевода.  
▼ Заменять слово или его перевод в словаре.  
▼ Удалять слово или перевод. Если удаляется слово, все его переводы удаляются вместе с ним. Нельзя удалить перевод слова, если это последний вариант перевода.  
▼ Искать перевод слова.  
▼ Словари должны храниться в файлах.  
▼ Слово и варианты его переводов можно экспортировать в отдельный файл результата.  
▼ При старте программы необходимо показывать меню для работы с программой. Если выбор пункта меню открывает подменю, то тогда в нем требуется предусмотреть возможность возврата в предыдущее меню.  

------------------------------
Приложение «Викторина».  

Основная задача проекта: предоставить пользователю возможность проверить свои знания в разных областях.  
Интерфейс приложения должен предоставлять такие возможности:  

▼ При старте приложения пользователь вводит логин и пароль для входа. Если пользователь не зарегистрирован, он должен пройти процесс регистрации.  
▼ При регистрации нужно указать:  
	• логин (нельзя зарегистрировать уже существующий логин);  
	• пароль;  
	• дату рождения.  
▼ После входа в систему пользователь может:  
  • стартовать новую викторину;  
  • посмотреть результаты своих прошлых викторин;  
  • посмотреть Топ-20 по конкретной викторине;  
  • изменить настройки: можно менять пароль и дату рождения;  
  • выход.  
▼ Для старта новой викторины пользователь должен выбрать раздел знаний викторины. Например: «История», «География», «Биология» и т.д. Также нужно предусмотреть смешанную викторину, когда вопросы будут выбираться из разных викторин по случайному принципу.  
▼ Конкретная викторина состоит из двадцати вопросов. У каждого вопроса может быть один или несколько правильных вариантов ответа. Если вопрос предполагает несколько правильных ответов, а пользователь указал не все, вопрос не засчитывается.  
▼ По завершении викторины пользователь получает количество правильно отвеченных вопросов, а также свое место в таблице результатов игроков викторины.  

Необходимо также разработать утилиту для создания и редактирования викторин и их вопросов. Это приложение должно предусматривать вход по логину и паролю.
