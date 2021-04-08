Prática 6 – Árvore Binária de Busca
OBJETIVO
Desenvolver um programa que importe uma base de dados contendo informações sobre as matrículas dos
alunos de uma escola, armazenando-as em uma árvore binária de busca para futuras consultas.
O usuário deverá selecionar o arquivo texto desejado, contendo as linhas no formato:
matrícula;nome_aluno;disciplina_1[;disciplina_2;...]
A quantidade de disciplinas vinculadas ao aluno pode variar, com limite mínimo de uma e limite máximo
indeterminado, como ilustra o exemplo a seguir:
79015000;JOAO MARCELO DA SILVA;AED;LOGICA;CALCULO
79015010;PATRICIA PEREIRA DE SOUZA;ADMINISTRACAO;AED;CALCULO
79015023;FERNANDA BUENO;CALCULO;LOGICA
O programa deverá ler linha a linha do arquivo, separar as informações e então armazená-las em uma
árvore binária de busca, cuja chave será o nome da disciplina. O nó da árvore deverá conter os seguintes
campos
chave: String
alunos: Lista

Uma vez que a quantidade de alunos por disciplina é ilimitada, cada nó conterá uma lista encadeada para
o armazenamento.

ADMINISTRACAO
< LISTA DE ALUNOS >

LOGICA
< LISTA DE ALUNOS

AED
<LISTA DE ALUNOS>

CALCULO
< LISTA DE ALUNOS >

O programa deverá exibir um menu com as seguintes opções:
1- Informar arquivo
2- Imprimir disciplinas em ordem crescente
3- Imprimir disciplinas em "pré-ordem"
4- Imprimir disciplinas em "pós-ordem"
5- Listar Turma
6- Sair
A opção 5 deverá permitir que o usuário informe o nome de uma disciplina, desconsiderando diferenças de
caixa alta e baixa. Se encontrada, imprimir a listagem dos alunos nela matriculados.
Exemplo:
Informe o nome da disciplina: LOGICA
ALUNOS MATRICULADOS:
79015000-JOAO MARCELO DA SILVA
79015023-FERNANDA BUENO