# Итоговая работа по первому блоку (Разработчик)

1. В 1-й версии, задача решена внутри одного цикла, где одновременно проверяется каждый элемент исходного массива и, в случае выполнения условия (длинна <=3-х символов), сразу записывается в итоговый массив. Недостаток данной версии (предполагаю) заключается в необходимости резервирования памяти под конечный массив, аналогично исходному, хотя он содержит меньше полезной информации и может содержать "пустые элементы".
2. Во 2-й версии, задача решена двумя последовательными циклами (внутри которых происходит одинаковая проверка выполнения условия (длинна <=3-х символов)) В первом - счетчик "n" определяет длину (кол-во элементов) конечного массива. Далее конечный массив объявляется на нужное кол-во элементов. Во втором цикле - в конечный массив записываются нужные элементы исходного массива (через проверку, аналогичную первому циклу). Таким образом(предполагаю), эффективнее используется память, но может снижаться быстродействие программы.

# Какой из вариантов предпочтительнее (думаю) зависит от требуемого объема данных в исходном массиве и, соответственно, приоритета в использовании ресурсов пользователем.
