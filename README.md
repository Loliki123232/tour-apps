# 🧳 Программа для турагентства
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
![SQLite](https://img.shields.io/badge/sqlite-%2307405e.svg?style=for-the-badge&logo=sqlite&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white)

**Программа для турагентства** — это настольное приложение для Windows, разработанное с использованием **WinForms** и языка программирования **C#**. Приложение автоматизирует основные процессы туроператора: от управления турами и клиентами до оформления бронирований и контроля оплаты. Интерфейс ориентирован на простоту и удобство работы офисных сотрудников.

Программа построена с использованием Entity Framework Core и паттернов проектирования, обеспечивая надежную работу с базой данных и легкую масштабируемость.

---

## 🔧 Основной функционал

### 🌍 Управление турами

* Добавление, редактирование и удаление туров
* Привязка страны, города, отеля, дат и стоимости
* Учет количества свободных мест
* Отображение доступных и завершенных туров

### 📅 Бронирования

* Создание и редактирование бронирований
* Проверка доступности туров на заданные даты
* Отображение истории и статуса бронирования
* Привязка клиента и отображение связанной информации

### 👤 Работа с клиентами

* Добавление новых клиентов с контактной информацией
* Поиск клиентов по имени, телефону, email
* История заказов по каждому клиенту
* Хранение паспортных данных, пожеланий, комментариев

### 💰 Оплаты

* Учет частичных и полных оплат
* Просмотр задолженностей
* Экспорт финансовой информации в Excel или PDF

---

## 🧩 Технологический стек

* **Язык:** C#
* **Интерфейс:** WinForms
* **ORM:** Entity Framework Core
* **База данных:** SQL Server / SQLite
* **Отчеты:** Microsoft ReportViewer / PDFSharp
* **IDE:** Visual Studio 2022

---
# ERD Диаграмма базы даннх
![image](https://github.com/user-attachments/assets/71b4f000-9254-4709-a102-dc761912b4c9)


## 🧭 Архитектура приложения

Проект разделён на логические слои с использованием **принципов разделения ответственности**:

* `Models/` — бизнес-сущности (туры, клиенты, бронирования)
* `ViewModels/` — логика взаимодействия с формами
* `Forms/` — WinForms-формы интерфейса
* `Services/` — работа с базой данных и логикой бронирования
* `Database/` — миграции и инициализация базы данных

---

## 📈 Будущие улучшения

* 🌐 Поддержка API для онлайн-бронирования
* ☁️ Интеграция с облачным хранилищем (Azure, Firebase)
* 📊 Аналитика и визуализация данных (графики и отчеты)
* 🌍 Многоязычность интерфейса (RU / EN / DE)
* 📅 Интеграция с календарями и почтой (Outlook, Gmail)
