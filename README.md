# azure-practical-labs

# Azure Infrastructure Practical Labs

## Overview

This repository contains two instructor-led Azure Infrastructure practical assignments designed for beginners learning Microsoft Azure Infrastructure services.

The projects simulate common enterprise scenarios and focus on deploying, securing, and publishing Azure workloads using Infrastructure as a Service (IaaS) and Platform as a Service (PaaS).

These labs are intentionally designed without using Microsoft Entra ID, VPN Gateway, Azure Firewall, Private Endpoints, or other advanced networking services so that students can focus on Azure infrastructure fundamentals.

---

# Learning Objectives

By completing these labs, students will be able to:

- Deploy Azure Virtual Machines
- Configure Azure Storage Accounts
- Deploy Azure App Services
- Secure Azure Storage using Firewall Rules
- Configure Network Security Groups
- Configure Application Security Groups
- Use Azure Service Tags
- Configure Azure Load Balancer
- Configure Azure Application Gateway
- Configure Azure Traffic Manager
- Implement Availability Sets and Availability Zones
- Configure Azure Public DNS Zones
- Configure Azure Private DNS Zones

---

# Projects

| Project | Scenario | Duration |
|----------|----------|----------|
| Project 1 | Secure Internal HR Portal | 60 Minutes |
| Project 2 | Production Customer Portal | 60 Minutes |

---

# Azure Services Covered

✔ Azure Virtual Machine

✔ Azure Storage

✔ Azure App Service

✔ Azure Storage Firewall

✔ Azure Load Balancer

✔ Azure Application Gateway

✔ Azure Traffic Manager

✔ Availability Sets

✔ Availability Zones

✔ Network Security Groups

✔ Application Security Groups

✔ Service Tags

✔ Azure Public DNS

✔ Azure Private DNS

---

# Suggested Azure Region

Students may choose any Azure region.

Examples:

- East US
- West Europe
- Central India
- Southeast Asia

---

# Prerequisites

Students should have:

- Azure Subscription
- Owner or Contributor access
- Basic understanding of Azure Portal
- Familiarity with Virtual Networks

---

# Repository Structure

```
Project-01-Secure-HR-Portal
    ├── Documentation
    ├── Website
    ├── Storage Files

Project-02-Production-Customer-Portal
    ├── Documentation
    ├── Website
```

---

# Best Practices

During the labs students are encouraged to:

- Follow naming conventions
- Organize resources using Resource Groups
- Avoid exposing services publicly unless required
- Validate deployments before moving to the next task
- Remove unused resources after completing the lab

---

# Estimated Cost

These labs use mostly free-tier or low-cost Azure resources.

Recommended SKUs

- B1s Virtual Machines
- Standard LRS Storage
- B1 App Service Plan
- Standard Load Balancer
- Standard_v2 Application Gateway (delete after lab)
- Traffic Manager (minimal cost)

Students should delete all deployed resources after completing the practical sessions.

---

# License

These practical labs are intended for educational purposes.
