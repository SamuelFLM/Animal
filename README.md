<img src="Imagens/logo.png" alt="logo_samuelflm">


## Desafio
<p>
A interface IAnimal define os métodos que todas as classes que a implementam devem ter.<br>
A classe Animal é uma classe abstrata que implementa a interface IAnimal e define atributos comuns como nome e idade.<br>
A classe Cachorro herda de Animal e adiciona um novo atributo raca. Ela também sobrescreve os métodos mover() e emitirSom().<br>
A classe CachorroVoador herda de Cachorro, adiciona um novo atributo asas e sobrescreve o método mover().<br>
Este diagrama demonstra a abstração (classe Animal), encapsulamento (atributos privados e métodos públicos), herança (Cachorro herda de Animal, CachorroVoador herda de Cachorro), polimorfismo (métodos mover() e emitirSom() são sobrescritos) e interfaces (IAnimal).<br>
</p>

## Condições e regras de negocio:

+---------------------+
|     <<interface>>   |
|       IAnimal       |
+---------------------+
|                     |
+---------------------+
| + mover(): void     |
| + emitirSom(): void |
+---------------------+
        /_\
          |
          | 
+---------------------+
|     <<abstract>>    |
|       Animal        |
+---------------------+
| - nome: string      |
| - idade: int        |
+---------------------+
| + mover(): void     |
| + emitirSom(): void |
+---------------------+
        /_\
          |
          | 
+---------------------+
|       Cachorro      |
+---------------------+
| - raca: string      |
+---------------------+
| + mover(): void     |
| + emitirSom(): void |
+---------------------+
          /_\
          |
          | 
+---------------------+
|    CachorroVoador   |
+---------------------+
| - asas: int         |
+---------------------+
| + mover(): void     |
| + emitirSom(): void |
+---------------------+



