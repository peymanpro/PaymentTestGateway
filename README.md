# PaymentTestGateway

A lightweight **Payment Gateway Sandbox** built with **ASP.NET Core 8**, **Blazor Server**, and **Clean Architecture**.

The goal of this project is to provide a realistic payment gateway simulator that developers can integrate with during development and testing without requiring access to a real bank or payment service provider.

---

# Features

## Payment API

- Create Payment
- Update Payment Status
  - Successful
  - Failed
  - Cancelled
- Verify Payment

---

## Payment UI

- Payment Page
- Payment Result Page
- Callback Redirect
- Responsive Layout
- CSS Isolation

---

## Payment Lifecycle

```
Application
      │
      ▼
Create Payment
      │
      ▼
Redirect User
      │
      ▼
Payment Gateway
      │
      ▼
User Action
      │
      ├──────── Success
      ├──────── Failed
      └──────── Cancelled
      │
      ▼
Redirect To Callback
      │
      ▼
Verify Payment
```

---

# Current Capabilities

- Clean Architecture
- REST API
- Blazor Server UI
- Swagger
- In-Memory Storage
- Callback Support
- Payment Verification
- Reference Number Generation
- Payment Timestamp
- Payment Status Management

---

# Project Structure

```
PaymentTestGateway
│
├── src
│   ├── PaymentTestGateway.Web
│   │
│   ├── PaymentTestGateway.Application
│   │
│   ├── PaymentTestGateway.Domain
│   │
│   └── PaymentTestGateway.Infrastructure
│
├── docs
│
├── samples
│
└── assets
```

---

# Architecture

```
Presentation
     │
     ▼
Application
     │
     ▼
Domain
     │
     ▼
Infrastructure
```

---

# API

## Create Payment

```
POST /api/payment/create
```

Request

```json
{
  "amount": 400,
  "description": "Test Payment",
  "callbackUrl": "https://your-app.com/payment/callback"
}
```

Response

```json
{
  "paymentId": "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
  "paymentUrl": "/pay/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"
}
```

---

## Update Payment Status

### Success

```
POST /api/payment/{paymentId}/success
```

### Failed

```
POST /api/payment/{paymentId}/failed
```

### Cancelled

```
POST /api/payment/{paymentId}/cancel
```

---

## Verify Payment

```
POST /api/payment/verify
```

Request

```json
{
  "paymentId": "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"
}
```

Successful Response

```json
{
  "paymentId": "...",
  "status": 1,
  "amount": 400,
  "referenceNumber": "204988438307",
  "paidAt": "2026-07-13T12:20:00Z",
  "isSuccessful": true
}
```

---

# User Interface

## Payment Page

```
/pay/{paymentId}
```

Displays

- Payment Id
- Amount
- Description

Actions

- Successful Payment
- Failed Payment
- Cancel Payment

---

## Payment Result

```
/payment-result/{paymentId}
```

Displays

- Current Status
- Payment Id
- Amount
- Description
- Return To Application

---

# Getting Started

Clone repository

```bash
git clone https://github.com/peymanpro/PaymentTestGateway.git
```

Go to project

```bash
cd PaymentTestGateway
```

Run application

```bash
dotnet run --project src/PaymentTestGateway.Web
```

Swagger

```
http://localhost:5031/swagger
```

---

# Current Version

**v1.0.0**

This version provides a complete MVP payment gateway simulation suitable for local development and integration testing.

---

# Roadmap

## v1.1

Business Rules

- [ ] Prevent duplicate payment
- [ ] Payment expiration
- [ ] Better error codes
- [ ] Idempotent payment operations

---

## v1.2

Persistence

- [ ] Entity Framework Core
- [ ] PostgreSQL
- [ ] Payment Repository
- [ ] Migration Support

---

## v1.3

Quality

- [ ] Unit Tests
- [ ] Integration Tests
- [ ] GitHub Actions
- [ ] Code Coverage

---

## v1.4

Operations

- [ ] Docker
- [ ] Docker Compose
- [ ] Health Checks
- [ ] Structured Logging

---

## v2.0

Advanced Gateway Features

- [ ] Webhook Notifications
- [ ] Merchant Management
- [ ] JWT Authentication
- [ ] Rate Limiting
- [ ] OpenTelemetry
- [ ] Metrics
- [ ] Admin Dashboard

---

# Planned Ecosystem

This project is planned to be used by other repositories in this portfolio.

```
Enterprise Portfolio

PaymentTestGateway
        ▲
        │
        │
Enterprise Microservices Shop
        │
        ├── Identity Service
        ├── Order Service
        ├── Inventory Service
        ├── Payment Service
        └── Notification Service

RabbitMQ Saga Demo

GraphQL API

ML.NET Recommendation Engine
```

---

# Design Goals

- Clean Architecture
- SOLID Principles
- Enterprise-ready Design
- Reusable Components
- Simple Integration
- Developer Friendly

---

# License

MIT License

---

# Contributing

Issues, discussions, feature requests and pull requests are welcome.

---

# Support

If this project helps you, consider giving it a ⭐ on GitHub.