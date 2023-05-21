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

Рисунок 1 - Отношения
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
Рисунок 2 - BPMN модели
## 1.5 ER-диаграмма![image](https://user-images.githubusercontent.com/105587997/201217444-e2dcdcaf-32d2-406b-ba97-c85116babbd4.png)
Рисунок 3 - ER-диаграмма


## 1.6 Проблематика предметной области
В наше время широко развиты интернет-ресурсы. У большинства людей не хватает времени на поход в магазин, для покупки нужной электронной или бытовой продукции, но данный сервис помогает решить им данную проблему.Клиенты не будут тратить время на магазин, курьер сам найдет и доставит нужный товар.

## 2. Сравнительный анализ
В современном мире, учитывая, что 80% своего времени человек тратит на работу, большую актуальность в бытовом плане приобретают удобные сервисы-помощники.

Рассмотрим 2 существующих сайта онлайн покупки электронных и бытовых товаров: М.Видео и eldorado, которые являются одними из самых больших маркетплейсов в 
России.[1] Анализируя сервисные возможности М.Видео можно отметить, что данный сайт даёт возможность пользователю самостоятельно осуществлять поиск без регистрации:

1. Раздел "электронные товары" вывогдит на экран ключевые параметры для подбора товаров, заполнив их формируется список вариантов.
2. Есть удобная функция "М.Видео рекомендует". В один клик на необходимый параметр происходит сортировка и запускается поиск нужных вариантов продукта.
3. Есть сортировка, где можно установить приоритетные критерии поиска.[2]

Рассмотрев сервисные возможности сайта eldorado, можно отметить что данный ресурс позволяет пользователю сформировать заявку с учетом определенных критериев для поиска нужных вариантов продукта. Данный вид услуг предполагает обработку данных специалистом по подбору.На сайте есть раздел,позволяющий ознакомиться с ассортиментом продуктов, ранее реализованных конкретному покупателю, что позволяет быстрее сформировать потребность в похожем продукте.[3]


## 2.1 БД и микросервисы
Для того, чтобы все это работало как часы, нам необходимо следить за развитием технологий и оперативно реагировать на запросы бизнеса. К сожалению, далеко не всегда базовая функциональность глобальных ERP-систем способна быстро реагировать на возникшие потребности внутренних клиентов. В 2016 году это стало одним из аргументов в пользу нашего перехода на микросервисную архитектуру.[4]

Перед компанией стояла достаточно сложная задача, реализовать единую бизнес-логику работы с различными промо-механиками в процессе оформления клиентами заказов во всех каналах продаж и точках контакта (на тот момент: сайт, мобильное приложение, кассы и терминалы в магазинах и операторы в колл-центре).При этом внутри ИТ-ландшафта у них были большие монолитные системы вида Oracle ATG E-commerce platform, SAP CRM и другие. Повторение логики в каждой из них или реализация в одной и переиспользование в другой необходимой функциональности по их расчетам выливалось в годы времени и десятки миллионов инвестиций.Поэтому они собрали небольшую команду разработчиков и технически грамотных людей, которые были на тот момент в нашем распоряжении, и подумали, как им сделать отдельный для наших нужд сервис. 

В процессе проработки они поняли, что им на самом деле нужен не один, а три-четыре рабочих инструмента. Так они подошли к концепции микросервисной архитектуры первый раз.Кодить решили на Java, так как в этом у них был необходимый опыт. Выбрали Spring версии 3.2. В итоге получился некий распределенный микромонолит в три-четыре сервиса, тесно взаимосвязанных между собой. Несмотря на то, что разрабатывались они независимо, работать могли только все вместе.Тем не менее это был большой скачок в плане развития собственных технологий. Они перешли с Java6 на Java8, начали осваивать Spring 3, плавно перейдя на Spring 4. Конечно же, это была определенная проба пера.Они успешно сократили сроки реализации проекта с туманных «годы на разработку», реализовав нужную им кросс-канальную бизнес-логику фактически за два месяца. При этом, последующие доработки они выдавали в горизонте двух недель [5]. Так пришли к микросервисной архитектуре 
(рисунок 4). 

