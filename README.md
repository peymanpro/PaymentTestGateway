# PaymentTestGateway

A lightweight, open-source payment gateway simulator built with **ASP.NET Core 8**, **Blazor Server**, and **Clean Architecture**.

The project helps developers build and test payment flows locally without waiting for real bank APIs or external payment providers.

---

## ✨ Features

### Payment API

- Create payment
- Retrieve payment by ID
- Update payment status
  - Successful
  - Failed
  - Cancelled

### Payment UI

- Payment page
- Payment result page
- Responsive UI
- CSS Isolation

### Development

- Swagger UI
- In-memory storage
- No database required

---

## 🏗 Architecture

```
Presentation (Blazor + REST API)
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

## 📂 Project Structure

```
PaymentTestGateway
│
├── src
│   ├── PaymentTestGateway.Web
│   ├── PaymentTestGateway.Application
│   ├── PaymentTestGateway.Domain
│   └── PaymentTestGateway.Infrastructure
│
├── docs
├── samples
└── assets
```

---

## 🚀 Getting Started

Clone the repository

```bash
git clone https://github.com/peymanpro/PaymentTestGateway.git
```

Go to the project

```bash
cd PaymentTestGateway
```

Run the application

```bash
dotnet run --project src/PaymentTestGateway.Web
```

Open your browser

```
http://localhost:5031
```

Swagger

```
http://localhost:5031/swagger
```

---

## 📖 API

### Create Payment

```
POST /api/payment/create
```

Example Request

```json
{
  "amount": 400,
  "description": "Test Payment",
  "callbackUrl": "https://localhost/callback"
}
```

Example Response

```json
{
  "paymentId": "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
  "paymentUrl": "/pay/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"
}
```

---

### Update Payment Status

Successful

```
POST /api/payment/{paymentId}/success
```

Failed

```
POST /api/payment/{paymentId}/failed
```

Cancelled

```
POST /api/payment/{paymentId}/cancel
```

---

## 🖥 User Interface

### Payment Page

```
/pay/{paymentId}
```

Displays

- Payment ID
- Amount
- Description
- Payment actions

---

### Payment Result Page

```
/payment-result/{paymentId}
```

Displays

- Pending
- Successful
- Failed
- Cancelled

---

## 📌 Current Status

### Completed

- Clean Architecture
- Blazor Server UI
- Payment domain model
- Payment service
- Create payment API
- Payment status API
- Payment page
- Payment result page
- Swagger integration
- CSS Isolation

---

## 🛣 Roadmap

- [x] Solution structure
- [x] Domain layer
- [x] Application layer
- [x] Infrastructure layer
- [x] Blazor Server UI
- [x] Create payment
- [x] Payment page
- [x] Payment result page
- [x] Payment status API

Next milestones

- [ ] Connect payment page actions
- [ ] Callback endpoint
- [ ] Payment verification
- [ ] Payment expiration
- [ ] Transaction reference number
- [ ] Docker support
- [ ] Unit tests
- [ ] GitHub Actions

---

## 📄 License

MIT License

---

## 🤝 Contributing

Contributions, issues and feature requests are welcome.

Feel free to open an issue or submit a pull request.

---

## ⭐ Support

If this project helps you, consider giving it a ⭐ on GitHub.