# *Generalized* rock-paper-scissors game.

At the moment the program is launched, an odd number >=3 non-repeating lines is passed as command line parameters (arguments to the main or Main method) (if the arguments are incorrectly specified, an error message is displayed - what is incorrect, correct example).
These lines are moves (for example, Rock Paper Scissors or Rock Paper Scissors Lizard Spock).

Victory is defined as follows - half of the next wins, half of the previous loses (in a circle).

The script generates a random key (RandomNumberGenerator) 128 bits long, makes its move (computer move), calculates HMAC (based on SHA2 or SHA3) from the move with the generated key, shows the user HMAC. After that the user gets "menu" 1 - Stone, 2 - Scissors, ...., 0 - Exit. The user makes his choice (in case of incorrect input, the "menu" is displayed again). The script shows who won, the computer's move, and the original key.
Thus, the user can check that the computer plays fair (did not change its move after the user's move).

Example:
    
    >Program rock paper scissors lizard Spock

    HMAC: FAAC40C71B4B12BF0EF5556EEB7C06925D5AE405D447E006BB8A06565338D411

    Available moves:

    1 - rock

    2 - paper

    3 - scissors

    4-lizard

    5 - Spock

    0 - exit

    Enter your move: 2

    Your move: paper

    Computer move: rock

    you win!

    HMAC key: BD9B5544739FCE7359C267E734E380A2

Explanation: The HMAC key is the same secret key that was generated. And the message is a move (just a line of a move). After the user's turn, he will have a key, the computer's turn, so the user can calculate the HMAC and compare with the HMAC that was shown before the user's turn.

_______________________________________________________________________________________________________________________________________________________________________

# *Обобщенная* игра камень-ножницы-бумага.

В момент запуска программы в качестве параметров командной строки (аргументы метода main или Main) передаётся нечётное число >=3 неповторяющихся строк (при неправильно заданных аргументах выводится сообщение об ошибке — что неверно, пример как правильно). 
Эти строки — это ходы (например, Камень Ножницы Бумага или Камень Ножницы Бумага Ящерица Спок). 

Победа определяется так — половина следующих выигрывает, половина предыдущих проигрывает (по кругу).

Скрипт генерирует случайный ключ (RandomNumberGenerator) длиной 128 бит, делает свой ход (ход компьютера), вычисляет HMAC (на базе SHA2 или SHA3) от хода со сгенерированным ключом, показывает пользователю HMAC. После этого пользователь получает "меню" 1 - Камень, 2 - Ножницы, ...., 0 - Exit. Пользователь делает свой выбор (при некорректном вводе опять отображается "меню"). Скрипт показывает, кто победил, ход компьютера и исходный ключ.
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

Пояснение: HMAC ключ — это тот самый секретный ключ, который был сгенерирован. А сообщение — это ход (прямо строка хода). После хода пользователя у него будет ключ, ход компьютера, поэтому пользователь сможет вычислить HMAC и сравнить с HMAC-ом, который был показан до хода пользователя. 
