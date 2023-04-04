ТЗ

Необходимо написать простое (многоуровневое, для претендующих на позицию middle developer) CRUD приложение, для создания, удаления и редактирования заказов. 
Условия:
Необходимо использовать представленную ниже схему БД.
Уровень представления должен быть выполнен на ASP.NET Core (MVC/API/Minimal API на выбор).
Ограничений по выбору ORM нет.
Показать реалистичный пример использование IoC, для претендующих на позицию middle developer. Можно использовать стандартный механизм DI предоставляемый ASP.NET Core.
Описание приложения:
Приложение должно содержать минимум 3 формы:
Главная страница
- кнопка для добавления заказов
- период в виде двух дат и мульти фильтры с выпадающим списком для фильтрации заказов
- таблица с заказами 
- кнопка для применения фильтрации
Форма просмотра (попадаем после нажатия на строчку таблицы заказов)
- информация о заказе
- кнопка для редактирования
- кнопка для удаления
Форма создания/редактирования (можно раздельно)
- кнопка для сохранения
- все редактируемые поля
- кнопка для добавления новых строчек в заказ
- кнопка для удаления строки из заказа
Структура БД:
Существуют 3 таблицы:
Order (заказ)
- Id (int)
- Number (nvarchar(max)) *редактируется *используется для фильтрации
- Date (datetime2(7)) *редактируется *используется для фильтрации 
- ProviderId (int) *редактируется *используется для фильтрации

OrderItem (элемент заказа)
- Id (int)
- OrderId (int)
- Name (nvarchar(max)) *редактируется *используется для фильтрации
- Quantity decimal(18, 3) *редактируется 
- Unit (nvarchar(max)) *редактируется *используется для фильтрации
Provider (поставщик, заполнена изначально, нигде не редактируется)
- Id (int)
- Name (nvarchar(max)) *используется для фильтрации
Дополнительно:
Поставщик выбирается для всего заказа путем выбора из выпадающего списка.
Фильтры представлены в виде (<select multiple>...</select>) которые содержат уникальные значения из БД (distinct).
Фильтр по дате представлен в виде двух input с датами, означающими период, за который должны отображаться заказы. Значение по умолчанию: месяц назад от сегодняшней даты – сегодняшняя дата.
Фильтрация должна происходить на серверной стороне приложения.
Пользовательский интерфейс не является ключевым аспектом данной задачи, поэтому его внешним видом можно условно пренебречь. 
Отметки «*редактируется» и «*используется для фильтрации» означают, что поля можно редактировать и использовать для фильтрации на уровне представления, непосредственно в пользовательском интерфейсе.
Order.Number «в связке» с Order.ProviderId должен быть уникален, т.е. не должно существовать 2х заказов от одного поставщика с одинаковыми номерами. При попытке сохранения, программа должна показывать уведомление о невозможности сохранения (ограничение предметной области).
OrderItem.Name не может быть равен Order.Number (ограничение предметной области).