![image](https://github.com/san1x2003/Project1/assets/105587997/a6cbdbe8-a0a5-4ada-81c7-635ef8b9839b)
Рисунок 4 - Микросервисная архитектура

В 2017-18 годах они начали глобальный рефакторинг микромонолита. Концепция развития микросервисов понравилась, как и IT-специалистам так и бизнесу. Поток рабочих задач начал нарастать.
Кроме того,  они продолжили выделять из корпоративного ИТ-ландшафта нужные разным потребителям функциональные блоки и переводить их на рельсы микросервисов.Они попытались идти в ногу со временем и скакнуть на Java9, но успехом это не увенчалось. К сожалению, осязаемой выгоды они от этого упражнения не получили поэтому остались на Java8.

Сервисов становилось все больше, ими надо было централизовано управлять, стандартизировать работу с ними. Тут  они впервые попробовали контейнеризацию Docker тогда они были большие и тяжелые по несколько сотен мегабайт.Позже им пришлось решать вопросы с балансировкой трафика и нагрузки на сервисы. В качестве решений  они выбрали Consul для внешних клиентов и Eureka для внутренних. Пробовали разные инструменты межсервисного взаимодействия gRPC, RMI. Так  они жили почти год, и как им казалось, научились успешно создавать микросервисы и строить микросервисную архитектуру.[5]

## 2.1 Техническое оснащение
Магазины «Эльдорадо» открыты во всех городах России с населением от 500 тысяч жителей и более чем в 90% городов с населением 250-500 тысяч жителей. Как М.Видео, так и Eldorado — частные компании, и им очень важна операционная прибыль.[6]

Стандартный путь крупной компании, которая ценит свои данные — покупать большие и надежные СХД, с резервируемыми контроллерами, проприетарными технологиями репликации данных между дата-центрами, самым умным в мире тирингом и прочими изобретениями вендоров.Это мощные девайсы, и чаще всего на них можно положиться, но проблема в том, что они дорогие. По цене такой СХД можно купить кучу обычных серверов, а вопрос резервирования и шардирования данных решить на уровне самих приложений — в этом случае больше инвестируют в собственное приложение, но зато всю добавочную стоимость вендора оставляют себе. [7]

Поэтому М.Видео-Эльдорадо переходит на оборудование Pure Storage.Pure Storage обеспечила переход группы «М.Видео-Эльдорадо», крупнейшего в России продавца электроники и бытовой техники, на флэш-системы хранения и обработки данных от Pure. Решение позволит поддержать динамичный рост бизнеса за счёт повышения ёмкости и скорости обработки данных, а также снижения количества системных отказов.«М.Видео-Эльдорадо» в рамках долгосрочной стратегии One Retail активно развивает цифровые платформы и автоматизирует ИТ-сервисы как в рознице, так и онлайн, чтобы, с одной стороны, предлагать клиентам лучший на рынке покупательский опыт, а с другой – повышать операционную эффективность и обеспечивать базу для дальнейшего роста. Так, компания перешла к гибридной инфраструктуре из собственных мощностей и облачных сред, в связи с чем появилась необходимость обновить системы под новые задачи.

После тестирования решений основных производителей ритейлер выбрал Pure Storage. Среди главных преимуществ – высокая производительность, сжатие данных, доступная стоимость владения и скорость решения инцидентов. ИТ-специалисты «М.Видео-Эльдорадо» перенесли высоконагруженные базы данных на массивы Pure: централизованные офисные сервисы, почту, виртуальные рабочие станции, а также торговые системы и сайты mvideo.ru и eldorado.ru. В результате увеличилась скорость работы виртуальных машин, при этом, благодаря технологии сжатия данных, значительно уменьшился объём потребляемого дискового пространства. На решения Pure произведена миграция сервисов VDI, что позволило ускорить работу и сократить количество сбоев в инфраструктуре виртуальных рабочих столов (VDI). Благодаря этому «М.Видео» и «Эльдорадо» смогли повысить уровень сервиса как для покупателей, так и для внутренних клиентов.[8]

## 3. Разработка
Разработка информационной системы состоит из двух этапов: проектирования и реализации. В проектировании информационной системы разрабатываем USE-CASE, BPMN и ER диаграммы. Данные диаграммы необходимы для графического описания лиц, описания действий участников процесса и описания их связей между собой внутри системы. Реализация информационной системы представляет собой готовый программный продукт с описанием его составляющих и текстом программного кода.




СПИСОК ИСПОЛЬЗОВАННЫХ ИСТОЧНИКОВ

1)Список Крупнейших Магазинов Электрони и бытовой техники в России на 2023 / smm-tips.ru [сайт]. – URL: https://smm-tips.ru/rating/internet-magaziny-elektroniki.html 
(дата обращения 25.03.2023).

2)Помощь покупателю М.Видео / www.mvideo.ru [сайт].– URL: https://www.mvideo.ru/help 
(дата обращения 25.03.2023).

3)Пользовательское соглашение / blog.eldorado.ru [сайт]. – URL: https://blog.eldorado.ru/content/polzovatelskoe-soglashenie
(дата обращения 25.03.2023).

4)Информационные технологии в М.Видео / www.tadviser.ru [сайт]. – URL:https://www.tadviser.ru/index.php/%D0%A1%D1%82%D0%B0%D1%82%D1%8C%D1%8F:%D0%98%D0%BD%D1%84%D0%BE%D1%80%D0%BC%D0%B0%D1%86%D0%B8%D0%BE%D0%BD%D0%BD%D1%8B%D0%B5_%D1%82%D0%B5%D1%85%D0%BD%D0%BE%D0%BB%D0%BE%D0%B3%D0%B8%D0%B8_%D0%B2_%D0%9C.%D0%92%D0%B8%D0%B4%D0%B5%D0%BE_-_%D0%AD%D0%BB%D1%8C%D0%B4%D0%BE%D1%80%D0%B0%D0%B4%D0%BE
(дата обращения 25.03.2023).

5)Как «М.Видео-Эльдорадо» развивает собственную микросервисную архитектуру / vc.ru [сайт]. – URL:https://vc.ru/mvideoeldorado/213279-zachem-izobretat-velosiped-ili-kak-m-video-eldorado-razvivaet-sobstvennuyu-mikroservisnuyu-arhitekturu
(дата обращения 21.05.2023).

6)Оснащение новых объектов Эльдорадо / companies.arendator.ru [сайт]. – URL: https://companies.arendator.ru/893-eldorado-1/
(дата обращения 21.05.2023).

7)М.Видео-Эльдорадо / tadviser.ru [сайт]. – URL:https://www.tadviser.ru/index.php/%D0%9A%D0%BE%D0%BC%D0%BF%D0%B0%D0%BD%D0%B8%D1%8F:%D0%9C.%D0%92%D0%B8%D0%B4%D0%B5%D0%BE-%D0%AD%D0%BB%D1%8C%D0%B4%D0%BE%D1%80%D0%B0%D0%B4%D0%BE
(дата обращения 21.05.2023).

8)Переход М.Видео на оборудование Pure Storage / www.cnews.ru [сайт]. – URL:https://www.cnews.ru/news/line/2019-11-18_mvideoeldorado_perehodit
(дата обращения 21.05.2023).







