# PaymentTestGateway

> An open-source payment gateway simulator for development, testing, and integration.

## Overview

PaymentTestGateway is a lightweight payment gateway simulator designed for developers who need to test payment workflows without relying on real banking APIs.

The project provides a secure sandbox environment for simulating payment scenarios during software development.

No real financial transactions are processed.

---

## Why?

Integrating with real payment gateways during development can be difficult because of:

- Delayed API access
- Complex registration processes
- Environment limitations
- Limited testing scenarios

PaymentTestGateway solves these problems by providing a local development payment gateway.

---

## Features

### Version 1 (MVP)

- Payment Creation API
- Payment Simulation Page
- Payment Verification API
- Callback Simulation
- In-Memory Storage
- Blazor Web UI
- Minimal API
- OpenAPI (Swagger)

---

## Planned Features

- PostgreSQL Support
- Docker
- Authentication
- Webhook Management
- Refund API
- Retry Mechanism
- Delay Simulation
- Transaction Dashboard
- SDK Examples
- Sample Applications

---

## Security

PaymentTestGateway is **NOT** a banking application.

This project:

- does not process real payments
- does not store bank card information
- does not accept real financial credentials
- is intended only for development and testing

---

## Project Structure

```text
PaymentTestGateway
│
├── src
├── docs
├── samples
├── assets
│
└── README.md
```

---

## Roadmap

### Phase 1

- [ ] Solution Structure
- [ ] Blazor Web Project
- [ ] Domain Layer
- [ ] Application Layer
- [ ] Infrastructure Layer

### Phase 2

- [ ] Create Payment API
- [ ] Payment Page
- [ ] Callback
- [ ] Verify Payment

### Phase 3

- [ ] Swagger
- [ ] Logging
- [ ] Documentation

### Phase 4

- [ ] PostgreSQL
- [ ] Docker
- [ ] Dashboard

---

## License

MIT