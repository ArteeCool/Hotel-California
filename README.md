# Hotel-California
Hotel management application
by ArteeCool
Cringe

1. Назва застосунку - HotelBooking
2. Мета - Система для користування готелями, як для адміністраторів,так і для користувачів.

3. Користувачі та їх можливості - 
Адміністратор:
Додає нові номери.
Встановлює ціни, статуси та інші параметри номерів.
Переглядає та управляє списком бронювань.
Звичайний користувач (Гість):
Переглядає список доступних номерів.
Бронює номер на бажану дату.
Скасовує свої бронювання.

4. Основні сутності (основні об'єкти, якими оперує застосунок, та їх поля) - 
Номери: тип (наприклад, одномісний, двомісний, люкс), кількість місць, ціна, статус (вільний, заброньований, на ремонті).
Користувачі: ім'я, email, роль (адміністратор, гість), історія бронювань.
Бронювання: номер (посилання на номер), користувач (посилання на користувача), дати бронювання, статус (активне, скасоване).
Готелі: назва, адреса, рейтинг.

5. Можливості застосунку - фільтрація номерів за ціною, місткістю, рейтингом, Бронювання номерів з вибором дат, Скасування бронювання, Управління номерами та цінами адміністраторами, Перегляд історії бронювань користувачами.

6. Вибір технології UI - Winforms.
