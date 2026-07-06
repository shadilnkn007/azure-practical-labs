# Project 01 - Secure HR Portal

## Scenario

ABC Technologies is a medium-sized organization with approximately 600 employees.

The HR department wants to modernize its internal application infrastructure by moving its employee portal to Microsoft Azure.

The requirements are:

- HR employees should access a web portal hosted on Azure App Service.
- HR administrators should manage employee documents from a Windows Virtual Machine.
- Employee documents should be stored securely in Azure Storage.
- Only approved Azure resources should be allowed to communicate with the storage account.
- Internal resources should communicate using private DNS names.

The company has not yet implemented VPN connectivity or Microsoft Entra ID. All deployment will be completed using Azure Portal.

---

# Estimated Duration

**60 Minutes**

---

# Learning Objectives

After completing this project students should be able to:

- Deploy Azure Virtual Machines
- Create Azure Storage Accounts
- Deploy Azure App Service
- Host a Web Application
- Configure Storage Firewall
- Configure Network Security Groups
- Configure Application Security Groups
- Configure Service Tags
- Configure Azure Private DNS Zone

---

# Azure Services Used

| Service | Purpose |
|----------|---------|
| Azure VM | HR Administration Server |
| Azure Storage | Employee Documents |
| Azure App Service | HR Portal |
| Storage Firewall | Restrict Storage Access |
| NSG | Control Network Traffic |
| ASG | Group Virtual Machines |
| Service Tags | Simplify NSG Rules |
| Private DNS Zone | Internal Name Resolution |

---

# Architecture

```text
                     Employees
                           │
                 Azure App Service
                     HR Portal
                           │
              -------------------------
              │                       │
      HR Administration VM      Azure Storage
           (Windows)          Blob Containers
              │
          NSG + ASG
              │
        Virtual Network
              │
      Private DNS Zone
```

---

# Naming Convention

| Resource | Name |
|----------|------|
| Resource Group | RG-HRPortal |
| Virtual Network | VNET-HR |
| Subnet | SNET-Management |
| VM | HR-ADMIN-VM |
| Storage | hrstoragexxxx |
| App Service Plan | ASP-HRPortal |
| Web App | hrportal-web |
| NSG | NSG-HR |
| ASG | ASG-HRAdmins |
| Private DNS Zone | hrportal.local |

---

# Resource Deployment Sequence

```
Resource Group
        │
        ▼
Virtual Network
        │
        ▼
Subnet
        │
        ▼
Network Security Group
        │
        ▼
Application Security Group
        │
        ▼
Virtual Machine
        │
        ▼
Storage Account
        │
        ▼
Storage Firewall
        │
        ▼
App Service Plan
        │
        ▼
Web App
        │
        ▼
Private DNS Zone
```

---

# Practical Tasks

## Task 1

Create a Resource Group.

Suggested Name:

```
RG-HRPortal
```

---

## Task 2

Create a Virtual Network.

Suggested Configuration

- Address Space
- One Management Subnet
- One Application Subnet

---

## Task 3

Deploy a Windows Virtual Machine.

Suggested Configuration

- Windows Server 2022
- B1s
- Public IP
- Allow RDP

Verify remote desktop connectivity.

---

## Task 4

Install IIS.

Open IIS Manager.

Deploy the sample website provided in the **website** folder.

Verify:

```
http://<VM Public IP>
```

---

## Task 5

Create an Azure Storage Account.

Configuration

- Standard LRS
- Hot Tier

Create Blob Container

```
hr-documents
```

Upload

- Employee-Handbook.txt
- Leave-Policy.txt

---

## Task 6

Configure Storage Firewall.

Allow

- Selected Networks

Permit

- Virtual Network

Block

- Public Internet

Verify that unauthorized networks cannot access the storage account.

---

## Task 7

Create Application Security Group.

```
ASG-HRAdmins
```

Associate the Virtual Machine.

---

## Task 8

Create Network Security Group.

Allow

- RDP
- HTTP

Use

- Service Tags
- ASG

instead of manually specifying source IP addresses where appropriate.

Associate the NSG with the subnet.

---

## Task 9

Deploy Azure App Service.

Create

- App Service Plan
- Web App

Deploy the sample HR Portal website.

Verify successful access.

---

## Task 10

Create a Private DNS Zone.

Example

```
hrportal.local
```

Create records for:

- HR Admin VM
- HR Portal

Verify name resolution from resources within the virtual network.

---

# Deliverables

Students should capture screenshots of:

- Resource Group
- Virtual Network
- VM
- IIS Website
- Storage Account
- Blob Container
- Storage Firewall
- App Service
- Web App
- NSG
- ASG
- Private DNS Zone

---

# Validation Checklist

| Task | Status |
|------|--------|
| VM deployed | ☐ |
| IIS Installed | ☐ |
| Storage created | ☐ |
| Storage Firewall configured | ☐ |
| NSG configured | ☐ |
| ASG configured | ☐ |
| Service Tags used | ☐ |
| App Service deployed | ☐ |
| Web App accessible | ☐ |
| Private DNS configured | ☐ |

---

# Cleanup

Delete

- Resource Group
- Storage Account
- App Service
- Virtual Machine

to avoid unnecessary Azure charges.
