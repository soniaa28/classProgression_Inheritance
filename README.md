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

ОНОВЛЕННЯ ! для завдання №4 - Подія : якщо об'єкту "геометрична прогресія" змінили кількість членів - він повідомляє про це екземляру GeomProgression globalProgression  :
1.якщо нова кількість >= за стару у 2 рази , то геометрична прогресія каже : "мені забагато елементів, тому забирай собі" і тоді повертає лишні елементи GlobalProgression 
2.Якщо нова кількість <= за стару у 2 рази, то геом прогесія каже : "мені замало елементів , тому позич мені GlobalProgression"
