# CSharp_university
Programs for university`s course of C#

                                Variant 5

----------------------------  Task 1 (lab 1)

При виконанні комп’ютерого практикуму слід реалізувати наступні задачі:

  a)	дозволяти користувачу визначати кількість вершин графа самостійно з консолі;
  b)	дозволяти користувачу вводити довільні матриці (списки суміжності) різної розмірності самостійно з консолі;
  c)	мати можливість генерації довільної матриці (списку суміжності) з консолі;
  d)	виводи на екран результат

На плоскости расположено N точек. Имеется робот, который двигается следующим образом. 
Стартуя с некоторой начальной точки и имея некоторое начальное направление, 
робот движется до первой встреченной на его пути точки, изменяя в ней свое текущее 
направление на 90 градусов, т.е. поворачивая налево или направо. 
После этого он продолжает движение аналогично. 
Если робот достиг начальной точки, либо не может достичь новой точки (которую он еще не посещал), 
то он останавливается. Определить, может ли робот посетить все N точек, если:

-	Определены начальные точка и направление робота. 
-	Определена начальная точка, а направление робота можно выбирать. 
-	Начальную точку и направление робота можно выбирать.

Координаты точек - целые числа, угол измеряется в радианах относительно оси ОХ

----------------------------  Task 2 (lab 2)

При виконанні комп’ютерого практикуму слід реалізувати наступні задачі:

  a)Перезавантажити віртуальний метод bool Equals (object obj), таким чином, щоб об‘єкти 
    були рівними, якщо рівні всі дані об‘єктів. Для кожного з класів самостійно визначити, 
    які атрибути використовуються для порівняння;
    
  b)Визначити операції == та != . При цьому врахувати, що визначення операцій повинно бути 
    погоджено з перезавантаженим методом Equals, тобто критерії, за якими перевіряється рівність
    об'єктів в методі Equals, повинні використовуватися і при перевірці рівності об'єктів в операціях == та !=;
    
  c)Перевизначити віртуальний метод int GetHashCode(). Класи базової бібліотеки, що викликають
    метод GetHashCode() з призначеного користувальницького типу, припускають, що рівним об'єктів
    відповідають рівні значення хеш-кодів. Тому в разі, коли під рівністю об'єктів розуміється 
    збіг даних (а не посилань), реалізація методу GetHashCode() повинна для об'єктів з 
    однаковими даними повертати рівні значення хеш-кодів.
    
  d)Визначити метод object DeepCopy() для створення повної копії об'єкта. Визначені в деяких 
    класах базової бібліотеки методи Clone() та Copy() створюють обмежену (shallow) копію об'єкта - 
    при копіюванні об'єкта копії створюються тільки для полів структурних типів, для полів, на які 
    посилаються типи, копіюються тільки посилання. В результаті в обмеженій копії об'єкта поля-посилання 
    вказують на ті ж об'єкти, що і в вихідному об'єкті. Метод DeepCopy() повинен створити повні копії всіх об'єктів, 
    посилання на які містять поля типу. Після створення повна копія не залежить від вихідного об'єкта - зміна 
    будь-якого поля або властивості вихідного об'єкта не повинно призводити до зміни копії. При реалізації методу 
    DeepCopy() в класі, який має поле типу System.Collections.ArrayList, слід мати на увазі, що визначені в класі 
    ArrayList конструктор ArrayList (ICollection) і метод Clone() при створенні копії колекції, що складається з 
    елементів, на які посилаються типів, копіюють тільки посилання. Метод DeepCop() повинен створити як копії 
    елементів колекції ArrayList, так і повні копії об'єктів, на які посилаються елементи колекції. Для типів, що 
    містять колекції, реалізація методу DeepCopy() спрощується, якщо в типах елементів колекцій 
    також визначити метод DeepCopy().
    
  e)Перезавантажити віртуальний метод string ToString() для формування строки з інформацією про всі елементи списку
  
  f)	Підготувати демонстраційний приклад, в котрому будуть використані всі розроблені методи
  
  g)	Визначити клас, котрий містить типізовану колекцію та котрий за допомогою подій інформує про зміни в колекції.
    Колекція складається з об'єктів силочних типів. Колекція змінюється при видаленні/додаванні елементів або 
    при зміні одного з вхідних в колекцію посилань, наприклад, коли одному з посилань присвоюється нове значення. 
    В цьому випадку у відповідних методах або властивості класу кидаються події.
    При зміні даних об'єктів, посилання на які входять в колекцію, значення самих посилань не змінюються.
    Цей тип змін не породжує подій.
    Для подій, що сповіщають про зміни в колекції, визначається свій делегат. 
    Події реєструються в спеціальних класах-слухачах.
    
  h)	Реалізувати обробку помилок, при цьому необхідно перевизначити за допомогою наслідування наступні події: 
    - StackOverflowException
    - ArrayTypeMismatchException
    - DivideByZeroException
    - IndexOutOfRangeException
    - InvalidCastException
    - OutOfMemoryException 
    - OverflowException 
    
  i)	Підготувати демонстраційний приклад, в котрому будуть використані всі розроблені методи
  
  j)	Підготувати звіт з результатами виконаної роботи.

Создать абстрактный класс Number c виртуальными методами, реализующими арифметические операции. 
На его основе реализовать классы Integer и Real.
Создать класс Series (набор), содержащий массив/параметризованную коллекцию 
объектов этих классов в динамической памяти. 
Предусмотреть возможность вывода  характеристик объектов списка. 

