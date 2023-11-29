# Tacta-Internship-Project

## Task Overview

This repository is a response to the TACTA internship task, aiming to create a simple web application for managing shopping lists for various individuals. The primary focus is on code quality and best practices.

## Task Requirements

The task involves building a web application with the following features:

1. **Display Pre-populated Data:**
   The application starts by presenting a list of 5 shoppers and 5 items, providing a foundation for creating shopping lists.

2. **Create and Save Shopping Lists:**
   Users can create and save shopping lists for each shopper, ensuring a straightforward and intuitive list management process.

3. **Item Limitation:**
   To meet task requirements, the application restricts the addition of an item to a fourth shopping list, maintaining data integrity.

4. **View Created Lists:**
   Users can easily access and view the shopping lists they have created for each individual shopper.


## Technologies

- Backend: C#, .NET 6.0
- Frontend: Angular

## Installation Instructions

1. Clone the GitHub repository.

    ```bash
    git clone https://github.com/farisgogic/Tacta-Intership-Project.git
    ```
    
2. Open the cloned repository in the console.

3. Run the Dockerized API and DB.

    ```bash
    docker-compose build
    docker-compose up
    ```
    
4. Open the TactaIntershipProjectAngular folder.

    ```bash
    cd TactaIntershipProjectAngular
    ```

5. Install dependencies.

    ```bash
    npm install
    ```
    
6. Run the application.

    ```bash
    ng serve
    ```
