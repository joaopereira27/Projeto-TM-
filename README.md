# Projeto Tecnologias e Multimédia - Golf
Versão do Unity 6000.3.9f1

Professores: Paula Rego,
             Alexandre Silva,
             Luis Miguel Silva

Elementos do Grupo:

Ruben Lima 29314 - limaruben@ipvc.pt

João Pereira 29430 - o.pereira@ipvc.pt

Tema do Grupo : Jogo de Golf 3D

Resumo: O jogo consiste numa competição de Golf entre o Jogador (User) irá competir em diferentes pistas, com o objetivo de conseguir acabar as stages da competição com menor numero de tacadas.

### Tecnologias Utilizadas

- Unity
- C#
- Sistema de Física da Unity
- Unity Input System
- Assets gráficos personalizados

### Funcionalidades
- Menu inicial interativo
- Sistema de múltiplos níveis (arenas)
- Física realista da bola
- Câmara dinâmica que segue o jogador
- Deteção automática do buraco
- Música de fundo e efeitos sonoros
- Menu final após conclusão do jogo


## Estrutura do Projeto

### Scripts principais

- `GameManager.cs` – Gere a lógica do nível atual
- `GlobalGameManager.cs` – Controla progresso global do jogo
- `GolfBall.cs` – Física e comportamento da bola
- `Hole.cs` – Deteção de finalização do nível
- `CameraFollow.cs` – Seguimento da bola pela câmara
- `MainMenu.cs` – Lógica do menu inicial
- `FinalMenu.cs` – Menu final do jogo

Perspetiva da câmara:  terceira pessoa atrás da bola(melhor opção), vista de cima (top‑down), 
câmara fixa à arena.

### Cenas

- `MainMenu.unity`
- `GolfArena.unity`
- `GolfArena2.unity`

## Recursos Multimédia

O projeto ainda inclui:

- música ambiente
- efeitos sonoros
- materiais físicos da bola
- texturas personalizadas
- interface gráfica de menus
