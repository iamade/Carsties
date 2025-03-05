# Carsties - Car Auction Platform

Carsties is a modern car auction platform built using a microservices architecture. The application is fully containerized and orchestrated with Docker, utilizing YARP as the API gateway for efficient request routing.

## Table of Contents
- [Features](#features)
- [Architecture](#architecture)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Microservices Overview](#microservices-overview)
- [API Gateway](#api-gateway)
- [Deployment](#deployment)
- [Contributing](#contributing)
- [License](#license)

## Features
- Real-time car auctions: Users can bid on vehicles in real time.
- Microservices-based: Each functionality is developed as an independent service.
- Scalability: Easily scalable using containerized services.
- Secure transactions: Ensuring safe and reliable payments.
- API Gateway: YARP-based gateway for routing and load balancing.
- Dockerized: Fully containerized for seamless deployment.

## Architecture
Carsties follows a microservices architecture, where different services handle specific functionalities such as user management, auction handling, bidding, payments, and notifications. YARP serves as the API gateway, routing requests to the appropriate services.

## Technologies Used
- **Backend**: .NET Core
- **Frontend**: React.js (NextJS)
- **Database**: PostgreSQL, MongoDB
- **API Gateway**: YARP
- **Containerization**: Docker, Kubernetes (optional for orchestration)
- **Messaging**: RabbitMQ
- **Authentication**: JWT, OAuth 2.0

## Getting Started

### Prerequisites
- Docker & Docker Compose
- .NET SDK
- node & npm/yarn
- PostgreSQL/MongoDB installed (or use Docker containers)

### Installation
1. Clone the repository:
```bash
git clone https://github.com/iamade/carsties.git
cd carsties
```

### Starting the application
2. Start the services using Docker Compose:
```bash
docker-compose up --build
```

### Access the application:
``` 
- **API Gateway**: http://localhost:6001
- Frontend: http://localhost:3000
```