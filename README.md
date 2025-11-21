# Hopmate 🚗

Uma aplicação de partilha de caronas desenvolvida com **ASP.NET Core** no backend e **React + TypeScript** no frontend, permitindo que condutores e passageiros se conectem para viagens partilhadas.

## 📋 Sobre o Projeto

Hopmate é uma plataforma inovadora que facilita a partilha de caronas entre utilizadores. O sistema permite que:

- **Condutores** criem e gerenciem viagens
- **Passageiros** procurem e se inscrevam em viagens disponíveis
- **Ambos** ganhem pontos e distintivos (hops) por participações bem-sucedidas
- **Sistema de reputação** através de avaliações e penalidades

## 🛠️ Tecnologias Utilizadas

### Backend
- **.NET 8.0** - Framework principal
- **ASP.NET Core Web API** - Desenvolvimento de APIs REST
- **Entity Framework Core** - ORM para gestão de dados
- **SQL Server** - Base de dados

### Frontend
- **React 19** - Biblioteca UI
- **TypeScript** - Tipagem estática
- **Vite** - Ferramenta de build e dev server

## 📁 Estrutura do Projeto

```
hopmate-beta-master/
├── hopmate.Server/          # Backend ASP.NET Core
│   ├── Controllers/         # Endpoints da API
│   ├── Models/
│   │   ├── Entities/       # Modelos de dados
│   │   └── Dto/            # Objetos de Transferência de Dados
│   ├── Services/           # Lógica de negócio
│   ├── Data/               # DbContext e Migrações
│   └── Program.cs          # Configuração da aplicação
│
├── hopmate.client/          # Frontend React
│   ├── src/
│   │   ├── pages/          # Páginas da aplicação
│   │   ├── components/     # Componentes reutilizáveis
│   │   ├── App.tsx         # Componente raiz
│   │   └── axiosConfig.ts  # Configuração do cliente HTTP
│   ├── vite.config.ts      # Configuração do Vite
│   └── tailwind.config.js  # Configuração do Tailwind
│
└── hopmate.Tests/           # Testes unitários
```

## 🚀 Como Começar

### Pré-requisitos

- **.NET 8.0 SDK** ou superior
- **Node.js 18+** e **npm**
- **SQL Server** (local ou remoto)
- **Git**

## 📚 Funcionalidades Principais

### Autenticação
- Registo de novos utilizadores
- Acesso com JWT
- Validação de palavras-passe seguras
- Rotas protegidas

### Gestão de Viagens
- Criar e editar viagens
- Cancelar viagens e aplicar penalidades
- Procurar viagens semelhantes
- Visualizar detalhes de viagens
- Gerenciar lugares disponíveis

### Sistema de Reputação
- Ganho de pontos por viagens concluídas
- Sistema de "hops" (distintivos)
- Penalidades por cancelamento
- Avaliações de condutores e passageiros

### Gestão de Veículos
- Registar novos veículos
- Selecionar cores de veículos
- Gerenciar imagens de veículos
- Validação de informações do veículo

### Sistema de Vouchers
- Ganhar vouchers através de participações
- Resgatar vouchers com patrocinadores
- Histórico de vouchers utilizados

## 🔑 Endpoints Principais

### Autenticação
- `POST /api/auth/register` - Registo de utilizador
- `POST /api/auth/login` - Acesso

### Viagens
- `GET /api/trip` - Listar todas as viagens
- `POST /api/trip` - Criar nova viagem
- `GET /api/trip/{id}` - Obter detalhes da viagem
- `PUT /api/trip/{id}` - Actualizar viagem
- `DELETE /api/trip/{id}` - Eliminar viagem
- `POST /api/trip/cancel/{id}` - Cancelar viagem

### Veículos
- `GET /api/vehicle` - Listar veículos
- `POST /api/vehicle` - Criar veículo
- `PUT /api/vehicle/{id}` - Actualizar veículo
- `DELETE /api/vehicle/{id}` - Eliminar veículo

### Cores
- `GET /api/colors` - Listar cores disponíveis
- `POST /api/colors` - Criar cor

## 🗄️ Modelos de Dados Principais

### Utilizador (ApplicationUser)
- ID, Nome, Email, Nome de utilizador
- Data de nascimento
- Pontos e Hops (sistema de reputação)
- Caminho da imagem
- Referência a Condutor ou Passageiro

### Viagem (Trip)
- ID, Data/Hora de partida e chegada
- Lugares disponíveis
- Condutor, Veículo, Estado
- Localizações (origem e destino)

### Condutor (Driver)
- ID do utilizador
- Licença de condução
- Lista de viagens
- Lista de avaliações

### Passageiro (Passenger)
- ID do utilizador
- Lista de viagens participadas
- Lista de avaliações

### Veículo (Vehicle)
- ID, Marca, Modelo, Matrícula
- Número de lugares
- Cor, Imagem
- Condutor proprietário

## 🧪 Testes

Execute os testes unitários:
```bash
cd hopmate.Tests
dotnet test
```

## 🎯 Roadmap Futuro

- [ ] Integração com mapas (Google Maps/Leaflet)
- [ ] Chat em tempo real entre passageiros e condutor
- [ ] Pagamento integrado
- [ ] Notificações push
- [ ] Aplicação móvel (React Native)
- [ ] Análise de histórico de viagens
- [ ] Sistema de recomendações

---
