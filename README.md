## 1. Предметная область
Интернет магазин электронной и бытовой техники
## Введение
В сфере интернет-продажи электронных товаров главными задачами руководителя является обеспечить быструю и эффективную работу администратора, сайта и курьра. В сфере продаж предметная область.
и это особенно важно, что обуславливает быстроту операций с данными и быструю доставку товара.
Целью данной работы является исследовать предметную область организации, выявить проблемные области и составить задачи для их устранения.
 
## 1.1 Исследование предметной области
Интернет-магазин — сайт, торгующий товарами посредством сети Интернет. Позволяет пользователям онлайн, в своём браузере или через мобильное приложение, сформировать заказ на покупку, выбрать способ оплаты и доставки заказа, оплатить заказ.

Администратор- должностное лицо, управляющее в учреждении, коллективе, компании.

Курьер — человек, работающий в учреждении, разносящий деловые бумаги или компания, нанимаемые для доставки сообщений, писем, иной корреспонденции, а также небольших грузов.
Товары, покупаемые в магазине могут быть разнообразной формы и цвета. В магазине продаются электрические или бытовые товары, которые прошли проверку на брак.

## 1.2 Анализ предметов моделирования
Покупка товара в интернет – магазине:
Интернет магазин является довольно неплохой альтернативой покупки товара. Люди не имеющие возможности или желания посещать магазин могут заказать нужный им товар через интернет. В интернете есть база данных и указывается наличие товара на складе. С легкостью можно выбрать нужный товар и сделать заказ. Также можно купить товар, которого нет на складе, но он есть у поставщика в другой стране. Придется немного подождать, но в итоге можно получить эксклюзивный товар по приемлемой цене.

Для заказа товара покупателем понадобиться:
Вход или регистрации аккаунта. Так как без этого заказать товар будет нельзя. Если аккаунта у человека нет, то он должен зарегистрироваться, указав свою фамилию, имя, отчество, номер телефона, адрес проживания и электронную почту. Затем покупатель выбирает товар, оформляет заказ и проверяет все свои данные и производит оплату с помощью сбп или картой. Далее заказ отправляется в базу данных.

Проверка наличия товара на складе и его сборка интернет – магазином:
Продавец подает запрос на наличие товара, сразу после этого его ищут на складе. Если этот товар имеется в наличии, то он бронирует товар. Если товара в наличии на складе нет, то магазин делает заказ у поставщика. Этот запрос попадает в базу. Происходит заказ товара. Затем товар собирается и отправляется продавцу.

Доставка товара покупателю курьером:
Доставка товара происходит следующим способом: Заказ передаётся курьеру, который должен доставить товар покупателю через определенное время. Как только заказ отдали курьеру, он звонит или пишет смс покупателю. Курьер уточняет время и адрес доставки заказа. А дальше курьер доставляет заказ покупателю.

## 1.4 Use case модель
Диаграмма вариантов использования
Диаграмма прецедентов или диаграмма вариантов использования (англ. use case diagram) в UML — диаграмма, отражающая отношения между акторами и прецедентами и являющаяся составной частью модели прецедентов, позволяющей описать систему на концептуальном уровне.

Юзкейсы могут содержать следующие элементы (их количество зависит от сложности сценария):
Актор (actor) — тот, кто использует систему. Если взять за пример онлайн-магазин, там может быть несколько акторов: покупатели, продавцы, компании, занимающиеся доставкой, компании, проводящие платежи.
Стейкхолдер (stakeholder) — тот, кто заинтересован в определенном поведении системы. Зачастую это не конечный пользователь, а кто-то, получающий выгоду от функционирования системы. В случае с онлайн-магазином это может быть партнер — платежная платформа.
Первичное действующее лицо (primary actor) — человек или система, чьи цели достигаются при помощи нашего продукта. В онлайн-магазине это может быть основной дистрибьютор, чьи товары продаются на этой онлайн-платформе.
Предусловия и постусловия — что должно быть в наличии или должно произойти до и после запуска сценария использования.
Триггеры — события, запускающие юзкейс.
Успешный сценарий — юзкейс, при котором все идет по плану, без ошибок и неожиданностей.
Альтернативные пути — вариации основного успешного сценария на случай, если что-то пойдет не так на уровне системы.

Описание объектов и их взаимодействия в Use case модели:

Курьер в первую очередь принимает заказ у администратора, собирает его и выдает заказ клиенту.

Администратор выдает заказ курьеру, а также регистрирует покупателя. Узнает его личные контактные данные: ФИО, дату рождения, телефон.

Покупатель регистрируется, выбирает и покупает заказ. Покупатель может выбрать товар: По типу, по стоимости, по марке продукции.

После выбора нужного товара Администратор выдает заказ курьеру, после чего тот собирает нужный товар и доставляет заказ клиенту.

На рис. 1 изображена диаграмма отношений. На ней отображены обьекты расссматривемой области и связи между ними. В овальных блоках указывается тип отношений между объектами или тип действий исполняемых ими.

