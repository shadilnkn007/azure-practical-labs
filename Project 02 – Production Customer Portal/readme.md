# Project 02 - Production Customer Portal

## Scenario

ABC Technologies has successfully deployed its internal HR Portal in Azure.

The company is now launching a **public-facing Customer Portal** that must be highly available, scalable, and resilient.

Business requirements:

- The application should continue operating even if one virtual machine fails.
- Incoming traffic should be distributed across multiple web servers.
- The application should support application-layer routing.
- Future expansion to multiple Azure regions should be possible.
- Customers should access the application using a custom domain.

As an Azure Infrastructure Administrator, your task is to deploy the production infrastructure following Azure best practices.

---

# Estimated Duration

60 Minutes

---

# Learning Objectives

After completing this project, students will be able to:

- Deploy multiple Azure Virtual Machines
- Configure Availability Sets
- Understand Availability Zones
- Configure Azure Load Balancer
- Configure Azure Application Gateway
- Configure Azure Traffic Manager
- Configure Azure Public DNS
- Validate highly available web applications

---

# Azure Services Used

| Service | Purpose |
|----------|----------|
| Azure Virtual Machines | Web Servers |
| Availability Set / Availability Zones | High Availability |
| Azure Load Balancer | Layer 4 Traffic Distribution |
| Azure Application Gateway | Layer 7 Load Balancing |
| Azure Traffic Manager | Global Traffic Routing |
| Azure Public DNS | Public Name Resolution |

---

# Architecture

```text
                    Internet
                        │
                        ▼
             Azure Traffic Manager
                        │
                        ▼
               Azure Application Gateway
                        │
                        ▼
                Azure Load Balancer
                  │              │
                  ▼              ▼
             Web Server 1    Web Server 2
          (Availability Set / Zones)
```

---

# Naming Convention

| Resource | Name |
|----------|------|
| Resource Group | RG-CustomerPortal |
| VNet | VNET-Customer |
| VM1 | WEB-01 |
| VM2 | WEB-02 |
| Load Balancer | LB-Customer |
| Application Gateway | AGW-Customer |
| Traffic Manager | TM-Customer |
| DNS Zone | abcportal.com |

---

# Resource Deployment Order

```
Resource Group
      │
      ▼
Virtual Network
      │
      ▼
Availability Set
      │
      ▼
Virtual Machines
      │
      ▼
Azure Load Balancer
      │
      ▼
Application Gateway
      │
      ▼
Traffic Manager
      │
      ▼
Azure Public DNS
```

---

# Deliverables

Students should submit screenshots of:

- Availability Set
- Virtual Machines
- IIS websites
- Load Balancer
- Backend Pool
- Health Probe
- Application Gateway
- Traffic Manager
- Public DNS Zone

---

# Cleanup

Delete the Resource Group after completing the lab.
