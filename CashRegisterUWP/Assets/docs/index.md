---
title: Introduction to the Store Demo
author: thompcd
description: A demo to show the uses of a few core developer skills
keywords: windows 11, windows 10, uwp, windows community toolkit, uwp community toolkit, uwp toolkit, get started, visual studio, MVVM, net core, net standard
dev_langs:
  - csharp
  - vb 
---

# Introduction to the Store Demo

This demo has been created to demonstrate the uses of a few core developer skills

- **SQL Stored Procedures** - Retrieve inventory information, cart information via stored procedures
- **Two-Way Binding** - Basic MVVM pattern implements two-way binding when necessary
- **LINQ Expressions** - Filter collections on client-side using basic LINQ queries

## Navigating the app

The intended flow for this app is to:

1. On the "Till" tab, display a list of available inventory and quick filters to search the inventory. Clicking new customer will quickly create a cart and clicking an item will add to cart

2. Choosing the "Carts" tab will display open carts. Carts can pay and transact the inventory or they can be abandoned to send a re-stock notification and close the cart.

3. Choosing the "Inventory" tab will allow management of available inventory

## What this app does not do

This app does not pretend to be a comprehensive solution, it is missing many features for a production-hardened application.

- User roles, authorization and authentication
- Data sanitization
- Retry / offline strategies
- Support non-USD currency
- Support multiple locations
- Support offsite inventory
- Inventory not-on-shelf accounting (non-transacted / transacted are only inventory disposition inferred)
- Product pagination

## Additional resources

- Check out [my personal Github](https://github.com/thompcd) to view some projects I've tinkered on through the years
- Check out [Tulsa Software Github](https://github.com/tulsasoftware) to view work I've provided for clients and open-source
