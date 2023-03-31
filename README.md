ВАРІАНТ №9 Завдання. 
Спроектуйте класи, вказані нижче.
У кожному з них визначте метод перетворення на рядок, оператори порівняння, хоча б один арифметичний оператор. 
Оголошення цих класів розташуйте у окремому файлі, використайте їх у програмах цього завдання.
Інформацію про екземпляри класів прочитайте з файлу.
1.Оголосіть клас, що моделює сутність «числова прогресія» (прогресію задає перший член і різниця або знаменник).
Екземпляр класу вміє повідомляти свої дані, значення п-го члена, суму пчленів, своє зображення у вигляді рядка.
Прогресії порівнюють за величиною суми всіх пчленів.
Оголосіть підклас, що моделює сутність «арифметична прогресія» (an=a1+d(n-1), Sn=0.5dn^2+(a1-0.5d)n), та підклас, що моделює сутність «геометрична прогресія» (bn=b1q^(n-1),Sn=(1-q^n)/(1-q)). 
2.Створіть п’ять різних прогресій та занесіть їх у контейнер. Забезпечте можливість вводити в режимі діалогу інформацію про нову прогресію і долучати його до колекції інших.Надрукуйте всі елементи контейнера. 
Знайдіть об’єкт з найбільшою сумою. 
Чи це геометрична прогресія?Продемонструйтевикористання арифметичних операторів. 
Перетворіть колекцію прогресій, збільшивши кількість членів у них на певне число; створіть нову колекцію, що містить знаменники геометричних прогресій.

ОНОВЛЕННЯ !
Додано новий елемент поза умовою завдання  GlobalProgression - прогресія типу 1,2,3,4...100 (наслідується від ArithmeticProgression) .
для завдання №4 реалізовано дві події :

1. подію ProgressionEvent : якщо об'єкту "геометрична прогресія" змінили значення інкременту , вона повідомляє це своєму підписнику об'єкту GlobalProgression() і залежно від значення інкременту відбувається наступне :
1.якщо значення інкременту після змін < 5 тоді GlobalProgression "позичає" геом.прогресії 10 елементів, щоб вона стала довшою.
2.якщо значення інкременту після змін > 5 тоді GlobalProgression "забирає" у геом.прогресії 5 елементів, щоб вона стала коротшою. ПОМІТКА! (якщо кількість елементів < 5, то забравши їх прогресія стане пустою, тут реалізувала такий випадок, що все лишається на свої місцях і GlobalProgression ні дає, ні забирає елементи.

2.подію SumEvent : якщо в об'єкта "арифметична прогресія" сумма членів досягла значення більшого за 200 (реалізовано при виклику метода getSumOfAll()), то вона повідомляє про це своєму підписнику об'єкту GlobalProgression() , який зменшує її інкремент вдвічі.
