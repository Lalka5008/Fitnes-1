# Информационная система фитнес-центра "Викинг" (C#)

Данная информационная система разработана на языке программирования C# для управления клиентами фитнес-центра "Викинг". Система предоставляет возможность регистрации новых клиентов, а также управления информацией о существующих клиентах.

### [Скриншоты программы](https://drive.google.com/drive/folders/1QOe6kp1X1rJuNa24Fia6LdjJsKU60qCi?usp=sharing)
*Хранение изображений: Google.disk*

 ![Промо фото проекта](https://i.postimg.cc/mrqXQHrx/image.png)

## Функциональность

1. **Регистрация клиентов**: Пользователь может добавлять новых клиентов, указывая их персональные данные (фамилия, имя, отчество, дата рождения, номер телефона).

2. **Управление информацией о клиентах**: Пользователь имеет возможность просматривать список всех клиентов и подробную информацию о каждом из них. Вся информация о клиенте доступна для редактирования и удаления.

3. **Автоматическое определение возраста клиента**: Система определяет возраст клиента на основе его даты рождения.

4. **Отображение срока абонемента**: Для каждого клиента система отображает срок его абонемента. Если абонемент истек, система показывает надпись "истёк".

5. **Управление статусом клиента**: Клиенты могут иметь различные статусы: обычный клиент, бизнес-клиент или вип-клиент. Пользователь имеет возможность изменять статус клиента.

6. **Идентификация клиента по номеру телефона**: При добавлении или изменении номера телефона система оповещает пользователя, если данный номер уже принадлежит другому клиенту.

7. **Присвоение личного идентификатора**: Каждому новому клиенту автоматически присваивается личный идентификатор.

## Технические детали

- **Язык программирования**: C#
- **База данных**: SQLite (с использованием библиотеки Microsoft.Data.Sqlite)
- **Генерация записей о пользователях**: Для обеспечения тестирования и демонстрации функциональности системы разработана библиотека, которая генерирует 200 записей о пользователях.

  ## Пример работы с базой данных SQLite

Для работы с базой данных SQLite в данном примере используется библиотека Microsoft.Data.Sqlite в среде программирования C#. Пример демонстрирует поиск клиента в базе данных по фамилии и имени.

``` C#
using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
{

    connection.Open();

    using (var command = connection.CreateCommand())
          {
           // Поиск клиента по фамилии и имени
           command.CommandText = "SELECT ID FROM clients WHERE FirstName = @firstName AND Name = @Name";
           command.Parameters.AddWithValue("@firstName", firstName);
           command.Parameters.AddWithValue("@Name", lastName);

          using (var reader = command.ExecuteReader())
          {
                if (reader.Read())
                {
                     // Найден клиент, отображаем кнопки для редактирования данных
                     ID = reader["ID"].ToString();
                     buttonFirstName.Visible = true;
                     buttonName.Visible = true;
                     buttonPatronymic.Visible = true;
                     buttonPhoneNumber.Visible = true;
                     buttonBirthDate.Visible = true;

                     // Убираем текстовые поля для ввода фамилии и имени
                     textBox1.Visible = false;
                     textBox2.Visible = false;
                     button3.Visible = false;
                     label13.Visible = false;
                     label14.Visible = false;
                }
                else
                {
                     MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          }
     }
}
напримере этого фрагмента кода расскажу как подключили бд в переменную path записали путь до базы данных задали разрешение читать и записывать
потом мы подключились и открыли её дальше уже происходит запрос, а точнее поиск есть ли эти данные в бд или нет если да, то записывается ID чтобы потом менять параметры пользователя
```
## Как использовать

1. Установите необходимые зависимости, включая библиотеку Microsoft.Data.Sqlite.
2. Запустите программу и воспользуйтесь функциональностью системы.

## Примечания

Данная информационная система предоставляет базовый функционал для управления клиентами фитнес-центра. В дальнейшем ее функциональность может быть расширена или улучшена в соответствии с требованиями и потребностями бизнеса.

## Авторы программы

### Даниил Л. (Lalka5008)
### Данил К. (BlackStarf)
