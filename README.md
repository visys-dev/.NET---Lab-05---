# Lab-05-EventsApp

## Огляд

У цьому репозиторії містяться три окремі .NET-проєкти, які демонструють практичні завдання з роботи з делегатами, подіями та асинхронними callback-функціями:

- **Task1**: Консольний додаток із підпискою на події (`DollarTracker`) за допомогою лямбда-виразів.  
- **Task2**: Консольний додаток із асинхронним завантаженням файлу (імітація через `Task.Delay`) та callback-функцією.  
- **Task3**: Windows Forms-додаток із обробкою події натискання кнопки через анонімний делегат.

**Структура репозиторію**

```text
Lab-05-EventsApp/
├── Lab-05-Task1/          ← Завдання 1: DollarTracker (Console App)
│   ├── Lab-05-Task1.csproj
│   ├── Program.cs
│   ├── DollarTracker.cs
│   └── DollarSubscriber.cs
├── Lab-05-Task2/          ← Завдання 2: Async callback (Console App)
│   ├── Lab-05-Task2.csproj
│   └── Program.cs
└── Lab-05-Task3/          ← Завдання 3: WinForms App
    ├── Lab-05-Task3.csproj
    ├── Program.cs
    └── Form1.cs
