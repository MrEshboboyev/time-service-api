# ⏳ Time Service API – Fast & Reliable Time Retrieval  

![.NET 9](https://img.shields.io/badge/.NET%209-blue?style=for-the-badge)  
![Time API](https://img.shields.io/badge/Time%20API-%F0%9F%95%93-green?style=for-the-badge)  
![Cloud Deployment](https://img.shields.io/badge/Cloud%20Deployment-%E2%9C%85-purple?style=for-the-badge)  
![OpenAPI](https://img.shields.io/badge/OpenAPI-%F0%9F%94%A5-orange?style=for-the-badge)  
![Security](https://img.shields.io/badge/Secure%20API-%F0%9F%94%92-red?style=for-the-badge)  

Welcome to the **Time Service API**! This **fast, scalable API** provides **accurate UTC timestamps** with **minimal latency**, making it perfect for applications that require **precise time synchronization**.  

---

## **🌟 Features**  

✅ **Current UTC Time Retrieval** – Get the **latest UTC timestamp** with a simple API call.  
✅ **Secure API** – Implements **HTTPS redirection** for safe communication.  
✅ **OpenAPI Documentation** – Provides **auto-generated API docs** for easy integration.  
✅ **Scalar API Integration** – Enhances API capabilities with **advanced data handling**.  
✅ **Cloud-Optimized** – Deployed on **Azure Web Apps** with **CI/CD automation**.  
✅ **Minimal & High-Performance** – Uses **.NET 9** for **lightweight, blazing-fast execution**.  

---

## **📂 Project Structure**  

📌 **src/Time.Api/Program.cs** – Configures services, middleware, and API routes.  
📌 **src/Time.Api/Time.Api.csproj** – Defines project dependencies and framework version.  
📌 **.github/workflows/build-and-deploy.yaml** – Automates **CI/CD deployment to Azure**.  

---

## **🚀 Getting Started**  

### **📌 Prerequisites**  
✅ [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)  
✅ [Azure Account](https://azure.microsoft.com/) (For cloud deployment)  

### **Step 1: Clone the Repository**  
```bash
git clone https://github.com/your-repo/time-service-api.git
cd time-service-api/Time.Api
```

### **Step 2: Install Dependencies**  
```bash
dotnet restore
```

### **Step 3: Build & Run Locally**  
```bash
dotnet build
dotnet run
```

---

## **🌍 API Endpoints**  

### **Get Current Time**  
Retrieves the **current UTC timestamp**.  

| Method | Endpoint | Description |
|--------|---------|-------------|
| **GET**  | `/time` | Returns the current **UTC time** |

### **Example Response**  
```json
{
  "CurrentTime": "2025-03-13T12:34:56Z",
  "TimeZone": "UTC"
}
```

### **Example Request (cURL)**  
```bash
curl -X GET https://time-service-api.azurewebsites.net/time
```

> **📌 The API is designed for minimal latency, ensuring accurate time retrieval for applications that depend on precise time synchronization.**  

---

## **🚀 Deployment**  

### **Running on Azure**  
The **Time Service API** is deployed using **Azure Web Apps** with **GitHub Actions CI/CD**.  

### **Automated Deployment Workflow**  
📌 **Location:** `.github/workflows/build-and-deploy.yaml`  

🔹 **Push to `main` branch** → 🚀 **Triggers GitHub Actions** → ☁️ **Deploys to Azure**  

---

## **🛠 Configuration**  

Set environment variables in **Azure App Settings**:  

| Name | Value |
|------|-------|
| **ENABLE_HTTPS_REDIRECTION** | `true` |
| **LOG_LEVEL** | `Information` |

---

## **🧪 Testing**  

### **Run Unit Tests**  
```bash
dotnet test
```

### **Manual API Testing**  
📌 **Use Postman or Swagger UI** to:  
✅ **Fetch the current time** → `/time`  

---

## **🎯 Why Use This Project?**  

✅ **Minimal & High-Performance API** – Provides **fast UTC time retrieval**.  
✅ **Secure & Cloud-Optimized** – Supports **HTTPS & Azure deployment**.  
✅ **Scalable & Automated** – Uses **GitHub Actions for CI/CD**.  
✅ **Production-Ready** – Implements **best practices for modern APIs**.  

---

## **📜 License**  

This project is licensed under the **MIT License**. See [LICENSE](LICENSE) for details.  

---

## **📞 Contact**  

For feedback, contributions, or inquiries:  
📧 **Email**: [support@time-service-api.com](mailto:support@time-service-api.com)  
💻 **GitHub**: [MrEshboboyev](https://github.com/MrEshboboyev/time-service-api)  

---

🚀 **Keep your applications synchronized with Time Service API!** Clone the repo & start using it today!  
