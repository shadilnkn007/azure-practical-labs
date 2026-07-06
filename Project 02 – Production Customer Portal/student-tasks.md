# Student Lab Guide

# Project 02 – Production Customer Portal

---

## Objective

Deploy a production-ready web application using Azure networking services.

---

# Task 1

Create a Resource Group.

```
RG-CustomerPortal
```

---

# Task 2

Create a Virtual Network.

```
VNET-Customer
```

Create one subnet for web servers.

---

# Task 3

Create an Availability Set.

Name

```
AS-WEB
```

Fault Domains

```
2
```

Update Domains

```
5
```

> Instructor Note: If your selected Azure region supports Availability Zones, discuss the difference between Availability Sets and Availability Zones.

---

# Task 4

Deploy Two Virtual Machines

```
WEB-01

WEB-02
```

Both should:

- Windows Server 2022
- IIS Installed
- B1s

Deploy the sample website.

Modify only ONE line on each server.

WEB-01

```
Server Name

WEB SERVER 01
```

WEB-02

```
Server Name

WEB SERVER 02
```

---

# Task 5

Create Azure Load Balancer

Configure

- Frontend IP
- Backend Pool
- Health Probe
- Load Balancing Rule

Add

WEB-01

WEB-02

---

### Validation

Refresh the browser multiple times.

Observe responses from both servers.

---

# Task 6

Deploy Application Gateway

Configuration

Standard v2

Listener

HTTP

Backend Pool

Load Balancer backend or directly to the VMs (depending on instructor preference)

Routing Rule

Basic

---

### Validation

Browse to the Application Gateway Public IP.

Verify the website loads successfully.

---

# Task 7

Deploy Azure Traffic Manager

Routing Method

Priority

Endpoint

Application Gateway

---

### Validation

Verify the Traffic Manager DNS name resolves successfully.

Discuss how another regional endpoint could be added for disaster recovery.

---

# Task 8

Create Azure Public DNS Zone

Example

```
abcportal.com
```

Create

```
portal
```

A Record

Point to

Traffic Manager or Application Gateway (as directed by the instructor).

---

# Deliverables

Capture screenshots of:

- Availability Set
- Virtual Machines
- IIS Website
- Load Balancer
- Application Gateway
- Traffic Manager
- Public DNS Zone

---

# Discussion Questions

1. Why are Availability Sets important?

2. How do Availability Zones improve resilience?

3. When would you choose Application Gateway instead of Load Balancer?

4. Why is Traffic Manager placed before Application Gateway?

5. What role does Azure Public DNS play?

---

# Cleanup

Delete the Resource Group.
