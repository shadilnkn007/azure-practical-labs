# Student Lab Guide

# Project 01 – Secure HR Portal

---

## Lab Overview

In this practical session, you will deploy a secure internal Human Resources (HR) application in Microsoft Azure.

You will configure:

- Azure Virtual Machine
- Azure Storage
- Azure App Service
- Storage Firewall
- Network Security Groups (NSG)
- Application Security Groups (ASG)
- Service Tags
- Azure Private DNS

The completed environment will resemble a small enterprise deployment.

---

# Estimated Duration

**60 Minutes**

---

# Prerequisites

Before starting, ensure you have:

- Azure Subscription
- Access to Azure Portal
- Basic understanding of Virtual Networks

---

# Architecture

```

Employees
│
Azure App Service
│
───────────────
│ │
HR Admin VM Azure Storage
│
NSG + ASG
│
Virtual Network
│
Private DNS

```

---

# Task 1 – Create a Resource Group

Navigate to:

```

Azure Portal
→ Resource Groups
→ Create

```

Configuration

| Setting | Value |
|----------|-------|
| Resource Group | RG-HRPortal |
| Region | Choose nearest region |

Click **Review + Create**.

### Checkpoint

✔ Resource Group created successfully.

---

# Task 2 – Create a Virtual Network

Navigate to:

```

Virtual Networks
→ Create

```

Configuration

| Setting | Value |
|----------|-------|
| Name | VNET-HR |
| Address Space | 10.0.0.0/16 |

Create two subnets.

| Subnet | Address Range |
|----------|--------------|
| Management | 10.0.1.0/24 |
| Application | 10.0.2.0/24 |

### Checkpoint

✔ Virtual Network created.

---

# Task 3 – Deploy the HR Administration Virtual Machine

Navigate to

```

Virtual Machines
→ Create

```

Recommended Settings

| Property | Value |
|------------|-----------|
| Name | HR-ADMIN-VM |
| Image | Windows Server 2022 |
| Size | B1s |
| Username | azureadmin |
| Authentication | Password |

Networking

- Existing Virtual Network
- Management Subnet
- Public IP Enabled

Allow

- RDP

Create the VM.

---

### Verification

Connect using Remote Desktop.

Login successfully.

---

# Task 4 – Install IIS

Inside the VM

Open

```

Server Manager

```

Select

```

Add Roles and Features

```

Install

```

Web Server (IIS)

```

After installation

Open browser

Visit

```

http://localhost

```

Expected Output

```

IIS Default Page

```

---

# Task 5 – Deploy the HR Website

Copy the supplied website files into

```

C:\inetpub\wwwroot

```

Refresh

```

http://localhost

```

Expected Output

```

ABC Technologies
Human Resources Portal

```

---

# Task 6 – Create Azure Storage Account

Navigate to

```

Storage Accounts
→ Create

```

Configuration

| Setting | Value |
|----------|-------|
| Performance | Standard |
| Redundancy | LRS |

After deployment

Create a Blob Container

```

hr-documents

```

Upload

- Employee-Handbook.txt
- Leave-Policy.txt

---

### Verification

Both files appear inside the Blob Container.

---

# Task 7 – Configure Storage Firewall

Open

```

Storage Account
→ Networking

```

Select

```

Enabled from selected virtual networks

```

Allow

- VNET-HR

Save changes.

---

### Verification

Storage account is no longer publicly accessible.

---

# Task 8 – Create Application Security Group

Navigate to

```

Application Security Groups

```

Create

```

ASG-HRAdmins

```

Associate

```

HR-ADMIN-VM

```

---

### Verification

VM appears inside the ASG.

---

# Task 9 – Configure Network Security Group

Create

```

NSG-HR

```

Associate

```

Management Subnet

```

Create Rules

Allow

| Source | Destination | Port |
|----------|------------|------|
| Internet | VM | 3389 |
| Internet | VM | 80 |

Use

- Azure Service Tags

where applicable.

---

### Verification

VM remains accessible.

Website loads correctly.

---

# Task 10 – Deploy Azure App Service

Navigate to

```

App Services

```

Create

```

ASP-HRPortal

```

Deploy

```

hrportal-web

```

Publish

```

Code

```

Operating System

```

Windows

```

Deploy the supplied website.

---

### Verification

Browse

```

https://hrportal-web.azurewebsites.net

```

The HR Portal should load successfully.

---

# Task 11 – Configure Private DNS Zone

Navigate to

```

Private DNS Zones

```

Create

```

hrportal.local

```

Add

Host Records

Example

| Host | IP |
|--------|------|
| hr-admin | VM IP |
| hr-storage | Storage Private Address (if applicable for future labs) |

Link the DNS Zone to

```

VNET-HR

```

---

### Verification

Resources inside the VNet resolve hostnames correctly.

---

# Deliverables

Capture screenshots of:

- Resource Group
- Virtual Network
- VM
- IIS Website
- Storage Account
- Blob Container
- Storage Firewall
- NSG
- ASG
- App Service
- Web App
- Private DNS Zone

---

# Challenge Questions

### Question 1

Why should Storage Accounts not remain open to the Internet?

---

### Question 2

What is the purpose of an Application Security Group?

---

### Question 3

How do Service Tags simplify NSG rule management?

---

### Question 4

What advantage does Azure App Service provide over hosting websites only on Virtual Machines?

---

# Cleanup

Delete the following resources:

- Resource Group
- Virtual Machine
- Storage Account
- App Service
- Public IP Address

This helps avoid unnecessary Azure charges.

---

# End of Lab
