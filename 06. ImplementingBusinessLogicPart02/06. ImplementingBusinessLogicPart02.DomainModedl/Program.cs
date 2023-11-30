using _06._ImplementingBusinessLogicPart02.DomainModedl.EntitySamples;
using _06._ImplementingBusinessLogicPart02.DomainModedl.ValueObjects.Colors;
using _06._ImplementingBusinessLogicPart02.DomainModedl.ValueObjects.Person;



Color Red1 = new(255,0,0);
Color Red2 = new(255,0,0);

if(Red1 ==  Red2)
{
    Console.WriteLine("Eq");
}
else
{
    Console.WriteLine("NEq");
}
//PersonCodeSmell personCodeSmell = new PersonCodeSmell
//{
//    Id = 1,
//    Name = "Alireza",
//    Family = "Oroumand",
//    PhoneNumber = "09182309812",
//    Email = "ar.oroumand@gmail.com"
//};

//Person person = new(new PersonId("00000000"),
//    new FullName("Alireza", "Oroumand"), new Email("ar.oroumand@gmail.com"));


PersonEntity Me = new PersonEntity
{
    Id = 1,
    FirtsName ="Alireza",
    LastName = "Oroumand"
};
PersonEntity PesarAmoo = new PersonEntity
{
    Id = 1,
    FirtsName = "Hassan",
    LastName = "Oroumand"
};
