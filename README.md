# *Обобщенная* игра камень-ножницы-бумага.

При запуске параметрами командной строки (аргументы метода main или Main) передаётся нечётное число >=3 неповторяющихся строк (при неправильно заданных аргументах выводится сообщение об ошибке — что неверно, пример как правильно). Эти строки — это ходы (например, Камень Ножницы Бумага или Камень Ножницы Бумага Ящерица Спок). 

Победа определяется так — половина следующих выигрывает, половина предыдущих проигрывает (по кругу).

Скрипт генерирует случайный ключ (RandomNumberGenerator) длиной 128 бит, делает свой ход, вычисляет HMAC (на базе SHA2 или SHA3) от хода со сгенерированным ключом, показывает пользователя HMAC. После этого пользователь получает "меню" 1 - Камень, 2 - Ножницы, ...., 0 - Exit. Пользователь делает свой выбор (при некорректном вводе опять отображается "меню"). Скрипт показывает кто победил, ход компьютера и исходный ключ.
Таким образом, пользователь может проверить, что компьютер играет честно (не поменял свой ход после хода пользователя).

Пример:
    
    >Program rock paper scissors lizard Spock

    HMAC: FAAC40C71B4B12BF0EF5556EEB7C06925D5AE405D447E006BB8A06565338D411

    Available moves:

    1 - rock

    2 - paper

    3 - scissors

    4 - lizard

    5 - Spock

    0 - exit

    Enter your move: 2

    Your move: paper

    Computer move: rock

    You win!

    HMAC key: BD9B5544739FCE7359C267E734E380A2

Пояснение: при вычислении HMAC ключ — это тот самый секретный ключ, который вы сгенерировали. А сообщение — это ход (прямо вот строка хода). После хода пользователя у него будет ключ, ход компьютера, пользователь сможет вычислить HMAC и сравнить с HMAC-ом, который был показан до хода пользователя. 