![RFRFRF](https://user-images.githubusercontent.com/105587997/206466816-3e2fb53b-8ff4-4333-a07b-9284caa49411.png)

Рис 1 - Отношения
## 1.3 Создание BPMN модели.
BPMN (Business Process Model and Notation) — это язык моделирования бизнес-процессов, который является промежуточным звеном между формализацией/визуализацией и воплощением бизнес-процесса. С помощью моделирования мы можем описать любые бизнес-процессы, и они могут выполняться в самых разных системах управления.
Основная цель BPMN — создание стандартного набора условных обозначений, понятных всем бизнес-пользователям. Бизнес-пользователи включают в себя бизнес-аналитиков, создающих и улучшающих процессы, технических разработчиков, ответственных за реализацию процессов и менеджеров, следящих за процессами и управляющих ими. Следовательно, BPMN призвана служить связующим звеном между фазой дизайна бизнеспроцесса и фазой его реализации.
Элементы нотации BPMN – это элементы графической схемы, но также и элементы самого бизнес-процесса.

Нотация опирается на следующие базовые графические элементы:
• Пул и Дорожки
• Действия
• Шлюзы или Развилки
• События
• Потоки
• Артефакты

Описание оформления заказа:

При оформлении заказа на сайте клиент может выбрать подходящий для него товар. После нахождения нужного продукта происходит оформление заказа и выбор клиентом нужной даты и времени доставки товара до места назначения. Для того, чтобы клиент не волновался, происходит проверка наличия сообщения о доставке. На телефон клиенту приходит смс, при получении которой клиент может убедиться, что с его товаром все в порядке и он придет в назначенный срок. Далее происходит доставка товара и оплата его покупателем при получении.

Описание доставки заказа:

Бухгалтер получает заказ, регистрирует его, после чего происходит сборка заказа. После того, как товар собран, высылает сообщение покупателю, о готовности к отправке.
Логист получает адреса и информацию о заказе, а также проверяет его целостность.Грузчик осуществляет погрузку заказа в машину и проверяет наличие всех позиций заказа.
Далее водитель осуществляет доставку товара по точному адресу покупателя. Грузчик осуществляет выгрузку товара клиенту. Далее происходит оплата товара клиента курьеру.

![321321313123213123](https://user-images.githubusercontent.com/105587997/201195401-4c47da58-030e-4e83-8b6d-b971266a925a.png)
Рис 2 - BPMN модели
## 1.5 ER-диаграмма![image](https://user-images.githubusercontent.com/105587997/201217444-e2dcdcaf-32d2-406b-ba97-c85116babbd4.png)


## 1.6 Проблематика предметной области
В наше время широко развиты интернет-ресурсы. У большинства людей не хватает времени на поход в магазин, для покупки нужной электронной или бытовой продукции, но данный сервис помогает решить им данную проблему.Клиенты не будут тратить время на магазин, курьер сам найдет и доставит нужный товар.

## 2. Сравнительный анализ
В современном мире, учитывая, что 80% своего времени человек тратит на работу, большую актуальность в бытовом плане приобретают удобные сервисы-помощники.

Рассмотрим 2 существующих сайта онлайн покупки бытовых товаров: yandex.market и eldorado. Анализируя сервисные возможности yandex.market можно отметить, что данный сайт даёт возможность пользователю самостоятельно осуществлять поиск без регистрации:

1. Раздел "электронные товары" вывогдит на экран ключевые параметры для подбора товаров, заполнив их формируется список вариантов.
2. Есть удобная функция "yandex.market рекомендует". В один клик на необходимый параметр происходит сортировка и запускается поиск нужных вариантов продукта.
3. Есть сортировка, где можно установить приоритетные критерии поиска.

Рассмотрев сервисные возможности сайта eldorado, можно отметить что данный ресурс позволяет пользователю сформировать заявку с учетом определенных критериев для поиска нужных вариантов продукта. Данный вид услуг предполагает обработку данных специалистом по подбору.На сайте есть раздел,позволяющий ознакомиться с ассортиментом продуктов, ранее реализованных конкретному покупателю, что позволяет быстрее сформировать потребность в похожем продукте.

## 3. Разработка
Разработка информационной системы состоит из двух этапов: проектирования и реализации. В проектировании информационной системы разрабатываем USE-CASE, BPMN и ER диаграммы. Данные диаграммы необходимы для графического описания лиц, описания действий участников процесса и описания их связей между собой внутри системы. Реализация информационной системы представляет собой готовый программный продукт с описанием его составляющих и текстом программного кода.

## 3.1 Этап реализации
На основе ER-диаграммы создали класс с указанием полей, параметров и типов данных для каждой сущности. Привели пример создания класса для сущности Client (листинг 1):

Листинг 1 - Класс "Клиент"

![image](https://user-images.githubusercontent.com/105587997/201220859-9610e900-0681-45c5-842a-77bbbfd1e99f.png)

Таким же создали классы для заказа, номера заказа,товара, склада, содрудника и поста.

## 3.2 Главная страница
![image](https://user-images.githubusercontent.com/105587997/221438973-1d4023d6-b85a-4c37-a48c-140b16b5ae4c.png)
выф





