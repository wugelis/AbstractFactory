# Clean Architecture 的書時，對於第 11 章的 DIP 依賴反轉原則中的第 P77 中的『工廠模式』

有朋友在看 Clean Architecture 的書時，對於第 11 章的 DIP 依賴反轉原則中的第 P77 中的『工廠模式』如果實際的套用在程式碼裡該怎麼做？又該怎麼分層呢？我將這個 Class Diagram 撰寫成一個 .NET 5 分層的範例並使用整潔架構。

我聲明並先假定這個 Abstract Factory 的用途並不是 DDD 中的 Factory 喔！既然是 ServiceFactory 我就假設它是需要由 Infrastructure 來時做實作的，並套用 Clean Architecture 模式，所以我一樣將 IServiceFactory 放置在 Application Service 中，ServiceFactory.cs & ConcreteImpl.cs 都在 Infrastructure 中實作，所以範例程式碼如 Github:
