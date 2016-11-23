## Indice
* [Tipos](#tipos)
* [Entrada e Saida](#entrada-e-saida)


## Tipos

C# é uma linguagem fortemente tipada. Isso significa que qualquer variavel declarada terá um tipo e não será possivel alterá-lo. Os tipos primitivos de C tem todos equivalentes em C#. Em C# as precisões são bem-definidas, diferente de C, em que estas dependem do compilador. Seguem os tipos já conhecidos:

Tipo | Espaco em Memória | Como declarar em código
-----|-------------------|------------------------
_char_ | 16 bits (Unicode) | _char_ v = 'a';
_int_  | 32 bits           | _int_ v = 1;
_long_ | 64 bits           | _long_ v = 1L;
_float_| 32 bits           | _float_ v = 1.0f
_double_| 64 bits          | _double_ v = 1.0

Note que o char do C# tem 16 bits e usa o padrão Unicode. Nesse padrão, os 256 primeiros caracteres continuam sendo os mesmos do ASCII

Note tambem que a representaçao de numeros reais padrão do C# é o double, sendo necessário colocar o 'f' no final quando se deseja usar variaveis do tipo float. (Lembre-se disso quando estiver usando o Unity, cujo padrão é float).

Todas as operações conhecidas para esses tipos continuam as mesmas.

Além desses, temos novos tipos (que são emprestados do C++):

_bool_: é um tipo booleano, que pode assumir os valores lógicos de _true_ e _false_, em vez de usar 0 e 1.

_string_: que representa uma cadeia infinita de caracteres, com memória alocada dinamicamente). Esse tipo facilita muito por que deixa de lado o uso de um array de _char_'s para strings. Trabalhar com _string_ de C# é muito intuitivo: para concatenar, basta somá-las, com +.  No código _string_ são variaveis declaradas entre "".

## Entrada e Saida
