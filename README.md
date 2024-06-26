# BloodDonation

BloodDonation é um sistema desenvolvido para gerenciamento de estoques de sangue e cadastro de doadores, visando facilitar e incentivar doações de sangue vitais para a comunidade.

## Tecnologias Utilizadas

- **Arquitetura Limpa (Clean Architecture)**: Design robusto e escalável para o backend.
- **.NET 8**: Base sólida para desenvolvimento backend.
- **MediatR**: Implementação de padrões de mediador para facilitar a comunicação entre componentes.
- **EF Core (Entity Framework Core)**: Mapeamento objeto-relacional para persistência de dados.
- **Padrão Repository**: Acesso eficiente aos dados.
- **Mensageria com RabbitMQ**: Comunicação assíncrona entre componentes.
- **HangFire**: Agendamento de tarefas para notificações e alertas.
- **Docker**: Facilitação da implantação e distribuição do sistema em containers.
- **.NET Aspire**: Abordagem moderna e eficiente no desenvolvimento .NET.
- **Blazor**: Framework para construção do frontend, integrado ao ecossistema .NET.

## Funcionalidades Principais

- Gestão de estoques de sangue.
- Cadastro e gerenciamento de doadores.
- Notificações automáticas via HangFire para doadores e equipe de gestão.
- Comunicação assíncrona entre componentes utilizando RabbitMQ.
- Interface de usuário responsiva e intuitiva desenvolvida com Blazor.

## Pré-requisitos

- .NET 8 SDK
- Docker (opcional, para implantação em containers)

