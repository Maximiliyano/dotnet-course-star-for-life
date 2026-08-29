# Усунення поширених проблем

## 1. «Файли .cs підкреслено червоним усюди»

**Причини / рішення:**
- Закрийте VS і відкрийте знову.
- Build → Clean Solution → Build → Rebuild Solution.
- Перевірте, що встановлено робоче навантаження **.NET desktop development** (див. `INSTALL_VS2022.md`).

## 2. «The type or namespace name 'X' could not be found»

- Перевірте, що у `Program.cs` зверху є `using System;` (для нових проєктів він підтягується автоматично через `ImplicitUsings`).
- ПКМ на проєкті → **Manage NuGet Packages** — переконайтеся, що потрібні пакети встановлені.
- Build → Rebuild Solution.

## 3. F5 нічого не робить / запускає інший проєкт

- ПКМ на потрібному проєкті у Solution Explorer → **Set as Startup Project**.
- Перевірте, що у вгорі біля кнопки **▶** обрано саме ваш проєкт, а не «Multiple Startup Projects».

## 4. У консолі замість українських літер «????» або кракозябри

Додайте у самий початок `Main`:

```csharp
Console.OutputEncoding = System.Text.Encoding.UTF8;
```

Або через властивості системи — встановити UTF-8 за замовчуванням (Windows 11: Settings → Time & language → Language & region → Administrative language settings → Change system locale → ✅ Beta: UTF-8).

## 5. «'Console' does not contain a definition for 'WriteLine'»

Точна копія повинна бути великою буквою: `Console.WriteLine(…)`. C# чутливий до регістру.

## 6. Консольне вікно одразу закривається

Додайте у кінці програми:

```csharp
Console.WriteLine("Натисніть будь-яку клавішу для виходу…");
Console.ReadKey();
```

Або запускайте через **Ctrl+F5** замість **F5** — VS залишить консоль відкритою.

## 7. «An item with the same key has already been added»

При додаванні проєкту до solution через ПКМ — переконайтеся, що такого проєкту ще немає у списку (правий клік на solution → **Add → Existing Project…**).

## 8. Дуже довге перше відкриття проєкту

VS відновлює пакети NuGet, IntelliSense індексує файли. Це нормально для першого разу — почекайте 30–120 сек, поки внизу зникне «Restoring NuGet packages…».

## 9. «Could not load file or assembly 'System.Runtime'…»

- Build → Clean → Rebuild.
- Tools → Options → NuGet Package Manager → Clear All NuGet Cache(s).

## 10. «Run As Administrator?» при F5

Зніміть прапорець у властивостях проєкту: ПКМ → Properties → Debug → **Enable native code debugging** (зніміть, якщо стоїть).

---

## Команди dotnet CLI як альтернатива

Якщо щось не працює в VS — можна спробувати у терміналі (Win+R → `cmd` → Enter):

```bash
cd C:\Users\…\Downloads\DotNet_Lessons\01_Вступ_до_CSharp\demo
dotnet build
dotnet run
```

Якщо `dotnet run` працює, а VS — ні, то проблема саме у налаштуваннях VS.

---

## Коли не вдається — задайте питання вчителю

Опишіть:
1. Що ви робили (по кроках).
2. Що очікували побачити.
3. Що насправді сталося + повний текст помилки (скопіюйте з вкладки **Output** або **Error List**).
4. Скриншот, якщо можливо.

Це у 90 % випадків допоможе швидко знайти причину.
