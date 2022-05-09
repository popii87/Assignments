using FamTree;

Person p = new Person();

p.Childs = new List<Person>()
{
    new Person(){Name = "Robert", hasChilds = false },
    new Person(){Name = "Marjan", hasChilds = true, Childs = new List<Person>(){ new Person(){Name = "Mia", hasChilds = false } } },
    new Person(){Name ="Maja", hasChilds = true, Childs= new List<Person>(){ new Person() { Name ="Marjan", hasChilds = false,
                                                  Childs = new List<Person>(){ new Person() {Name = "Elena", hasChilds = true,
                                                  Childs = new List<Person>(){ new Person() {Name = "Marko", hasChilds = false },
                                                                                 new Person(){Name = "Ognen", hasChilds = false } } } } } }}
};


p.PrintData(p, 1);