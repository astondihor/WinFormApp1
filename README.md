# WinFormApp1

>Warning: Internal use only. Not Good for other.

>Catatan: Hanya sebuah pembelajaran tidak digunakan untuk produksi.

Ini adalah sebuah contoh Layered Application pada Window Form Application (.NET Framework 4.5.1) dengan pendekatan penggunaan model Onion. Perbedaanya dengan Layered Application yang umum adalah dimana Business Logic Layer (BLL) tidak bergantung (independent) kepada layer lain. Untuk lebih jelasnya dapat dilihat di blog yang ditulis oleh Jeffrey Palermo pada artikel [The Onion Architecture.](http://jeffreypalermo.com/blog/the-onion-architecture-part-1/)



![Onion Architecture](http://jeffreypalermo.com/files/media/image/WindowsLiveWriter/TheOnionArchitecturepart1_70A9/image%7B0%7D%5B59%5D.png)


##Layered Architecture Pattern

Secara konsep, kira-kira yang saya mengerti tentang Layered Architecture Pattern adalah seperti di bawah ini:

###Data Layer (Data Access Layer (DAL))

Ini adalah...

###Business Layer (Business Logic Layer (BLL))

Ini adalah...

###Services Layer (Messaging Layer)

Ini adalah...

###Presentation Layer (User Interface Layer (UI))

Ini adalah...

###Shared Type

Ini adalah...

####Frameworks

Ini adalah...




##References

1. [Layered Application Guidelines](https://msdn.microsoft.com/en-us/library/ee658109.aspx)
2. [Microsoft Application Architecture Guide, 2nd Edition](https://msdn.microsoft.com/en-us/library/ff650706.aspx)
3. [Serena Yeoh's blog : Layered Architecture for .NET](http://serena-yeoh.blogspot.co.id/2013/06/layered-architecture-for-net.html)
4. [Mark Seemann : Layers, Onions, Ports, Adapters: it's all the same.](http://blog.ploeh.dk/2013/12/03/layers-onions-ports-adapters-its-all-the-same/)
5. [Jeffrey Palermo's blog : the Onion Architecture part 1](http://jeffreypalermo.com/blog/the-onion-architecture-part-1/)
6. [http://alistair.cockburn.us/Hexagonal+architecture](http://alistair.cockburn.us/Hexagonal+architecture)
7. [http://dotnetdaily.net/tutorials/n-tier-architecture-asp-net/](http://dotnetdaily.net/tutorials/n-tier-architecture-asp-net/)
8. [http://www.hanselman.com/blog/AReminderOnThreeMultiTierLayerArchitectureDesignBroughtToYouByMyLateNightFrustrations.aspx](http://www.hanselman.com/blog/AReminderOnThreeMultiTierLayerArchitectureDesignBroughtToYouByMyLateNightFrustrations.aspx)



Sumber lain:

1. [Dependency Injection Best Practice in an N-tier Modular Application](http://www.developer.com/net/dependency-injection-best-practices-in-an-n-tier-modular-application.html)
2. [http://stackoverflow.com/questions/13786549/how-to-implement-3-tiers-architecture-in-c-sharp](http://stackoverflow.com/questions/13786549/how-to-implement-3-tiers-architecture-in-c-sharp)
3. [http://www.c-sharpcorner.com/UploadFile/4d9083/create-and-implement-3-tier-architecture-in-Asp-Net/](http://www.c-sharpcorner.com/UploadFile/4d9083/create-and-implement-3-tier-architecture-in-Asp-Net/)
4. [http://www.c-sharpcorner.com/UploadFile/dacca2/understand-3-tier-architecture-in-C-Sharp-net/](http://www.c-sharpcorner.com/UploadFile/dacca2/understand-3-tier-architecture-in-C-Sharp-net/)
5. [http://www.codeproject.com/Tips/662107/Understand-Tier-Architecture-in-Csharp](http://www.codeproject.com/Tips/662107/Understand-Tier-Architecture-in-Csharp)
6. [http://www.codeproject.com/Articles/36847/Three-Layer-Architecture-in-C-NET](http://www.codeproject.com/Articles/36847/Three-Layer-Architecture-in-C-NET)
7. [Creating a Business Logic Layer](https://msdn.microsoft.com/en-us/library/aa581779.aspx)
8. [http://martinfowler.com/eaaCatalog/index.html](http://martinfowler.com/eaaCatalog/index.html)
9. [https://msdn.microsoft.com/en-us/data/ff707264.aspx](https://msdn.microsoft.com/en-us/data/ff707264.aspx)
10. [https://msdn.microsoft.com/en-us/library/ms971568.aspx](https://msdn.microsoft.com/en-us/library/ms971568.aspx)
11. [http://www.c-sharpcorner.com/UploadFile/rmcochran/elegant_dal05212006130957PM/elegant_dal.aspx](http://www.c-sharpcorner.com/UploadFile/rmcochran/elegant_dal05212006130957PM/elegant_dal.aspx)
12. [http://www.agiledata.org/essays/implementationStrategies.html](http://www.agiledata.org/essays/implementationStrategies.html)
13. [http://www.databasedev.co.uk/data-access-layer.html](http://www.databasedev.co.uk/data-access-layer.html)
14. [http://rlacovara.blogspot.co.id/2009/02/high-performance-data-access-layer.html](http://rlacovara.blogspot.co.id/2009/02/high-performance-data-access-layer.html)
15. [http://bobcravens.com/2009/09/best-practices-for-using-linq-in-your-data-access-layer/](http://bobcravens.com/2009/09/best-practices-for-using-linq-in-your-data-access-layer/)