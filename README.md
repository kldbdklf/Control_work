# Control_work
Данный репозиторий является решением моей контрольной работы. 
Была поставлена следующая задача: "Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами".

Помимо блок-схемы, описывающей основной алгоритм, используемый для решения поставленной задачи, репозиторий содержит код необходимой программы на языке C#.

Суть алгоритма используемого в решении сводится к созданию метода, который принимает на вход массив строк. 
После этого создается отдельный резолютирующий массив аналогичного типа, который в итоге будет возвращен методом.
Основная работа просиходит в цикле for, проверяющем каждый элемент переданного массива и при выявлении строк, состоящих из менее чем 4 символов, записывающем текущий элемент переданного массива в резолютирующий массив.
При этом происходит увеличение резолютирующего массива на 1.
